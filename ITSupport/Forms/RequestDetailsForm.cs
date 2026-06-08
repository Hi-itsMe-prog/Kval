using System;
using System.Linq;
using System.Windows.Forms;
using ITSupport.Helpers;
using ITSupport.Models;
using ITSupport.Services;

namespace ITSupport.Forms
{
    public partial class RequestDetailsForm : Form
    {
        private readonly AuthService _authService;
        private readonly RequestService _requestService;
        private readonly int _requestId;
        private Request _request;
        private bool _isIt;

        public RequestDetailsForm(AuthService authService, RequestService requestService, int requestId)
        {
            _authService = authService;
            _requestService = requestService;
            _requestId = requestId;
            _isIt = authService.IsITSpecialist();

            InitializeComponent();
            ApplyStyles();
            LoadRequest();
        }

        private void ApplyStyles()
        {
            BackColor = FormHelper.LightPastel;
            FormBorderStyle = FormBorderStyle.Sizable;
            StartPosition = FormStartPosition.CenterParent;
            Font = new System.Drawing.Font("Segoe UI", 9F);
            FormHelper.StyleTextBox(txtProblem, isMultiline: true);
            FormHelper.StyleTextBox(txtComment, isMultiline: true);
            FormHelper.StyleTextBox(txtSolution, isMultiline: true);
            FormHelper.StyleComboBox(cmbStatus);
            FormHelper.StyleButton(btnSaveStatus, FormHelper.PrimaryPastel);
            FormHelper.StyleButton(btnAddComment, FormHelper.PrimaryPastel);
            FormHelper.StyleButton(btnSaveSolution, FormHelper.SuccessPastel);
            FormHelper.StyleButton(btnClose, FormHelper.WhitePastel);
            FormHelper.StyleButton(btnSaveRating, FormHelper.SuccessPastel);
            FormHelper.StyleButton(btnCloseRequest, FormHelper.PrimaryPastel);
            lstComments.BackColor = FormHelper.LightPastel;
        }

        private void LoadRequest()
        {
            _request = _requestService.GetRequestById(_requestId);
            if (_request == null)
            {
                FormHelper.ShowError("Заявка не найдена.");
                Close();
                return;
            }

            Text = $"Заявка №{_request.Id}";
            txtProblem.Text = _request.ProblemDesc;

            string ratingText = _request.Rating.HasValue ? $" · Оценка: {_request.Rating}/5" : "";
            lblMeta.Text = $"{_request.UserName} · {FormHelper.FormatStatus(_request.Status)} · " +
                           $"{_request.CategoryName} · {_request.PriorityName} · " +
                           _request.CreatedAt.ToString("dd.MM.yyyy HH:mm") + ratingText;

            chkInternal.Visible = _isIt;

            if (_isIt)
            {
                panelEmployee.Visible = false;
                panelIt.Visible = true;
                panelRole.Visible = true;

                cmbStatus.Items.Clear();
                cmbStatus.Items.AddRange(new object[] { "New", "InProgress", "Resolved", "Closed" });
                cmbStatus.SelectedItem = _request.Status;

                bool hasSolution = _requestService.HasSolution(_requestId);
                txtSolution.Enabled = !hasSolution;
                btnSaveSolution.Enabled = !hasSolution;

                if (hasSolution)
                {
                    var solution = _requestService.GetSolutionByRequestId(_requestId);
                    txtSolution.Text = solution?.SolutionText ?? "";
                    txtSolution.ReadOnly = true;
                }
            }
            else
            {
                panelIt.Visible = false;
                SetupEmployeeActions();
            }

            LoadComments();
        }

        private void SetupEmployeeActions()
        {
            bool canRateOrClose = _request.Status == "Resolved" || _request.Status == "Closed";
            panelEmployee.Visible = canRateOrClose;
            panelRole.Visible = canRateOrClose;

            if (!canRateOrClose)
                return;

            if (_request.Rating.HasValue)
            {
                numRating.Value = _request.Rating.Value;
                numRating.Enabled = false;
                btnSaveRating.Enabled = false;
                lblRatingNote.Text = "Оценка сохранена";
            }
            else
            {
                numRating.Enabled = true;
                btnSaveRating.Enabled = true;
                lblRatingNote.Text = "";
            }

            btnCloseRequest.Enabled = _request.Status == "Resolved";
        }

        private void LoadComments()
        {
            lstComments.Items.Clear();
            var comments = _requestService
                .GetCommentsByRequestId(_requestId, _authService.GetCurrentUser())
                .ToList();

            foreach (var c in comments)
            {
                string prefix = c.IsInternal ? "[внутр.] " : "";
                lstComments.Items.Add(
                    $"{prefix}{c.AuthorName} ({c.Timestamp:dd.MM HH:mm}): {c.CommentText}");
            }
        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtComment.Text))
                return;

            try
            {
                var user = _authService.GetCurrentUser();
                if (_isIt && chkInternal.Checked)
                    _requestService.AddInternalComment(_requestId, user.Id, txtComment.Text.Trim());
                else
                    _requestService.AddComment(_requestId, user.Id, txtComment.Text.Trim());

                txtComment.Clear();
                chkInternal.Checked = false;
                LoadComments();
            }
            catch (Exception ex)
            {
                FormHelper.ShowError(ex.Message);
            }
        }

        private void btnInternalComment_Click(object sender, EventArgs e)
        {
            chkInternal.Checked = true;
            btnAddComment_Click(sender, e);
        }

        private void btnSaveStatus_Click(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedItem == null) return;

            try
            {
                _requestService.UpdateRequestStatus(_requestId, cmbStatus.SelectedItem.ToString());
                FormHelper.ShowInfo("Статус обновлён.");
                LoadRequest();
            }
            catch (Exception ex)
            {
                FormHelper.ShowError(ex.Message);
            }
        }

        private void btnSaveSolution_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSolution.Text))
            {
                FormHelper.ShowWarning("Введите текст решения.");
                return;
            }

            try
            {
                _requestService.AddSolution(
                    _requestId,
                    _authService.GetCurrentUser().Id,
                    txtSolution.Text.Trim());

                FormHelper.ShowInfo("Решение сохранено, заявка отмечена как решённая.");
                LoadRequest();
            }
            catch (Exception ex)
            {
                FormHelper.ShowError(ex.Message);
            }
        }

        private void btnSaveRating_Click(object sender, EventArgs e)
        {
            try
            {
                _requestService.RateRequest(
                    _requestId,
                    _authService.GetCurrentUser().Id,
                    (int)numRating.Value);

                FormHelper.ShowInfo("Спасибо за оценку!");
                LoadRequest();
            }
            catch (Exception ex)
            {
                FormHelper.ShowError(ex.Message);
            }
        }

        private void btnCloseRequest_Click(object sender, EventArgs e)
        {
            if (FormHelper.ShowQuestion("Закрыть заявку? Проблема считается полностью решённой.") != DialogResult.Yes)
                return;

            try
            {
                _requestService.CloseRequestByEmployee(_requestId, _authService.GetCurrentUser().Id);
                FormHelper.ShowInfo("Заявка закрыта.");
                LoadRequest();
            }
            catch (Exception ex)
            {
                FormHelper.ShowError(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void RequestDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
