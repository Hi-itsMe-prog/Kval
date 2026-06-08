using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ITSupport.Helpers;
using ITSupport.Models;
using ITSupport.Services;

namespace ITSupport.Forms
{
    public partial class EmployeeForm : Form
    {
        private readonly AuthService _authService;
        private readonly RequestService _requestService = new RequestService();
        private List<RequestViewModel> _allRequests = new List<RequestViewModel>();

        public EmployeeForm(AuthService authService)
        {
            _authService = authService;
            InitializeComponent();
            ApplyStyles();
            lblUser.Text = _authService.GetCurrentUser()?.FullName ?? "";
            InitFilters();
            LoadRequests();
        }

        private void ApplyStyles()
        {
            FormHelper.StyleForm(this);
            FormHelper.ConfigureDataGridView(dgvRequests);
            FormHelper.StyleButton(btnNew, FormHelper.SuccessPastel);
            FormHelper.StyleButton(btnRefresh, FormHelper.PrimaryPastel);
            FormHelper.StyleButton(btnOpen, FormHelper.PrimaryPastel);
            FormHelper.StyleButton(btnLogout, FormHelper.DangerPastel);
            FormHelper.StyleTextBox(txtSearch);
            FormHelper.StyleLabel(lblTitle, isTitle: true);
            panelTop.BackColor = FormHelper.PrimaryPastel;
            panelFilter.BackColor = FormHelper.WhitePastel;

            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.ClientSize = new System.Drawing.Size(960, 520);
        }

        private void InitFilters()
        {
            // Только поиск по тексту
            txtSearch.TextChanged += (_, __) => ApplyFilters();
        }

        private void LoadRequests()
        {
            var user = _authService.GetCurrentUser();
            _allRequests = _requestService.GetRequestsForUser(user).ToList();
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            // Фильтрация только по тексту поиска
            // Передаём null для статуса и используем только поиск
            var filtered = RequestListHelper.ApplyFilter(_allRequests, null, txtSearch.Text, false, null);
            RequestListHelper.BindEmployeeGrid(dgvRequests, filtered);
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
                FormHelper.ShowWarning("Выберите заявку в списке.");
                return;
            }

            using (var details = new RequestDetailsForm(_authService, _requestService, id.Value))
            {
                details.ShowDialog();
            }
            LoadRequests();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            using (var form = new NewRequestForm(_authService.GetCurrentUser().Id))
            {
                if (form.ShowDialog() == DialogResult.OK)
                    LoadRequests();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadRequests();

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

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}