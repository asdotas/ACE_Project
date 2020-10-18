namespace ACE_Project
{
    partial class NewUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUserForm));
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblmini = new System.Windows.Forms.Label();
            this.lblclose = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtnewpass = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtnewuser = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnok = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.txtcerialcode = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 1;
            // 
            // lblmini
            // 
            this.lblmini.AutoSize = true;
            this.lblmini.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblmini.ForeColor = System.Drawing.Color.DarkGray;
            this.lblmini.Location = new System.Drawing.Point(714, 9);
            this.lblmini.Name = "lblmini";
            this.lblmini.Size = new System.Drawing.Size(24, 16);
            this.lblmini.TabIndex = 13;
            this.lblmini.Text = "―";
            this.lblmini.Click += new System.EventHandler(this.lblmini_Click);
            // 
            // lblclose
            // 
            this.lblclose.AutoSize = true;
            this.lblclose.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblclose.ForeColor = System.Drawing.Color.DarkGray;
            this.lblclose.Location = new System.Drawing.Point(744, 9);
            this.lblclose.Name = "lblclose";
            this.lblclose.Size = new System.Drawing.Size(24, 16);
            this.lblclose.TabIndex = 12;
            this.lblclose.Text = "✕";
            this.lblclose.Click += new System.EventHandler(this.lblclose_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(423, 30);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(193, 27);
            this.label.TabIndex = 14;
            this.label.Text = "N E W   U S E R";
            // 
            // txtnewpass
            // 
            this.txtnewpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtnewpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnewpass.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtnewpass.ForeColor = System.Drawing.Color.DimGray;
            this.txtnewpass.Location = new System.Drawing.Point(312, 140);
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.Size = new System.Drawing.Size(408, 16);
            this.txtnewpass.TabIndex = 17;
            this.txtnewpass.Text = "NEW PASSWORD";
            this.txtnewpass.Enter += new System.EventHandler(this.txtnewpass_Enter);
            this.txtnewpass.Leave += new System.EventHandler(this.txtnewpass_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(312, 158);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(408, 1);
            this.panel3.TabIndex = 18;
            // 
            // txtnewuser
            // 
            this.txtnewuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtnewuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnewuser.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtnewuser.ForeColor = System.Drawing.Color.DimGray;
            this.txtnewuser.Location = new System.Drawing.Point(312, 86);
            this.txtnewuser.Name = "txtnewuser";
            this.txtnewuser.Size = new System.Drawing.Size(408, 16);
            this.txtnewuser.TabIndex = 15;
            this.txtnewuser.Text = "NEW USER";
            this.txtnewuser.Enter += new System.EventHandler(this.txtnewuser_Enter);
            this.txtnewuser.Leave += new System.EventHandler(this.txtnewuser_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(312, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 1);
            this.panel2.TabIndex = 16;
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnok.FlatAppearance.BorderSize = 0;
            this.btnok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnok.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.ForeColor = System.Drawing.Color.LightGray;
            this.btnok.Location = new System.Drawing.Point(312, 255);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(169, 40);
            this.btnok.TabIndex = 19;
            this.btnok.Text = "O K";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btncancel.FlatAppearance.BorderSize = 0;
            this.btncancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btncancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.LightGray;
            this.btncancel.Location = new System.Drawing.Point(551, 255);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(169, 40);
            this.btncancel.TabIndex = 20;
            this.btncancel.Text = "CANCEL";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // txtcerialcode
            // 
            this.txtcerialcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtcerialcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcerialcode.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtcerialcode.ForeColor = System.Drawing.Color.DimGray;
            this.txtcerialcode.Location = new System.Drawing.Point(312, 194);
            this.txtcerialcode.Name = "txtcerialcode";
            this.txtcerialcode.Size = new System.Drawing.Size(408, 16);
            this.txtcerialcode.TabIndex = 21;
            this.txtcerialcode.Text = "SERIAL CODE";
            this.txtcerialcode.Enter += new System.EventHandler(this.txtcerialcode_Enter);
            this.txtcerialcode.Leave += new System.EventHandler(this.txtcerialcode_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Location = new System.Drawing.Point(312, 212);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(408, 1);
            this.panel4.TabIndex = 22;
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.txtcerialcode);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtnewpass);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtnewuser);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lblmini);
            this.Controls.Add(this.lblclose);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewUserForm";
            this.Load += new System.EventHandler(this.NewUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblmini;
        private System.Windows.Forms.Label lblclose;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtnewpass;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtnewuser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.TextBox txtcerialcode;
        private System.Windows.Forms.Panel panel4;
    }
}