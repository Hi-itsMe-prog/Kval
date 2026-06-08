namespace ITSupport.Forms
{
    partial class EmployeeForm
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.panelActions = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblCount);
            this.panelTop.Controls.Add(this.lblUser);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(20, 12, 20, 8);
            this.panelTop.Size = new System.Drawing.Size(960, 64);
            this.panelTop.TabIndex = 4;
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCount.AutoSize = true;
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblCount.Location = new System.Drawing.Point(850, 22);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(92, 20);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "Показано: 0";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblUser.Location = new System.Drawing.Point(22, 40);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 20);
            this.lblUser.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(130, 28);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Мои заявки";
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.txtSearch);
            this.panelFilter.Controls.Add(this.lblSearch);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(0, 64);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Padding = new System.Windows.Forms.Padding(20, 8, 20, 8);
            this.panelFilter.Size = new System.Drawing.Size(960, 48);
            this.panelFilter.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(80, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(860, 27);
            this.txtSearch.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(22, 12);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(55, 20);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Поиск:";
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.btnLogout);
            this.panelActions.Controls.Add(this.btnOpen);
            this.panelActions.Controls.Add(this.btnRefresh);
            this.panelActions.Controls.Add(this.btnNew);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActions.Location = new System.Drawing.Point(0, 420);
            this.panelActions.Name = "panelActions";
            this.panelActions.Padding = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.panelActions.Size = new System.Drawing.Size(960, 56);
            this.panelActions.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(824, 10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 36);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Выход";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(168, 10);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(140, 36);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Открыть";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(316, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(140, 36);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(16, 10);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(140, 36);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "Новая заявка";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dgvRequests
            // 
            this.dgvRequests.ColumnHeadersHeight = 29;
            this.dgvRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRequests.Location = new System.Drawing.Point(0, 112);
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.RowHeadersWidth = 51;
            this.dgvRequests.Size = new System.Drawing.Size(960, 308);
            this.dgvRequests.TabIndex = 0;
            this.dgvRequests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequests_CellContentClick);
            this.dgvRequests.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequests_CellDoubleClick);
            // 
            // EmployeeForm
            // 
            this.ClientSize = new System.Drawing.Size(960, 476);
            this.Controls.Add(this.dgvRequests);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "EmployeeForm";
            this.Text = "IT Support — сотрудник";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dgvRequests;
    }
}