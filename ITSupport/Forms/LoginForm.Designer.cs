namespace ITSupport.Forms
{
    partial class LoginForm
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(30, 22, 30, 15);
            this.panelHeader.Size = new System.Drawing.Size(530, 105);
            this.panelHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(32, 60);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(234, 20);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Служба технической поддержки";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(30, 22);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(78, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "IT Support";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.lblLogin);
            this.panelMain.Controls.Add(this.txtLogin);
            this.panelMain.Controls.Add(this.lblPassword);
            this.panelMain.Controls.Add(this.txtPassword);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 105);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(40, 20, 40, 10);
            this.panelMain.Size = new System.Drawing.Size(530, 210);
            this.panelMain.TabIndex = 1;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(40, 20);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(52, 20);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Логин";
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogin.Location = new System.Drawing.Point(40, 42);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(449, 27);
            this.txtLogin.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(40, 90);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(62, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Пароль";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(40, 112);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(449, 27);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.lblError);
            this.panelFooter.Controls.Add(this.btnRegister);
            this.panelFooter.Controls.Add(this.btnLogin);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 315);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Padding = new System.Windows.Forms.Padding(40, 10, 40, 25);
            this.panelFooter.Size = new System.Drawing.Size(530, 185);
            this.panelFooter.TabIndex = 2;
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
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.Location = new System.Drawing.Point(40, 70);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(450, 50);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Регистрация";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Location = new System.Drawing.Point(40, 10);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(450, 50);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(530, 500);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(546, 538);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход — IT Support";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblError;
    }
}
