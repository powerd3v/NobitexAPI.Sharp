
namespace CryptoCurrencyTools
{
    partial class frmProfileInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMainPersonalMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTransactionAmount = new System.Windows.Forms.Label();
            this.lblTransactionFee = new System.Windows.Forms.Label();
            this.lblUserLevel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlPersonalInfo = new System.Windows.Forms.Panel();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCards = new System.Windows.Forms.Panel();
            this.btnUserMarketInfo = new System.Windows.Forms.Button();
            this.btnMoreInfo = new System.Windows.Forms.Button();
            this.pnlMainPersonalMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlPersonalInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainPersonalMenu
            // 
            this.pnlMainPersonalMenu.AutoScroll = true;
            this.pnlMainPersonalMenu.Controls.Add(this.pnlCards);
            this.pnlMainPersonalMenu.Controls.Add(this.panel1);
            this.pnlMainPersonalMenu.Controls.Add(this.pnlPersonalInfo);
            this.pnlMainPersonalMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainPersonalMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMainPersonalMenu.Name = "pnlMainPersonalMenu";
            this.pnlMainPersonalMenu.Padding = new System.Windows.Forms.Padding(8);
            this.pnlMainPersonalMenu.Size = new System.Drawing.Size(383, 310);
            this.pnlMainPersonalMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(12)))));
            this.panel1.Controls.Add(this.btnUserMarketInfo);
            this.panel1.Controls.Add(this.lblTransactionAmount);
            this.panel1.Controls.Add(this.lblTransactionFee);
            this.panel1.Controls.Add(this.lblUserLevel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(8, 184);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(350, 176);
            this.panel1.TabIndex = 1;
            // 
            // lblTransactionAmount
            // 
            this.lblTransactionAmount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTransactionAmount.Font = new System.Drawing.Font("IRANSansDN", 10F);
            this.lblTransactionAmount.Location = new System.Drawing.Point(5, 99);
            this.lblTransactionAmount.Name = "lblTransactionAmount";
            this.lblTransactionAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTransactionAmount.Size = new System.Drawing.Size(340, 28);
            this.lblTransactionAmount.TabIndex = 4;
            this.lblTransactionAmount.Text = "ارزش معاملات 30 روز: ";
            this.lblTransactionAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTransactionFee
            // 
            this.lblTransactionFee.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTransactionFee.Font = new System.Drawing.Font("IRANSansDN", 10F);
            this.lblTransactionFee.Location = new System.Drawing.Point(5, 71);
            this.lblTransactionFee.Name = "lblTransactionFee";
            this.lblTransactionFee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTransactionFee.Size = new System.Drawing.Size(340, 28);
            this.lblTransactionFee.TabIndex = 3;
            this.lblTransactionFee.Text = "کارمزد معاملات: ";
            this.lblTransactionFee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserLevel
            // 
            this.lblUserLevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUserLevel.Font = new System.Drawing.Font("IRANSansDN", 10F);
            this.lblUserLevel.Location = new System.Drawing.Point(5, 43);
            this.lblUserLevel.Name = "lblUserLevel";
            this.lblUserLevel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUserLevel.Size = new System.Drawing.Size(340, 28);
            this.lblUserLevel.TabIndex = 2;
            this.lblUserLevel.Text = "سطح کاربری: ";
            this.lblUserLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("IRANSansDN", 13F);
            this.label5.Location = new System.Drawing.Point(5, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 38);
            this.label5.TabIndex = 1;
            this.label5.Text = "وضعیت حساب کاربری";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPersonalInfo
            // 
            this.pnlPersonalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(12)))));
            this.pnlPersonalInfo.Controls.Add(this.btnMoreInfo);
            this.pnlPersonalInfo.Controls.Add(this.lblPhoneNumber);
            this.pnlPersonalInfo.Controls.Add(this.lblLastName);
            this.pnlPersonalInfo.Controls.Add(this.lblFirstName);
            this.pnlPersonalInfo.Controls.Add(this.label1);
            this.pnlPersonalInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPersonalInfo.Location = new System.Drawing.Point(8, 8);
            this.pnlPersonalInfo.Name = "pnlPersonalInfo";
            this.pnlPersonalInfo.Padding = new System.Windows.Forms.Padding(5);
            this.pnlPersonalInfo.Size = new System.Drawing.Size(350, 176);
            this.pnlPersonalInfo.TabIndex = 0;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPhoneNumber.Font = new System.Drawing.Font("IRANSansDN", 10F);
            this.lblPhoneNumber.Location = new System.Drawing.Point(5, 99);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPhoneNumber.Size = new System.Drawing.Size(340, 28);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "موبایل: ";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLastName
            // 
            this.lblLastName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLastName.Font = new System.Drawing.Font("IRANSansDN", 10F);
            this.lblLastName.Location = new System.Drawing.Point(5, 71);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLastName.Size = new System.Drawing.Size(340, 28);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "نام خانوادگی: ";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFirstName.Font = new System.Drawing.Font("IRANSansDN", 10F);
            this.lblFirstName.Location = new System.Drawing.Point(5, 43);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFirstName.Size = new System.Drawing.Size(340, 28);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "نام: ";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("IRANSansDN", 13F);
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "اطلاعات شخصی";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCards
            // 
            this.pnlCards.AutoScroll = true;
            this.pnlCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCards.Location = new System.Drawing.Point(8, 360);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Size = new System.Drawing.Size(350, 127);
            this.pnlCards.TabIndex = 3;
            // 
            // btnUserMarketInfo
            // 
            this.btnUserMarketInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(12)))));
            this.btnUserMarketInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUserMarketInfo.FlatAppearance.BorderSize = 0;
            this.btnUserMarketInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserMarketInfo.Font = new System.Drawing.Font("IRANSansDN", 10F);
            this.btnUserMarketInfo.Image = global::CryptoCurrencyTools.Properties.Resources.back_100px_1;
            this.btnUserMarketInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUserMarketInfo.Location = new System.Drawing.Point(5, 127);
            this.btnUserMarketInfo.Name = "btnUserMarketInfo";
            this.btnUserMarketInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUserMarketInfo.Size = new System.Drawing.Size(340, 44);
            this.btnUserMarketInfo.TabIndex = 5;
            this.btnUserMarketInfo.Text = "اطاعات بیشتر ...";
            this.btnUserMarketInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserMarketInfo.UseVisualStyleBackColor = false;
            this.btnUserMarketInfo.Click += new System.EventHandler(this.btnUserMarketInfo_Click);
            // 
            // btnMoreInfo
            // 
            this.btnMoreInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(12)))));
            this.btnMoreInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMoreInfo.FlatAppearance.BorderSize = 0;
            this.btnMoreInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoreInfo.Font = new System.Drawing.Font("IRANSansDN", 10F);
            this.btnMoreInfo.Image = global::CryptoCurrencyTools.Properties.Resources.back_100px_1;
            this.btnMoreInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMoreInfo.Location = new System.Drawing.Point(5, 127);
            this.btnMoreInfo.Name = "btnMoreInfo";
            this.btnMoreInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnMoreInfo.Size = new System.Drawing.Size(340, 44);
            this.btnMoreInfo.TabIndex = 5;
            this.btnMoreInfo.Text = "اطاعات بیشتر ...";
            this.btnMoreInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoreInfo.UseVisualStyleBackColor = false;
            this.btnMoreInfo.Click += new System.EventHandler(this.btnMoreInfo_Click);
            // 
            // frmProfileInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(383, 310);
            this.Controls.Add(this.pnlMainPersonalMenu);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(383, 310);
            this.Name = "frmProfileInfo";
            this.Text = "frmProfileInfo";
            this.Load += new System.EventHandler(this.frmProfileInfo_Load);
            this.pnlMainPersonalMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlPersonalInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainPersonalMenu;
        private System.Windows.Forms.Panel pnlPersonalInfo;
        private System.Windows.Forms.Button btnMoreInfo;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUserMarketInfo;
        private System.Windows.Forms.Label lblTransactionAmount;
        private System.Windows.Forms.Label lblTransactionFee;
        private System.Windows.Forms.Label lblUserLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlCards;
    }
}