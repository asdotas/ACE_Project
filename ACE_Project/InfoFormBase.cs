using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACE_Project
{
    public  class InfoFormBase :Form
    {

        public  InfoFormBase()
        {
            this.Width = 800;
            this.Height = 600;
            this.AllowDrop = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.Opacity = 0.9;

        }


        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // InfoFormBase
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "InfoFormBase";
            this.ResumeLayout(false);

        }

    }
}
