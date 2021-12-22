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
    public partial class ucLoginHistory : UserControl
    {
        public ucLoginHistory()
        {
            InitializeComponent();
        }
        private string uc_Device;
        private string uc_Status;
        private string uc_IP;
        private string uc_Time;

        public string Uc_Device
        {
            get => uc_Device; set
            {
                uc_Device = value;
                lblDeviceInfo.Text = uc_Device;
            }
        }
        public string Uc_Status
        {
            get => uc_Status; set
            {
                uc_Status = value;
                lblStatus.Text = "وضعیت: " + uc_Status;
            }
        }
        public string Uc_IP
        {
            get => uc_IP; set
            {
                uc_IP = value;
                lblIP.Text = "آی پی: " + uc_IP;
            }
        }
        public string Uc_Time
        {
            get => uc_Time; set
            {
                uc_Time = value;
                lblTime.Text = "زمان: " + uc_Time;
            }
        }
    }
}
