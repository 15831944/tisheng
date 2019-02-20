using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class PanelEx :Panel
    {

        public PanelEx()
        {
            this.Paint += new PaintEventHandler(PaintDefault);
        }

        private void PaintDefault(object o,PaintEventArgs e)
        {
            Pen pen1 = new Pen(Color.Red, 1);
//             pen1.Brush = System.Drawing.Drawing2D.DashStyle.Dash;
//             pen1.DashPattern = new float[] { 4f, 2f };
            e.Graphics.DrawRectangle(pen1, 0, 0, this.Width - 10, this.Height - 10);
        }
        
    }
}
