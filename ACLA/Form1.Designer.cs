namespace ACLA
{
    partial class ACLAmainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACLAmainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxJiraUrl = new System.Windows.Forms.TextBox();
            this.txtBoxJiraLogin = new System.Windows.Forms.TextBox();
            this.txtBoxJiraEpicKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvSummary = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvEmailMatrix = new System.Windows.Forms.DataGridView();
            this.tabPageWaiting = new System.Windows.Forms.TabPage();
            this.pictureBoxWaiting = new System.Windows.Forms.PictureBox();
            this.txtBoxSignature = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxJiraPassword = new System.Windows.Forms.MaskedTextBox();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmailMatrix)).BeginInit();
            this.tabPageWaiting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWaiting)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jira URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jira login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jira password";
            // 
            // txtBoxJiraUrl
            // 
            this.txtBoxJiraUrl.Location = new System.Drawing.Point(122, 21);
            this.txtBoxJiraUrl.Name = "txtBoxJiraUrl";
            this.txtBoxJiraUrl.Size = new System.Drawing.Size(289, 20);
            this.txtBoxJiraUrl.TabIndex = 1;
            this.txtBoxJiraUrl.Text = "https://jira-p.objectivity.co.uk";
            // 
            // txtBoxJiraLogin
            // 
            this.txtBoxJiraLogin.Location = new System.Drawing.Point(122, 47);
            this.txtBoxJiraLogin.Name = "txtBoxJiraLogin";
            this.txtBoxJiraLogin.Size = new System.Drawing.Size(289, 20);
            this.txtBoxJiraLogin.TabIndex = 2;
            // 
            // txtBoxJiraEpicKey
            // 
            this.txtBoxJiraEpicKey.Location = new System.Drawing.Point(122, 99);
            this.txtBoxJiraEpicKey.Name = "txtBoxJiraEpicKey";
            this.txtBoxJiraEpicKey.Size = new System.Drawing.Size(289, 20);
            this.txtBoxJiraEpicKey.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Epic";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(627, 24);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(145, 126);
            this.btnGo.TabIndex = 6;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 607);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(769, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "v.0.1";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPageWaiting);
            this.tabControl1.Location = new System.Drawing.Point(15, 152);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(757, 443);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvSummary);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(749, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Summary";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvSummary
            // 
            this.dgvSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSummary.Location = new System.Drawing.Point(3, 3);
            this.dgvSummary.Name = "dgvSummary";
            this.dgvSummary.Size = new System.Drawing.Size(743, 411);
            this.dgvSummary.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvEmailMatrix);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(749, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Emails";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvEmailMatrix
            // 
            this.dgvEmailMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmailMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmailMatrix.Location = new System.Drawing.Point(3, 3);
            this.dgvEmailMatrix.Name = "dgvEmailMatrix";
            this.dgvEmailMatrix.Size = new System.Drawing.Size(743, 411);
            this.dgvEmailMatrix.TabIndex = 11;
            // 
            // tabPageWaiting
            // 
            this.tabPageWaiting.Controls.Add(this.pictureBoxWaiting);
            this.tabPageWaiting.Location = new System.Drawing.Point(4, 22);
            this.tabPageWaiting.Name = "tabPageWaiting";
            this.tabPageWaiting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWaiting.Size = new System.Drawing.Size(749, 417);
            this.tabPageWaiting.TabIndex = 2;
            this.tabPageWaiting.Text = "Waiting...";
            this.tabPageWaiting.UseVisualStyleBackColor = true;
            // 
            // pictureBoxWaiting
            // 
            this.pictureBoxWaiting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxWaiting.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxWaiting.Name = "pictureBoxWaiting";
            this.pictureBoxWaiting.Size = new System.Drawing.Size(743, 411);
            this.pictureBoxWaiting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWaiting.TabIndex = 0;
            this.pictureBoxWaiting.TabStop = false;
            // 
            // txtBoxSignature
            // 
            this.txtBoxSignature.Location = new System.Drawing.Point(122, 126);
            this.txtBoxSignature.Name = "txtBoxSignature";
            this.txtBoxSignature.Size = new System.Drawing.Size(289, 20);
            this.txtBoxSignature.TabIndex = 5;
            this.txtBoxSignature.Text = "Maciek";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email signature";
            // 
            // txtBoxJiraPassword
            // 
            this.txtBoxJiraPassword.Location = new System.Drawing.Point(122, 73);
            this.txtBoxJiraPassword.Name = "txtBoxJiraPassword";
            this.txtBoxJiraPassword.Size = new System.Drawing.Size(289, 20);
            this.txtBoxJiraPassword.TabIndex = 3;
            this.txtBoxJiraPassword.UseSystemPasswordChar = true;
            // 
            // ACLAmainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 629);
            this.Controls.Add(this.txtBoxJiraPassword);
            this.Controls.Add(this.txtBoxSignature);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtBoxJiraEpicKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxJiraLogin);
            this.Controls.Add(this.txtBoxJiraUrl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ACLAmainForm";
            this.Text = "ACLA";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmailMatrix)).EndInit();
            this.tabPageWaiting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWaiting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxJiraUrl;
        private System.Windows.Forms.TextBox txtBoxJiraLogin;
        private System.Windows.Forms.TextBox txtBoxJiraEpicKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvSummary;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvEmailMatrix;
        private System.Windows.Forms.TextBox txtBoxSignature;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.TabPage tabPageWaiting;
        private System.Windows.Forms.PictureBox pictureBoxWaiting;
        private System.Windows.Forms.MaskedTextBox txtBoxJiraPassword;
    }
}

