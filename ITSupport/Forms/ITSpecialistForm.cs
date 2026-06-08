using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ITSupport.Helpers;
using ITSupport.Models;
using ITSupport.Services;

namespace ITSupport.Forms
{
    public partial class ITSpecialistForm : Form
    {
        private readonly AuthService _authService;
        private readonly RequestService _requestService = new RequestService();
        private List<RequestViewModel> _allRequests = new List<RequestViewModel>();

        public ITSpecialistForm(AuthService authService)
        {
            _authService = authService;
            InitializeComponent();
            ApplyStyles();
            lblUser.Text = _authService.GetCurrentUser()?.FullName ?? "";
            InitFilters();
            LoadData();
        }

        private void ApplyStyles()
        {
            FormHelper.StyleForm(this);
            FormHelper.ConfigureDataGridView(dgvRequests);
            FormHelper.StyleButton(btnRefresh, FormHelper.PrimaryPastel);
            FormHelper.StyleButton(btnOpen, FormHelper.PrimaryPastel);
            FormHelper.StyleButton(btnTake, FormHelper.WarningPastel);
            FormHelper.StyleButton(btnLogout, FormHelper.DangerPastel);
            FormHelper.StyleComboBox(cmbStatusFilter);
            FormHelper.StyleComboBox(cmbPriorityFilter);
            FormHelper.StyleTextBox(txtSearch);
            FormHelper.StyleLabel(lblTitle, isTitle: true);
            panelTop.BackColor = FormHelper.PrimaryPastel;
            panelStats.BackColor = FormHelper.WhitePastel;
            panelFilter.BackColor = FormHelper.WhitePastel;
            MinimumSize = new System.Drawing.Size(1000, 560);
            ClientSize = new System.Drawing.Size(1024, 560);
        }

        private void InitFilters()
        {
            cmbStatusFilter.Items.AddRange(FormHelper.StatusFilterItems);
            cmbStatusFilter.SelectedIndex = 0;

            cmbPriorityFilter.DisplayMember = "Name";
            cmbPriorityFilter.ValueMember = "Id";
            var priorities = _requestService.GetAllPriorities().ToList();
            cmbPriorityFilter.DataSource = priorities;
            cmbPriorityFilter.SelectedIndex = 0;

            cmbStatusFilter.SelectedIndexChanged += (_, __) => ApplyFilters();
            cmbPriorityFilter.SelectedIndexChanged += (_, __) => ApplyFilters();
            txtSearch.TextChanged += (_, __) => ApplyFilters();
        }

        private void LoadData()
        {
            lblNew.Text = _requestService.GetNewRequestsCount().ToString();
            lblInProgress.Text = _requestService.GetRequestsByStatusCount("InProgress").ToString();
            lblResolved.Text = _requestService.GetRequestsByStatusCount("Resolved").ToString();
            lblTotal.Text = _requestService.GetTotalRequestsCount().ToString();

            _allRequests = _requestService.GetRequestsForUser(_authService.GetCurrentUser()).ToList();
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            string statusCode = FormHelper.StatusFilterToCode(cmbStatusFilter.SelectedItem?.ToString());

            int? priorityId = null;
            if (cmbPriorityFilter.SelectedIndex > 0 && cmbPriorityFilter.SelectedValue != null)
                priorityId = Convert.ToInt32(cmbPriorityFilter.SelectedValue);

            var filtered = RequestListHelper.ApplyFilter(
                _allRequests,
                statusCode,
                txtSearch.Text,
                searchByUserName: true,
                priorityId: priorityId);

            RequestListHelper.BindItGrid(dgvRequests, filtered);
            lblCount.Text = $"Показано: {filtered.Count} из {_allRequests.Count}";
        }

        private int? GetSelectedRequestId()
        {
            if (dgvRequests.CurrentRow == null) return null;
            return Convert.ToInt32(dgvRequests.CurrentRow.Cells[0].Value);
        }

        private void OpenSelectedRequest()
        {
            var id = GetSelectedRequestId();
            if (!id.HasValue)
            {
                FormHelper.ShowWarning("Выберите заявку.");
                return;
            }

            using (var details = new RequestDetailsForm(_authService, _requestService, id.Value))
            {
                details.ShowDialog();
            }
            LoadData();
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            var id = GetSelectedRequestId();
            if (!id.HasValue)
            {
                FormHelper.ShowWarning("Выберите заявку.");
                return;
            }

            var request = _requestService.GetRequestById(id.Value);
            if (request == null)
            {
                FormHelper.ShowWarning("Заявка не найдена.");
                return;
            }

            if (request.Status != "New")
            {
                FormHelper.ShowWarning("В работу можно взять только новую заявку.");
                return;
            }

            try
            {
                _requestService.UpdateRequestStatus(id.Value, "InProgress");
                FormHelper.ShowInfo("Заявка взята в работу.");
                LoadData();
            }
            catch (Exception ex)
            {
                FormHelper.ShowError(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadData();

        private void btnOpen_Click(object sender, EventArgs e) => OpenSelectedRequest();

        private void dgvRequests_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                OpenSelectedRequest();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _authService.Logout();
            Close();
        }

        private void ITSpecialistForm_Load(object sender, EventArgs e) { }

        private void dgvRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}