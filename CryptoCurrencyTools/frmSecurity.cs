using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NobitexAPI.Sharp.User;
using NobitexAPI.Sharp.Security;
using System.Windows.Forms;

namespace CryptoCurrencyTools
{
    public partial class frmSecurity : Form
    {
        public frmSecurity()
        {
            InitializeComponent();
        }

        private async void btnEmergencyCancel_Click(object sender, EventArgs e)
        {
            EmergencyCancel cancel = new EmergencyCancel();
            var response = await cancel.EmergencyCancelRequestAsync(API.Client);
            MessageBox.Show("Cancel Code: " + response.cancelCode.code, response.status);
        }

        private async void frmSecurity_Load(object sender, EventArgs e)
        {
            GetLoginHistory history = new GetLoginHistory();
            var response = await history.GetLoginHistoryRequestAsync(API.Client);
            foreach (var attempt in response.attempts)
            {
                var control = new ucLoginHistory()
                {
                    Uc_Device = attempt.username,
                    Uc_IP = attempt.ip,
                    Uc_Status = attempt.status,
                    Uc_Time = attempt.createdAt.ToString("yyyy/MM/dd - HH:mm:ss"),
                    Dock = DockStyle.Top
                };
                pnlLoginHistoryData.Controls.Add(control);
            }
            if (response.attempts.Count == 0)
            {
                var control = new ucLoginHistory()
                {
                    Uc_Device = "No Login Attamp Available",
                    Dock = DockStyle.Top
                };
                pnlLoginHistoryData.Controls.Add(control);
            }
        }
    }
}
