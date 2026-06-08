using System;
using System.Linq;
using System.Windows.Forms;
using ITSupport.Helpers;
using ITSupport.Services;

namespace ITSupport.Forms
{
    public partial class NewRequestForm : Form
    {
        private readonly RequestService _requestService = new RequestService();
        private readonly int _userId;

        public NewRequestForm(int userId)
        {
            _userId = userId;
            InitializeComponent();
            ApplyStyles();
            LoadLookups();
        }

        private void ApplyStyles()
        {
            FormHelper.StyleForm(this);
            FormHelper.StyleTextBox(txtProblem, isMultiline: true);
            FormHelper.StyleComboBox(cmbPriority);
            FormHelper.StyleComboBox(cmbCategory);
            FormHelper.StyleButton(btnCreate, FormHelper.SuccessPastel);
            FormHelper.StyleButton(btnCancel, FormHelper.WhitePastel);
            FormHelper.StyleLabel(lblTitle, isTitle: true);
        }

        private void LoadLookups()
        {
            cmbPriority.DisplayMember = "Name";
            cmbPriority.ValueMember = "Id";
            cmbPriority.DataSource = _requestService.GetAllPriorities().ToList();

            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
            cmbCategory.DataSource = _requestService.GetAllCategories().ToList();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProblem.Text))
            {
                FormHelper.ShowWarning("Опишите проблему.");
                return;
            }

            try
            {
                _requestService.CreateRequest(
                    _userId,
                    txtProblem.Text.Trim(),
                    (int)cmbPriority.SelectedValue,
                    (int)cmbCategory.SelectedValue);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                FormHelper.ShowError("Не удалось создать заявку: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void NewRequestForm_Load(object sender, EventArgs e)
        {

        }
    }
}
