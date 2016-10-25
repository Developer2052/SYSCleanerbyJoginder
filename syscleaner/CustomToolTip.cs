using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace syscleaner
{
    class CustomToolTip : ToolTip
    {
        public CustomToolTip()
        {
            this.OwnerDraw = true;
            this.Popup += new PopupEventHandler(this.OnPopup);
            this.Draw += new DrawToolTipEventHandler(this.OnDraw);

        }

        private void OnPopup(object sender, PopupEventArgs e) // use this event to set the size of the tool tip
        {
           
            e.ToolTipSize = new Size(200, 200);
         
        }

        private void OnDraw(object sender, DrawToolTipEventArgs e) // use this event to customise the tool tip
        {
            Graphics g = e.Graphics;

            LinearGradientBrush b = new LinearGradientBrush(e.Bounds,
                Color.FromArgb(40, 129, 187), Color.MintCream, 45f);

            g.FillRectangle(b, e.Bounds);

            g.DrawRectangle(new Pen(Brushes.Red, 1), new Rectangle(e.Bounds.X, e.Bounds.Y,
                e.Bounds.Width - 1, e.Bounds.Height - 1));
          
            g.DrawString(e.ToolTipText, new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))), Brushes.White,
                new PointF(e.Bounds.X + 5, e.Bounds.Y + 5)); // top layer

            b.Dispose();
        }
    }
}