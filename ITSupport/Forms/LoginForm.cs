using System;
using System.Drawing;
using System.Windows.Forms;
using ITSupport.Helpers;
using ITSupport.Services;

namespace ITSupport.Forms
{
    public partial class LoginForm : Form
    {
        private readonly AuthService _authService = new AuthService();

        public LoginForm()
        {
            InitializeComponent();
            ApplyStyles();
        }

        private void ApplyStyles()
        {
            FormHelper.StyleForm(this);
            FormHelper.StyleTextBox(txtLogin);
            FormHelper.StyleTextBox(txtPassword);
            FormHelper.StyleButton(btnLogin, FormHelper.PrimaryPastel);
            FormHelper.StyleButton(btnRegister, FormHelper.WhitePastel);
            FormHelper.StyleLabel(lblTitle, isTitle: true);
            FormHelper.StyleLabel(lblSubtitle);
            FormHelper.StyleLabel(lblLogin);
            FormHelper.StyleLabel(lblPassword);
            panelHeader.BackColor = FormHelper.PrimaryPastel;
            panelMain.BackColor = FormHelper.LightPastel;
            panelFooter.BackColor = FormHelper.LightPastel;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ShowError("Введите логин и пароль.");
                return;
            }

            try
            {
                if (!_authService.Login(txtLogin.Text.Trim(), txtPassword.Text))
                {
                    ShowError("Неверный логин или пароль.");
                    return;
                }

                Hide();
                Form nextForm = _authService.IsITSpecialist()
                    ? (Form)new ITSpecialistForm(_authService)
                    : new EmployeeForm(_authService);

                nextForm.FormClosed += (_, __) =>
                {
                    txtPassword.Clear();
                    lblError.Visible = false;
                    Show();
                };
                nextForm.Show();
            }
            catch (Exception ex)
            {
                ShowError("Не удалось войти: " + ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Hide();
            using (var regForm = new RegistrationForm())
            {
                regForm.ShowDialog();
            }
            Show();
        }

        private void ShowError(string message)
        {
            lblError.Text = message;
            lblError.Visible = true;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
