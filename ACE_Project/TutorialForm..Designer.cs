namespace ACE_Project
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkpass = new System.Windows.Forms.LinkLabel();
            this.lblclose = new System.Windows.Forms.Label();
            this.lblmini = new System.Windows.Forms.Label();
            this.CsvOpenMkdirBtn = new System.Windows.Forms.Button();
            this.NewDataBtn = new System.Windows.Forms.Button();
            this.CsvOpenBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ACE Project";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(52, 112);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(139, 87);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(321, 290);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(408, 1);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(431, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "T U T O R I A L";
            // 
            // linkpass
            // 
            this.linkpass.AutoSize = true;
            this.linkpass.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.linkpass.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkpass.Location = new System.Drawing.Point(358, 305);
            this.linkpass.Name = "linkpass";
            this.linkpass.Size = new System.Drawing.Size(314, 15);
            this.linkpass.TabIndex = 0;
            this.linkpass.TabStop = true;
            this.linkpass.Text = "Copyright © 2020-2021 ACE Project All Rights Reserved.";
            // 
            // lblclose
            // 
            this.lblclose.AutoSize = true;
            this.lblclose.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblclose.ForeColor = System.Drawing.Color.DarkGray;
            this.lblclose.Location = new System.Drawing.Point(744, 9);
            this.lblclose.Name = "lblclose";
            this.lblclose.Size = new System.Drawing.Size(24, 16);
            this.lblclose.TabIndex = 10;
            this.lblclose.Text = "✕";
            this.lblclose.Click += new System.EventHandler(this.lblclose_Click);
            // 
            // lblmini
            // 
            this.lblmini.AutoSize = true;
            this.lblmini.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblmini.ForeColor = System.Drawing.Color.DarkGray;
            this.lblmini.Location = new System.Drawing.Point(714, 9);
            this.lblmini.Name = "lblmini";
            this.lblmini.Size = new System.Drawing.Size(24, 16);
            this.lblmini.TabIndex = 11;
            this.lblmini.Text = "―";
            this.lblmini.Click += new System.EventHandler(this.lblmini_Click);
            // 
            // CsvOpenMkdirBtn
            // 
            this.CsvOpenMkdirBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CsvOpenMkdirBtn.FlatAppearance.BorderSize = 0;
            this.CsvOpenMkdirBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CsvOpenMkdirBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CsvOpenMkdirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CsvOpenMkdirBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CsvOpenMkdirBtn.ForeColor = System.Drawing.Color.LightGray;
            this.CsvOpenMkdirBtn.Location = new System.Drawing.Point(436, 144);
            this.CsvOpenMkdirBtn.Name = "CsvOpenMkdirBtn";
            this.CsvOpenMkdirBtn.Size = new System.Drawing.Size(187, 48);
            this.CsvOpenMkdirBtn.TabIndex = 12;
            this.CsvOpenMkdirBtn.Text = "フォルダを作成して開く";
            this.CsvOpenMkdirBtn.UseVisualStyleBackColor = false;
            this.CsvOpenMkdirBtn.Click += new System.EventHandler(this.CsvOpenBtn_Click);
            // 
            // NewDataBtn
            // 
            this.NewDataBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.NewDataBtn.FlatAppearance.BorderSize = 0;
            this.NewDataBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.NewDataBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NewDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewDataBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewDataBtn.ForeColor = System.Drawing.Color.LightGray;
            this.NewDataBtn.Location = new System.Drawing.Point(436, 211);
            this.NewDataBtn.Name = "NewDataBtn";
            this.NewDataBtn.Size = new System.Drawing.Size(187, 48);
            this.NewDataBtn.TabIndex = 13;
            this.NewDataBtn.Text = "新規データ作成";
            this.NewDataBtn.UseVisualStyleBackColor = false;
            this.NewDataBtn.Click += new System.EventHandler(this.NewDataBtn_Click);
            // 
            // CsvOpenBtn
            // 
            this.CsvOpenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CsvOpenBtn.FlatAppearance.BorderSize = 0;
            this.CsvOpenBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CsvOpenBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CsvOpenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CsvOpenBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CsvOpenBtn.ForeColor = System.Drawing.Color.LightGray;
            this.CsvOpenBtn.Location = new System.Drawing.Point(436, 77);
            this.CsvOpenBtn.Name = "CsvOpenBtn";
            this.CsvOpenBtn.Size = new System.Drawing.Size(187, 48);
            this.CsvOpenBtn.TabIndex = 14;
            this.CsvOpenBtn.Text = "ＣＳＶファイルを開く";
            this.CsvOpenBtn.UseVisualStyleBackColor = false;
            this.CsvOpenBtn.Click += new System.EventHandler(this.CsvOpenBtn_Click_1);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.CsvOpenBtn);
            this.Controls.Add(this.NewDataBtn);
            this.Controls.Add(this.CsvOpenMkdirBtn);
            this.Controls.Add(this.lblmini);
            this.Controls.Add(this.lblclose);
            this.Controls.Add(this.linkpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "✕";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form6_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkpass;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblclose;
        private System.Windows.Forms.Label lblmini;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CsvOpenMkdirBtn;
        private System.Windows.Forms.Button NewDataBtn;
        private System.Windows.Forms.Button CsvOpenBtn;
    }
}