using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ACE_Project
{
    public class BtnFlat :Button
    {
        public BtnFlat()
        {
            BackColor = Color.FromArgb(255, 250, 250);
            ForeColor = Color.Black;
            Width = 91;
            Height = 23;
            this.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Font = new Font("UD デジタル 教科書体 NK-R", 9, FontStyle.Regular);
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            pevent.Graphics.FillRectangle(new SolidBrush(BackColor), 0, 0, this.Width, this.Height);
            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            TextRenderer.DrawText(pevent.Graphics, Text, Font, new Point(Width + 3, this.Height / 2), ForeColor, flags);
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            BackColor = onMouseHoverBackcolor;
        }
        //マウスカーソルが離れたあとの動作
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            BackColor = Color.FromArgb(255, 250, 250);
        }
        //マウスをクリックしている時の動作
        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            BackColor = Color.FromArgb(220, 220, 220);
        }
        //マウスをクリックしたあとの動作
        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            BackColor = Color.FromArgb(231, 235, 236);
        }
        //マウスカーソルのアイコン通過時の動作
        private Color onMouseHoverBackcolor = Color.FromArgb(231, 235, 236);
        public Color OnMouseHoverBackcolor
        {
            get { return onMouseHoverBackcolor; }
            set { onMouseHoverBackcolor = value; }
        }
    }
}
