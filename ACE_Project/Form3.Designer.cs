namespace ACE_Project
{
    partial class MakeDirInfoForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeDirInfoForm));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SavePathMainLbl = new System.Windows.Forms.Label();
            this.SavePathSubLbl = new System.Windows.Forms.Label();
            this.NodePathLbl = new System.Windows.Forms.Label();
            this.NodeNameLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.makeFolderBtn = new System.Windows.Forms.Button();
            this.cancellBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(27, 79);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(258, 382);
            this.treeView1.TabIndex = 0;
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "file.ico");
            // 
            // SavePathMainLbl
            // 
            this.SavePathMainLbl.AutoSize = true;
            this.SavePathMainLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SavePathMainLbl.Location = new System.Drawing.Point(21, 50);
            this.SavePathMainLbl.Name = "SavePathMainLbl";
            this.SavePathMainLbl.Size = new System.Drawing.Size(107, 14);
            this.SavePathMainLbl.TabIndex = 2;
            this.SavePathMainLbl.Text = "SavePathMainLbl";
            // 
            // SavePathSubLbl
            // 
            this.SavePathSubLbl.AutoSize = true;
            this.SavePathSubLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SavePathSubLbl.Location = new System.Drawing.Point(21, 88);
            this.SavePathSubLbl.Name = "SavePathSubLbl";
            this.SavePathSubLbl.Size = new System.Drawing.Size(101, 14);
            this.SavePathSubLbl.TabIndex = 3;
            this.SavePathSubLbl.Text = "SavePathSubLbl";
            // 
            // NodePathLbl
            // 
            this.NodePathLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.NodePathLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-R", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NodePathLbl.ForeColor = System.Drawing.Color.Black;
            this.NodePathLbl.Location = new System.Drawing.Point(12, 494);
            this.NodePathLbl.Name = "NodePathLbl";
            this.NodePathLbl.Size = new System.Drawing.Size(540, 32);
            this.NodePathLbl.TabIndex = 5;
            this.NodePathLbl.Text = "NodePath";
            // 
            // NodeNameLbl
            // 
            this.NodeNameLbl.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NodeNameLbl.Location = new System.Drawing.Point(24, 17);
            this.NodeNameLbl.Name = "NodeNameLbl";
            this.NodeNameLbl.Size = new System.Drawing.Size(570, 59);
            this.NodeNameLbl.TabIndex = 6;
            this.NodeNameLbl.Text = "NodeName";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SavePathMainLbl);
            this.panel1.Controls.Add(this.SavePathSubLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(327, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 113);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(11, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "サブフォルダ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(11, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "メインフォルダ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "フォルダ作成ファイルパス";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 483);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(642, 33);
            this.panel2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(328, 230);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(9);
            this.label4.Size = new System.Drawing.Size(282, 155);
            this.label4.TabIndex = 7;
            this.label4.Text = "ファルダ作成時の注意点\r\n\r\nファルダー作成に不適合な文字は使用しないで\r\nください。「.」「\"」「/」「\\」「[」「]」\r\n「:」「;」「|」「=」「,」等。\r" +
    "\n\r\nまた、先頭や末尾にスペースやピリオドも不適\r\n合です。以上確認の上お間違いがなければ、\r\n「フォルダ作成」ボタンを押してください。\r\n";
            // 
            // makeFolderBtn
            // 
            this.makeFolderBtn.Location = new System.Drawing.Point(331, 421);
            this.makeFolderBtn.Name = "makeFolderBtn";
            this.makeFolderBtn.Size = new System.Drawing.Size(113, 39);
            this.makeFolderBtn.TabIndex = 9;
            this.makeFolderBtn.Text = "フォルダ作成";
            this.makeFolderBtn.UseVisualStyleBackColor = true;
            this.makeFolderBtn.Click += new System.EventHandler(this.makeFolderBtn_Click);
            // 
            // cancellBtn
            // 
            this.cancellBtn.Location = new System.Drawing.Point(495, 422);
            this.cancellBtn.Name = "cancellBtn";
            this.cancellBtn.Size = new System.Drawing.Size(113, 39);
            this.cancellBtn.TabIndex = 10;
            this.cancellBtn.Text = "キャンセル";
            this.cancellBtn.UseVisualStyleBackColor = true;
            this.cancellBtn.Click += new System.EventHandler(this.cancellBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "ファルダ作成のパスをファイルに上書き保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MakeDirInfoForm
            // 
            this.ClientSize = new System.Drawing.Size(642, 516);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cancellBtn);
            this.Controls.Add(this.makeFolderBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NodePathLbl);
            this.Controls.Add(this.NodeNameLbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Name = "MakeDirInfoForm";
            this.Opacity = 1D;
            this.Text = "フォルダー管理";
            this.Load += new System.EventHandler(this.MakeDirInfoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label SavePathMainLbl;
        private System.Windows.Forms.Label SavePathSubLbl;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label NodePathLbl;
        private System.Windows.Forms.Label NodeNameLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button makeFolderBtn;
        private System.Windows.Forms.Button cancellBtn;
        private System.Windows.Forms.Button button1;
    }
}
