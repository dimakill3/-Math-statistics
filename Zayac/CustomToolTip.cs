using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Zayac
{
    public class CustomToolTip : ToolTip
    {
        private Graphics g;
        private Image b;

        public CustomToolTip()
        {
            this.OwnerDraw = true;
            this.Popup += new PopupEventHandler(this.OnPopup);
            this.Draw += new DrawToolTipEventHandler(this.OnDraw);
        }

        private void OnPopup(object sender, PopupEventArgs e)
        {
            e.ToolTipSize = new Size(b.Width, b.Height);
        }

        private void OnDraw(object sender, DrawToolTipEventArgs e)
        {
            g = e.Graphics;
            g.DrawImage(b, new Point(0, 0));
            g.Dispose();
        }

        public void SetCustomToolTip(Control control, String name)
        {
            setImage(name);
            SetToolTip(control, "x");
        }

        public void setImage(String s)
        {
            this.b = Image.FromFile("images\\" + s);
        }

    }
}
