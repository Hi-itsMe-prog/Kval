namespace ITSupport.Forms
{
    partial class NewRequestForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.lblProblem = new System.Windows.Forms.Label();
            this.txtProblem = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(24, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(103, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Новая заявка";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(24, 56);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(81, 20);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Категория";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Location = new System.Drawing.Point(24, 74);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(432, 28);
            this.cmbCategory.TabIndex = 2;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(24, 110);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(85, 20);
            this.lblPriority.TabIndex = 3;
            this.lblPriority.Text = "Приоритет";
            // 
            // cmbPriority
            // 
            this.cmbPriority.Location = new System.Drawing.Point(24, 128);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(432, 28);
            this.cmbPriority.TabIndex = 4;
            // 
            // lblProblem
            // 
            this.lblProblem.AutoSize = true;
            this.lblProblem.Location = new System.Drawing.Point(24, 164);
            this.lblProblem.Name = "lblProblem";
            this.lblProblem.Size = new System.Drawing.Size(157, 20);
            this.lblProblem.TabIndex = 5;
            this.lblProblem.Text = "Описание проблемы";
            // 
            // txtProblem
            // 
            this.txtProblem.Location = new System.Drawing.Point(24, 182);
            this.txtProblem.Multiline = true;
            this.txtProblem.Name = "txtProblem";
            this.txtProblem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProblem.Size = new System.Drawing.Size(432, 120);
            this.txtProblem.TabIndex = 6;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(24, 320);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(210, 40);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Создать";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(246, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(210, 40);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NewRequestForm
            // 
            this.ClientSize = new System.Drawing.Size(480, 380);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.lblProblem);
            this.Controls.Add(this.txtProblem);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "NewRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новая заявка";
            this.Load += new System.EventHandler(this.NewRequestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Label lblProblem;
        private System.Windows.Forms.TextBox txtProblem;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
    }
}
