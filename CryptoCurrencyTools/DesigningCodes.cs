using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CryptoCurrencyTools
{
    public class DesigningCodes
    {
        public void changeColor(Label lbl, PictureBox pic, Panel pnl, bool hand)
        {
            if (hand)
            {
                lbl.BackColor = Color.FromArgb(35, 35, 30);
                pic.BackColor = Color.FromArgb(35, 35, 30);
                pnl.BackColor = Color.FromArgb(35, 35, 30);
                lbl.Cursor = Cursors.Hand;
                pic.Cursor = Cursors.Hand;
                pnl.Cursor = Cursors.Hand;
            }
            else
            {
                lbl.BackColor = Color.FromArgb(25, 25, 20);
                pic.BackColor = Color.FromArgb(25, 25, 20);
                pnl.BackColor = Color.FromArgb(25, 25, 20);
                lbl.Cursor = Cursors.Arrow;
                pic.Cursor = Cursors.Arrow;
                pnl.Cursor = Cursors.Arrow;
            }
        }
        public void FormShow(Form f, Panel p)
        {
            p.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            f.TopMost = true;
            p.Controls.Add(f);
            f.Show();
        }
    }
}
