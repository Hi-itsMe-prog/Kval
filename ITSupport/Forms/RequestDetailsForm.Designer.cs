namespace ITSupport.Forms
{
    partial class RequestDetailsForm
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
            this.txtProblem = new System.Windows.Forms.TextBox();
            this.lblMeta = new System.Windows.Forms.Label();
            this.panelRole = new System.Windows.Forms.Panel();
            this.panelIt = new System.Windows.Forms.Panel();
            this.panelSolution = new System.Windows.Forms.Panel();
            this.btnSaveSolution = new System.Windows.Forms.Button();
            this.txtSolution = new System.Windows.Forms.TextBox();
            this.lblSolution = new System.Windows.Forms.Label();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.btnSaveStatus = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panelEmployee = new System.Windows.Forms.Panel();
            this.lblRatingNote = new System.Windows.Forms.Label();
            this.btnCloseRequest = new System.Windows.Forms.Button();
            this.btnSaveRating = new System.Windows.Forms.Button();
            this.numRating = new System.Windows.Forms.NumericUpDown();
            this.lblRating = new System.Windows.Forms.Label();
            this.panelComments = new System.Windows.Forms.Panel();
            this.lstComments = new System.Windows.Forms.ListBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelFooterBottom = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkInternal = new System.Windows.Forms.CheckBox();
            this.flowCommentButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddComment = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.panelTop.SuspendLayout();
            this.panelRole.SuspendLayout();
            this.panelIt.SuspendLayout();
            this.panelSolution.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.panelEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).BeginInit();
            this.panelComments.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelFooterBottom.SuspendLayout();
            this.flowCommentButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.txtProblem);
            this.panelTop.Controls.Add(this.lblMeta);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(25, 20, 25, 15);
            this.panelTop.Size = new System.Drawing.Size(930, 160);
            this.panelTop.TabIndex = 0;
            // 
            // txtProblem
            // 
            this.txtProblem.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtProblem.Location = new System.Drawing.Point(25, 60);
            this.txtProblem.Margin = new System.Windows.Forms.Padding(4);
            this.txtProblem.Multiline = true;
            this.txtProblem.Name = "txtProblem";
            this.txtProblem.ReadOnly = true;
            this.txtProblem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProblem.Size = new System.Drawing.Size(880, 84);
            this.txtProblem.TabIndex = 1;
            // 
            // lblMeta
            // 
            this.lblMeta.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblMeta.Location = new System.Drawing.Point(25, 20);
            this.lblMeta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeta.Name = "lblMeta";
            this.lblMeta.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.lblMeta.Size = new System.Drawing.Size(880, 40);
            this.lblMeta.TabIndex = 0;
            // 
            // panelRole
            // 
            this.panelRole.AutoSize = true;
            this.panelRole.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelRole.Controls.Add(this.panelIt);
            this.panelRole.Controls.Add(this.panelEmployee);
            this.panelRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRole.Location = new System.Drawing.Point(0, 160);
            this.panelRole.Margin = new System.Windows.Forms.Padding(4);
            this.panelRole.Name = "panelRole";
            this.panelRole.Padding = new System.Windows.Forms.Padding(25, 0, 25, 10);
            this.panelRole.Size = new System.Drawing.Size(930, 285);
            this.panelRole.TabIndex = 1;
            // 
            // panelIt
            // 
            this.panelIt.AutoSize = true;
            this.panelIt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelIt.Controls.Add(this.panelSolution);
            this.panelIt.Controls.Add(this.panelStatus);
            this.panelIt.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIt.Location = new System.Drawing.Point(25, 60);
            this.panelIt.Margin = new System.Windows.Forms.Padding(4);
            this.panelIt.Name = "panelIt";
            this.panelIt.Size = new System.Drawing.Size(880, 215);
            this.panelIt.TabIndex = 0;
            this.panelIt.Visible = false;
            // 
            // panelSolution
            // 
            this.panelSolution.Controls.Add(this.btnSaveSolution);
            this.panelSolution.Controls.Add(this.txtSolution);
            this.panelSolution.Controls.Add(this.lblSolution);
            this.panelSolution.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSolution.Location = new System.Drawing.Point(0, 55);
            this.panelSolution.Margin = new System.Windows.Forms.Padding(4);
            this.panelSolution.Name = "panelSolution";
            this.panelSolution.Size = new System.Drawing.Size(880, 160);
            this.panelSolution.TabIndex = 1;
            // 
            // btnSaveSolution
            // 
            this.btnSaveSolution.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaveSolution.Location = new System.Drawing.Point(0, 104);
            this.btnSaveSolution.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnSaveSolution.Name = "btnSaveSolution";
            this.btnSaveSolution.Size = new System.Drawing.Size(880, 50);
            this.btnSaveSolution.TabIndex = 2;
            this.btnSaveSolution.Text = "Сохранить решение";
            this.btnSaveSolution.UseVisualStyleBackColor = false;
            this.btnSaveSolution.Click += new System.EventHandler(this.btnSaveSolution_Click);
            // 
            // txtSolution
            // 
            this.txtSolution.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSolution.Location = new System.Drawing.Point(0, 25);
            this.txtSolution.Margin = new System.Windows.Forms.Padding(4);
            this.txtSolution.Multiline = true;
            this.txtSolution.Name = "txtSolution";
            this.txtSolution.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSolution.Size = new System.Drawing.Size(880, 79);
            this.txtSolution.TabIndex = 1;
            // 
            // lblSolution
            // 
            this.lblSolution.AutoSize = true;
            this.lblSolution.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSolution.Location = new System.Drawing.Point(0, 0);
            this.lblSolution.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSolution.Name = "lblSolution";
            this.lblSolution.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblSolution.Size = new System.Drawing.Size(71, 25);
            this.lblSolution.TabIndex = 0;
            this.lblSolution.Text = "Решение";
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.btnSaveStatus);
            this.panelStatus.Controls.Add(this.cmbStatus);
            this.panelStatus.Controls.Add(this.lblStatus);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatus.Location = new System.Drawing.Point(0, 0);
            this.panelStatus.Margin = new System.Windows.Forms.Padding(4);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(880, 55);
            this.panelStatus.TabIndex = 0;
            // 
            // btnSaveStatus
            // 
            this.btnSaveStatus.Location = new System.Drawing.Point(310, 8);
            this.btnSaveStatus.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveStatus.Name = "btnSaveStatus";
            this.btnSaveStatus.Size = new System.Drawing.Size(162, 40);
            this.btnSaveStatus.TabIndex = 2;
            this.btnSaveStatus.Text = "Сохранить";
            this.btnSaveStatus.UseVisualStyleBackColor = false;
            this.btnSaveStatus.Click += new System.EventHandler(this.btnSaveStatus_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Location = new System.Drawing.Point(70, 10);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(224, 28);
            this.cmbStatus.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(0, 15);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 20);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Статус";
            // 
            // panelEmployee
            // 
            this.panelEmployee.Controls.Add(this.lblRatingNote);
            this.panelEmployee.Controls.Add(this.btnCloseRequest);
            this.panelEmployee.Controls.Add(this.btnSaveRating);
            this.panelEmployee.Controls.Add(this.numRating);
            this.panelEmployee.Controls.Add(this.lblRating);
            this.panelEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEmployee.Location = new System.Drawing.Point(25, 0);
            this.panelEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.panelEmployee.Name = "panelEmployee";
            this.panelEmployee.Size = new System.Drawing.Size(880, 60);
            this.panelEmployee.TabIndex = 1;
            this.panelEmployee.Visible = false;
            // 
            // lblRatingNote
            // 
            this.lblRatingNote.AutoSize = true;
            this.lblRatingNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblRatingNote.Location = new System.Drawing.Point(560, 22);
            this.lblRatingNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRatingNote.Name = "lblRatingNote";
            this.lblRatingNote.Size = new System.Drawing.Size(0, 20);
            this.lblRatingNote.TabIndex = 4;
            // 
            // btnCloseRequest
            // 
            this.btnCloseRequest.Location = new System.Drawing.Point(355, 10);
            this.btnCloseRequest.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseRequest.Name = "btnCloseRequest";
            this.btnCloseRequest.Size = new System.Drawing.Size(188, 45);
            this.btnCloseRequest.TabIndex = 3;
            this.btnCloseRequest.Text = "Закрыть заявку";
            this.btnCloseRequest.UseVisualStyleBackColor = false;
            this.btnCloseRequest.Click += new System.EventHandler(this.btnCloseRequest_Click);
            // 
            // btnSaveRating
            // 
            this.btnSaveRating.Location = new System.Drawing.Point(190, 10);
            this.btnSaveRating.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveRating.Name = "btnSaveRating";
            this.btnSaveRating.Size = new System.Drawing.Size(150, 45);
            this.btnSaveRating.TabIndex = 2;
            this.btnSaveRating.Text = "Оценить";
            this.btnSaveRating.UseVisualStyleBackColor = false;
            this.btnSaveRating.Click += new System.EventHandler(this.btnSaveRating_Click);
            // 
            // numRating
            // 
            this.numRating.Location = new System.Drawing.Point(110, 15);
            this.numRating.Margin = new System.Windows.Forms.Padding(4);
            this.numRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRating.Name = "numRating";
            this.numRating.Size = new System.Drawing.Size(62, 27);
            this.numRating.TabIndex = 1;
            this.numRating.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(0, 20);
            this.lblRating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(99, 20);
            this.lblRating.TabIndex = 0;
            this.lblRating.Text = "Оценка (1–5)";
            // 
            // panelComments
            // 
            this.panelComments.Controls.Add(this.lstComments);
            this.panelComments.Controls.Add(this.lblComments);
            this.panelComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelComments.Location = new System.Drawing.Point(0, 445);
            this.panelComments.Margin = new System.Windows.Forms.Padding(4);
            this.panelComments.Name = "panelComments";
            this.panelComments.Padding = new System.Windows.Forms.Padding(25, 5, 25, 10);
            this.panelComments.Size = new System.Drawing.Size(930, 75);
            this.panelComments.TabIndex = 2;
            // 
            // lstComments
            // 
            this.lstComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstComments.FormattingEnabled = true;
            this.lstComments.ItemHeight = 20;
            this.lstComments.Location = new System.Drawing.Point(25, 30);
            this.lstComments.Margin = new System.Windows.Forms.Padding(4);
            this.lstComments.Name = "lstComments";
            this.lstComments.Size = new System.Drawing.Size(880, 35);
            this.lstComments.TabIndex = 1;
            // 
            // lblComments
            // 
            this.lblComments.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblComments.Location = new System.Drawing.Point(25, 5);
            this.lblComments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(880, 25);
            this.lblComments.TabIndex = 0;
            this.lblComments.Text = "Комментарии";
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.panelFooterBottom);
            this.panelFooter.Controls.Add(this.flowCommentButtons);
            this.panelFooter.Controls.Add(this.txtComment);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 520);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(4);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Padding = new System.Windows.Forms.Padding(25, 10, 25, 20);
            this.panelFooter.Size = new System.Drawing.Size(930, 205);
            this.panelFooter.TabIndex = 3;
            // 
            // panelFooterBottom
            // 
            this.panelFooterBottom.Controls.Add(this.btnClose);
            this.panelFooterBottom.Controls.Add(this.chkInternal);
            this.panelFooterBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooterBottom.Location = new System.Drawing.Point(25, 140);
            this.panelFooterBottom.Margin = new System.Windows.Forms.Padding(4);
            this.panelFooterBottom.Name = "panelFooterBottom";
            this.panelFooterBottom.Size = new System.Drawing.Size(880, 45);
            this.panelFooterBottom.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(715, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(165, 45);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkInternal
            // 
            this.chkInternal.AutoSize = true;
            this.chkInternal.Location = new System.Drawing.Point(0, 12);
            this.chkInternal.Margin = new System.Windows.Forms.Padding(4);
            this.chkInternal.Name = "chkInternal";
            this.chkInternal.Size = new System.Drawing.Size(215, 24);
            this.chkInternal.TabIndex = 0;
            this.chkInternal.Text = "Внутренний комментарий";
            this.chkInternal.UseVisualStyleBackColor = true;
            // 
            // flowCommentButtons
            // 
            this.flowCommentButtons.Controls.Add(this.btnAddComment);
            this.flowCommentButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowCommentButtons.Location = new System.Drawing.Point(25, 74);
            this.flowCommentButtons.Margin = new System.Windows.Forms.Padding(4);
            this.flowCommentButtons.Name = "flowCommentButtons";
            this.flowCommentButtons.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowCommentButtons.Size = new System.Drawing.Size(880, 65);
            this.flowCommentButtons.TabIndex = 1;
            this.flowCommentButtons.WrapContents = false;
            // 
            // btnAddComment
            // 
            this.btnAddComment.Location = new System.Drawing.Point(0, 10);
            this.btnAddComment.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.Size = new System.Drawing.Size(175, 45);
            this.btnAddComment.TabIndex = 0;
            this.btnAddComment.Text = "Отправить";
            this.btnAddComment.UseVisualStyleBackColor = false;
            this.btnAddComment.Click += new System.EventHandler(this.btnAddComment_Click);
            // 
            // txtComment
            // 
            this.txtComment.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtComment.Location = new System.Drawing.Point(25, 10);
            this.txtComment.Margin = new System.Windows.Forms.Padding(4);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComment.Size = new System.Drawing.Size(880, 64);
            this.txtComment.TabIndex = 0;
            // 
            // RequestDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(930, 725);
            this.Controls.Add(this.panelComments);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelRole);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(946, 688);
            this.Name = "RequestDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Заявка";
            this.Load += new System.EventHandler(this.RequestDetailsForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelRole.ResumeLayout(false);
            this.panelRole.PerformLayout();
            this.panelIt.ResumeLayout(false);
            this.panelSolution.ResumeLayout(false);
            this.panelSolution.PerformLayout();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.panelEmployee.ResumeLayout(false);
            this.panelEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).EndInit();
            this.panelComments.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelFooterBottom.ResumeLayout(false);
            this.panelFooterBottom.PerformLayout();
            this.flowCommentButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblMeta;
        private System.Windows.Forms.TextBox txtProblem;
        private System.Windows.Forms.Panel panelRole;
        private System.Windows.Forms.Panel panelIt;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnSaveStatus;
        private System.Windows.Forms.Panel panelSolution;
        private System.Windows.Forms.Label lblSolution;
        private System.Windows.Forms.TextBox txtSolution;
        private System.Windows.Forms.Button btnSaveSolution;
        private System.Windows.Forms.Panel panelEmployee;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.NumericUpDown numRating;
        private System.Windows.Forms.Button btnSaveRating;
        private System.Windows.Forms.Button btnCloseRequest;
        private System.Windows.Forms.Label lblRatingNote;
        private System.Windows.Forms.Panel panelComments;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.ListBox lstComments;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.FlowLayoutPanel flowCommentButtons;
        private System.Windows.Forms.Button btnAddComment;
        private System.Windows.Forms.Panel panelFooterBottom;
        private System.Windows.Forms.CheckBox chkInternal;
        private System.Windows.Forms.Button btnClose;
    }
}
