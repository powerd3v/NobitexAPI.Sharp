using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NobitexAPI.Sharp.User;
using System.Windows.Forms;

namespace CryptoCurrencyTools
{
    public partial class frmProfileInfo : Form
    {
        public frmProfileInfo()
        {
            InitializeComponent();
        }
        GetProfileDetailsResponse profData = new GetProfileDetailsResponse();
        GetUserLimitsResponse LimitsResponse = new GetUserLimitsResponse();
        private async void frmProfileInfo_Load(object sender, EventArgs e)
        {
            try
            {
                GetProfileDetails profileDetails = new GetProfileDetails();
                GetUserLimits limits = new GetUserLimits();
                LimitsResponse = await limits.GetUserLimitsRequestAsync(API.Client);
                profData = await profileDetails.GetProfileDetailsRequestAsync(API.Client);
                lblFirstName.Text = "نام: " + profData.profile.firstName;
                lblLastName.Text = "نام خانوادگی: " + profData.profile.lastName;
                lblPhoneNumber.Text = "موبایل: " + profData.profile.mobile;
                lblUserLevel.Text = "سطح کاربری: " + LimitsResponse.limitations.userLevel;
                lblTransactionFee.Text = "کارمزد معاملات: " + profData.profile.options.fee;
                lblTransactionAmount.Text = "ارزش معاملات 30 روز: " + profData.tradeStats.monthTradesTotal;
                foreach (var item in profData.profile.bankCards)
                {
                    Color color;
                    string confirm = "";
                    if (item.confirmed)
                    {
                        color = Color.LimeGreen;
                        confirm = "تایید شده";
                    }
                    else
                    {
                        color = Color.Red;
                        confirm = "تایید نشده";
                    }
                    var BankAccountControl = new ucBankAccountControl()
                    {
                        Uc_card_name = item.bank,
                        Uc_card_number = item.number,
                        Uc_card_status = confirm,
                        Uc_card_status_color = color,
                        Uc_title = "کارت های بانکی",
                        Dock = DockStyle.Top
                    };
                    BankAccountControl.AddNewCard += BankAccountControl_AddNewCard;
                    pnlCards.Controls.Add(BankAccountControl);
                }
                foreach (var item in profData.profile.bankAccounts)
                {
                    Color color;
                    string confirm = "";
                    if (item.confirmed)
                    {
                        color = Color.LimeGreen;
                        confirm = "تایید شده";
                    }
                    else
                    {
                        color = Color.Red;
                        confirm = "تایید نشده";
                    }
                    var BankAccountControl = new ucBankAccountControl()
                    {
                        Uc_card_name = item.bank,
                        Uc_card_number = item.number,
                        Uc_card_status = confirm,
                        Uc_card_status_color = color,
                        Uc_title = "حساب های بانکی",
                        Dock = DockStyle.Top
                    };
                    BankAccountControl.AddNewCard += BankAccountControl_AddNewCard;
                    pnlCards.Controls.Add(BankAccountControl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BankAccountControl_AddNewCard(object sender, EventArgs e)
        {
            new frmAddNewCard().Show();
        }

        private void btnMoreInfo_Click(object sender, EventArgs e)
        {
            string query = $"شهر: {profData.profile.city}\r\n" +
                $"ایمیل: {profData.profile.email}\r\n" +
                $"نام: {profData.profile.firstName}\r\n" +
                $"نام خانوادگی: {profData.profile.lastName}\r\n" +
                $"موبایل: {profData.profile.mobile}\r\n" +
                $"کد ملی: {profData.profile.nationalCode}\r\n" +
                $"شماره تلفن: {profData.profile.phone}\r\n" +
                $"برداشت واجد شرایط: {profData.profile.withdrawEligible}";
            MessageBox.Show(query,"اطلاعات حساب");
        }

        private void btnUserMarketInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
