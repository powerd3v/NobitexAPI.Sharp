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
    public partial class frnProfile : Form
    {
        public frnProfile()
        {
            InitializeComponent();
        }
        DesigningCodes Designer = new DesigningCodes();

        private void pnlProfile_MouseEnter(object sender, EventArgs e)
        {
            Designer.changeColor(lblProfile, picProfile, pnlProfile, true);
        }

        private void pnlProfile_MouseLeave(object sender, EventArgs e)
        {
            Designer.changeColor(lblProfile, picProfile, pnlProfile, false);
        }

        private void pnlProfile_Click(object sender, EventArgs e)
        {
            Designer.FormShow(new frmProfileInfo(), pnlChangeForms);
        }

        private void pnlSecurity_MouseEnter(object sender, EventArgs e)
        {
            Designer.changeColor(lblSecurity, picSecurity, pnlSecurity, true);
        }

        private void pnlSecurity_MouseLeave(object sender, EventArgs e)
        {
            Designer.changeColor(lblSecurity, picSecurity, pnlSecurity, false);
        }

        private void pnlSecurity_Click(object sender, EventArgs e)
        {
            Designer.FormShow(new frmSecurity(), pnlChangeForms);
        }

        private void pnlReferrals_MouseEnter(object sender, EventArgs e)
        {
            Designer.changeColor(lblReferrals, picReferrals, pnlReferrals, true);
        }

        private void pnlReferrals_MouseLeave(object sender, EventArgs e)
        {
            Designer.changeColor(lblReferrals, picReferrals, pnlReferrals, false);
        }

        private void pnlReferrals_Click(object sender, EventArgs e)
        {
            Designer.FormShow(new frmReferrals(), pnlChangeForms);
        }

        private void frnProfile_Load(object sender, EventArgs e)
        {
            pnlProfile_Click(sender, e);
        }
    }
}
