using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoCurrencyTools
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void picTapRoot_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://blog.nobitex.ir/taproot/");
        }

        private void picBlockchain_Scalability_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://blog.nobitex.ir/blockchain-scalability/");
        }

        private void picShibaInno_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://blog.nobitex.ir/everything-you-need-to-know-about-shiba-inu/");
        }

        private void picBrowser_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://blog.nobitex.ir/blockchain-explorer/");
        }

        private void picIchimokuCloud_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://blog.nobitex.ir/what-is-the-ichimoku-cloud/");
        }

        private void picVolcanoEnergy_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://blog.nobitex.ir/mining-bitcoin-with-volcano-energy-in-el-salvador/");
        }
    }
}
