namespace ITSupport.Forms
{
    partial class RegistrationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelScroll = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.panelScroll.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelScroll
            // 
            this.panelScroll.AutoScroll = true;
            this.panelScroll.Controls.Add(this.lblTitle);
            this.panelScroll.Controls.Add(this.lblFullName);
            this.panelScroll.Controls.Add(this.txtFullName);
            this.panelScroll.Controls.Add(this.lblLogin);
            this.panelScroll.Controls.Add(this.txtLogin);
            this.panelScroll.Controls.Add(this.lblEmail);
            this.panelScroll.Controls.Add(this.txtEmail);
            this.panelScroll.Controls.Add(this.lblPhone);
            this.panelScroll.Controls.Add(this.txtPhone);
            this.panelScroll.Controls.Add(this.lblPassword);
            this.panelScroll.Controls.Add(this.txtPassword);
            this.panelScroll.Controls.Add(this.lblConfirm);
            this.panelScroll.Controls.Add(this.txtConfirm);
            this.panelScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelScroll.Location = new System.Drawing.Point(0, 0);
            this.panelScroll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelScroll.Name = "panelScroll";
            this.panelScroll.Padding = new System.Windows.Forms.Padding(40, 20, 40, 10);
            this.panelScroll.Size = new System.Drawing.Size(530, 400);
            this.panelScroll.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(40, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(96, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Регистрация";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(40, 65);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(42, 20);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "ФИО";
            // 
            // txtFullName
            // 
            this.txtFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFullName.Location = new System.Drawing.Point(40, 88);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(449, 27);
            this.txtFullName.TabIndex = 2;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(40, 132);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(52, 20);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Логин";
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogin.Location = new System.Drawing.Point(40, 155);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(449, 27);
            this.txtLogin.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(40, 200);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(40, 222);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(449, 27);
            this.txtEmail.TabIndex = 6;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(40, 268);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(69, 20);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "Телефон";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Location = new System.Drawing.Point(40, 290);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(449, 27);
            this.txtPhone.TabIndex = 8;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(40, 335);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(62, 20);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Пароль";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(40, 358);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(449, 27);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(40, 402);
            this.lblConfirm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(116, 20);
            this.lblConfirm.TabIndex = 11;
            this.lblConfirm.Text = "Повтор пароля";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirm.Location = new System.Drawing.Point(40, 425);
            this.txtConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(449, 27);
            this.txtConfirm.TabIndex = 12;
            this.txtConfirm.UseSystemPasswordChar = true;
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.lblError);
            this.panelFooter.Controls.Add(this.btnBack);
            this.panelFooter.Controls.Add(this.btnRegister);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 400);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Padding = new System.Windows.Forms.Padding(40, 10, 40, 25);
            this.panelFooter.Size = new System.Drawing.Size(530, 185);
            this.panelFooter.TabIndex = 1;
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblError.Location = new System.Drawing.Point(40, 130);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(450, 30);
            this.lblError.TabIndex = 2;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblError.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(40, 70);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(450, 50);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Назад к входу";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.Location = new System.Drawing.Point(40, 10);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(450, 50);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Создать аккаунт";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(530, 585);
            this.Controls.Add(this.panelScroll);
            this.Controls.Add(this.panelFooter);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(546, 613);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.panelScroll.ResumeLayout(false);
            this.panelScroll.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelScroll;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblError;
    }
}
