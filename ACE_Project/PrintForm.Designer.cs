namespace ACE_Project
{
    partial class PrintForm
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
            this.panel = new System.Windows.Forms.Panel();
            this.dgvP1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dgvP1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(784, 561);
            this.panel.TabIndex = 3;
            // 
            // dgvP1
            // 
            this.dgvP1.AllowUserToAddRows = false;
            this.dgvP1.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvP1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvP1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvP1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvP1.ColumnHeadersVisible = false;
            this.dgvP1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4});
            this.dgvP1.Location = new System.Drawing.Point(12, 12);
            this.dgvP1.Name = "dgvP1";
            this.dgvP1.ReadOnly = true;
            this.dgvP1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvP1.RowHeadersVisible = false;
            this.dgvP1.RowTemplate.Height = 21;
            this.dgvP1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvP1.Size = new System.Drawing.Size(760, 527);
            this.dgvP1.TabIndex = 0;
            this.dgvP1.SelectionChanged += new System.EventHandler(this.dgvP1_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 350F;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 350;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 60;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 350F;
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 350;
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel);
            this.Name = "PrintForm";
            this.Text = "PrintForm";
            this.Load += new System.EventHandler(this.PrintForm_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvP1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridView dgvP1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}