namespace ACE_Project
{
    partial class LogDgvForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.logDgvMain = new ACE_Project.LogDgv();
            this.logDgvSub = new ACE_Project.LogDgv();
            this.upTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upSend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logDgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logDgvSub)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 561);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.logDgvMain);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 535);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.logDgvSub);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 535);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sub";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // logDgvMain
            // 
            this.logDgvMain.BackgroundColor = System.Drawing.Color.Snow;
            this.logDgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logDgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.upTime,
            this.upSend,
            this.upPath});
            this.logDgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logDgvMain.GridColor = System.Drawing.Color.Snow;
            this.logDgvMain.Location = new System.Drawing.Point(3, 3);
            this.logDgvMain.Name = "logDgvMain";
            this.logDgvMain.RowTemplate.Height = 21;
            this.logDgvMain.Size = new System.Drawing.Size(770, 529);
            this.logDgvMain.TabIndex = 0;
            // 
            // logDgvSub
            // 
            this.logDgvSub.BackgroundColor = System.Drawing.Color.Snow;
            this.logDgvSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logDgvSub.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.logDgvSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logDgvSub.GridColor = System.Drawing.Color.Snow;
            this.logDgvSub.Location = new System.Drawing.Point(3, 3);
            this.logDgvSub.Name = "logDgvSub";
            this.logDgvSub.RowTemplate.Height = 21;
            this.logDgvSub.Size = new System.Drawing.Size(770, 529);
            this.logDgvSub.TabIndex = 2;
            // 
            // upTime
            // 
            this.upTime.FillWeight = 157F;
            this.upTime.HeaderText = "更新日時";
            this.upTime.Name = "upTime";
            this.upTime.Width = 157;
            // 
            // upSend
            // 
            this.upSend.FillWeight = 300F;
            this.upSend.HeaderText = "送り先パス";
            this.upSend.Name = "upSend";
            this.upSend.Width = 300;
            // 
            // upPath
            // 
            this.upPath.FillWeight = 300F;
            this.upPath.HeaderText = "送り元アイコン";
            this.upPath.Name = "upPath";
            this.upPath.Width = 300;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 157F;
            this.dataGridViewTextBoxColumn1.HeaderText = "更新日時";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 157;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 300F;
            this.dataGridViewTextBoxColumn2.HeaderText = "送り先パス";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 300F;
            this.dataGridViewTextBoxColumn3.HeaderText = "送り元アイコン";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // LogDgvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogDgvForm";
            this.Text = "LogDgvForm";
            this.Load += new System.EventHandler(this.LogDgvForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logDgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logDgvSub)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LogDgv logDgvMain;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private LogDgv logDgvSub;
        private System.Windows.Forms.DataGridViewTextBoxColumn upTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn upSend;
        private System.Windows.Forms.DataGridViewTextBoxColumn upPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}