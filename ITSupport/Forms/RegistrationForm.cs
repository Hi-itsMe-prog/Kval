using System;
using System.Windows.Forms;
using ITSupport.Helpers;
using ITSupport.Services;

namespace ITSupport.Forms
{
    public partial class RegistrationForm : Form
    {
        private readonly AuthService _authService = new AuthService();

        public RegistrationForm()
        {
            InitializeComponent();
            ApplyStyles();
        }

        private void ApplyStyles()
        {
            FormHelper.StyleForm(this);
            foreach (var txt in new[] { txtFullName, txtLogin, txtEmail, txtPhone, txtPassword, txtConfirm })
                FormHelper.StyleTextBox(txt);
            FormHelper.StyleButton(btnRegister, FormHelper.SuccessPastel);
            FormHelper.StyleButton(btnBack, FormHelper.WhitePastel);
            FormHelper.StyleLabel(lblTitle, isTitle: true);
            panelScroll.BackColor = FormHelper.LightPastel;
            panelFooter.BackColor = FormHelper.LightPastel;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            if (!ValidateInput(out string error))
            {
                lblError.Text = error;
                lblError.Visible = true;
                return;
            }

            try
            {
                if (!_authService.Register(
                    txtLogin.Text,
                    txtPassword.Text,
                    txtFullName.Text,
                    txtEmail.Text,
                    txtPhone.Text))
                {
                    lblError.Text = "Такой логин уже занят.";
                    lblError.Visible = true;
                    return;
                }

                FormHelper.ShowInfo("Аккаунт создан. Теперь можно войти.");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                lblError.Text = "Ошибка регистрации: " + ex.Message;
                lblError.Visible = true;
            }
        }

        private bool ValidateInput(out string error)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                error = "Укажите ФИО.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtLogin.Text) || txtLogin.Text.Trim().Length < 3)
            {
                error = "Логин — не менее 3 символов.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text.Length < 4)
            {
                error = "Пароль — не менее 4 символов.";
                return false;
            }
            if (txtPassword.Text != txtConfirm.Text)
            {
                error = "Пароли не совпадают.";
                return false;
            }
            error = null;
            return true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
