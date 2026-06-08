namespace ITSupport.Forms
{
    partial class ITSpecialistForm
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
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            this.lblStatusFilter = new System.Windows.Forms.Label();
            this.cmbPriorityFilter = new System.Windows.Forms.ComboBox();
            this.lblPriorityFilter = new System.Windows.Forms.Label();
            this.panelStats = new System.Windows.Forms.Panel();
            this.lblNewCaption = new System.Windows.Forms.Label();
            this.lblNew = new System.Windows.Forms.Label();
            this.lblInProgressCaption = new System.Windows.Forms.Label();
            this.lblInProgress = new System.Windows.Forms.Label();
            this.lblResolvedCaption = new System.Windows.Forms.Label();
            this.lblResolved = new System.Windows.Forms.Label();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panelActions = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnTake = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelStats.SuspendLayout();
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
            this.panelTop.Size = new System.Drawing.Size(1050, 64);
            this.panelTop.TabIndex = 4;
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(1700, 22);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 20);
            this.lblCount.TabIndex = 0;
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
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(142, 32);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Все заявки";
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.txtSearch);
            this.panelFilter.Controls.Add(this.lblSearch);
            this.panelFilter.Controls.Add(this.cmbStatusFilter);
            this.panelFilter.Controls.Add(this.lblStatusFilter);
            this.panelFilter.Controls.Add(this.cmbPriorityFilter);
            this.panelFilter.Controls.Add(this.lblPriorityFilter);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(0, 132);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Padding = new System.Windows.Forms.Padding(20, 12, 20, 8);
            this.panelFilter.Size = new System.Drawing.Size(1050, 48);
            this.panelFilter.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(540, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1310, 27);
            this.txtSearch.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(480, 14);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(52, 20);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Поиск";
            // 
            // cmbStatusFilter
            // 
            this.cmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusFilter.Location = new System.Drawing.Point(72, 10);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.Size = new System.Drawing.Size(150, 28);
            this.cmbStatusFilter.TabIndex = 2;
            // 
            // lblStatusFilter
            // 
            this.lblStatusFilter.AutoSize = true;
            this.lblStatusFilter.Location = new System.Drawing.Point(0, 14);
            this.lblStatusFilter.Name = "lblStatusFilter";
            this.lblStatusFilter.Size = new System.Drawing.Size(52, 20);
            this.lblStatusFilter.TabIndex = 3;
            this.lblStatusFilter.Text = "Статус";
            // 
            // cmbPriorityFilter
            // 
            this.cmbPriorityFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriorityFilter.Location = new System.Drawing.Point(312, 10);
            this.cmbPriorityFilter.Name = "cmbPriorityFilter";
            this.cmbPriorityFilter.Size = new System.Drawing.Size(150, 28);
            this.cmbPriorityFilter.TabIndex = 4;
            // 
            // lblPriorityFilter
            // 
            this.lblPriorityFilter.AutoSize = true;
            this.lblPriorityFilter.Location = new System.Drawing.Point(240, 14);
            this.lblPriorityFilter.Name = "lblPriorityFilter";
            this.lblPriorityFilter.Size = new System.Drawing.Size(85, 20);
            this.lblPriorityFilter.TabIndex = 5;
            this.lblPriorityFilter.Text = "Приоритет";
            // 
            // panelStats
            // 
            this.panelStats.Controls.Add(this.lblNewCaption);
            this.panelStats.Controls.Add(this.lblNew);
            this.panelStats.Controls.Add(this.lblInProgressCaption);
            this.panelStats.Controls.Add(this.lblInProgress);
            this.panelStats.Controls.Add(this.lblResolvedCaption);
            this.panelStats.Controls.Add(this.lblResolved);
            this.panelStats.Controls.Add(this.lblTotalCaption);
            this.panelStats.Controls.Add(this.lblTotal);
            this.panelStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStats.Location = new System.Drawing.Point(0, 64);
            this.panelStats.Name = "panelStats";
            this.panelStats.Padding = new System.Windows.Forms.Padding(20, 12, 20, 8);
            this.panelStats.Size = new System.Drawing.Size(1050, 68);
            this.panelStats.TabIndex = 3;
            // 
            // lblNewCaption
            // 
            this.lblNewCaption.AutoSize = true;
            this.lblNewCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblNewCaption.Location = new System.Drawing.Point(24, 8);
            this.lblNewCaption.Name = "lblNewCaption";
            this.lblNewCaption.Size = new System.Drawing.Size(56, 20);
            this.lblNewCaption.TabIndex = 0;
            this.lblNewCaption.Text = "Новые";
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(151)))));
            this.lblNew.Location = new System.Drawing.Point(24, 28);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(0, 37);
            this.lblNew.TabIndex = 1;
            // 
            // lblInProgressCaption
            // 
            this.lblInProgressCaption.AutoSize = true;
            this.lblInProgressCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblInProgressCaption.Location = new System.Drawing.Point(180, 8);
            this.lblInProgressCaption.Name = "lblInProgressCaption";
            this.lblInProgressCaption.Size = new System.Drawing.Size(71, 20);
            this.lblInProgressCaption.TabIndex = 2;
            this.lblInProgressCaption.Text = "В работе";
            // 
            // lblInProgress
            // 
            this.lblInProgress.AutoSize = true;
            this.lblInProgress.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblInProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(179)))), ((int)(((byte)(8)))));
            this.lblInProgress.Location = new System.Drawing.Point(180, 28);
            this.lblInProgress.Name = "lblInProgress";
            this.lblInProgress.Size = new System.Drawing.Size(0, 37);
            this.lblInProgress.TabIndex = 3;
            // 
            // lblResolvedCaption
            // 
            this.lblResolvedCaption.AutoSize = true;
            this.lblResolvedCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblResolvedCaption.Location = new System.Drawing.Point(340, 8);
            this.lblResolvedCaption.Name = "lblResolvedCaption";
            this.lblResolvedCaption.Size = new System.Drawing.Size(82, 20);
            this.lblResolvedCaption.TabIndex = 4;
            this.lblResolvedCaption.Text = "Решённые";
            // 
            // lblResolved
            // 
            this.lblResolved.AutoSize = true;
            this.lblResolved.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblResolved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblResolved.Location = new System.Drawing.Point(340, 28);
            this.lblResolved.Name = "lblResolved";
            this.lblResolved.Size = new System.Drawing.Size(0, 37);
            this.lblResolved.TabIndex = 5;
            // 
            // lblTotalCaption
            // 
            this.lblTotalCaption.AutoSize = true;
            this.lblTotalCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblTotalCaption.Location = new System.Drawing.Point(520, 8);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Size = new System.Drawing.Size(48, 20);
            this.lblTotalCaption.TabIndex = 6;
            this.lblTotalCaption.Text = "Всего";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.lblTotal.Location = new System.Drawing.Point(520, 28);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 37);
            this.lblTotal.TabIndex = 7;
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.btnLogout);
            this.panelActions.Controls.Add(this.btnOpen);
            this.panelActions.Controls.Add(this.btnTake);
            this.panelActions.Controls.Add(this.btnRefresh);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActions.Location = new System.Drawing.Point(0, 564);
            this.panelActions.Name = "panelActions";
            this.panelActions.Padding = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.panelActions.Size = new System.Drawing.Size(1050, 56);
            this.panelActions.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(1730, 10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 36);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Выход";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(148, 10);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(120, 36);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Открыть";
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(280, 10);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(160, 36);
            this.btnTake.TabIndex = 2;
            this.btnTake.Text = "Взять в работу";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(16, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 36);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Обновить";
            // 
            // dgvRequests
            // 
            this.dgvRequests.ColumnHeadersHeight = 29;
            this.dgvRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRequests.Location = new System.Drawing.Point(0, 180);
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.RowHeadersWidth = 51;
            this.dgvRequests.Size = new System.Drawing.Size(1050, 384);
            this.dgvRequests.TabIndex = 0;
            this.dgvRequests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequests_CellContentClick);
            this.dgvRequests.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequests_CellDoubleClick);
            // 
            // ITSpecialistForm
            // 
            this.ClientSize = new System.Drawing.Size(1050, 620);
            this.Controls.Add(this.dgvRequests);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelStats);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1050, 600);
            this.Name = "ITSpecialistForm";
            this.Text = "IT Support — специалист";
            this.Load += new System.EventHandler(this.ITSpecialistForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelStats.ResumeLayout(false);
            this.panelStats.PerformLayout();
            this.panelActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lblStatusFilter;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.Label lblPriorityFilter;
        private System.Windows.Forms.ComboBox cmbPriorityFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Label lblNewCaption;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Label lblInProgressCaption;
        private System.Windows.Forms.Label lblInProgress;
        private System.Windows.Forms.Label lblResolvedCaption;
        private System.Windows.Forms.Label lblResolved;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dgvRequests;
    }
}