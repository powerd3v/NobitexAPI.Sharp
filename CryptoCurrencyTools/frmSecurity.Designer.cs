
namespace CryptoCurrencyTools
{
    partial class frmSecurity
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
            this.pnlMainSecurityMenu = new System.Windows.Forms.Panel();
            this.pnlLoginHistory = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEmergencyCancel = new System.Windows.Forms.Button();
            this.pnlLoginHistoryData = new System.Windows.Forms.Panel();
            this.pnlMainSecurityMenu.SuspendLayout();
            this.pnlLoginHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainSecurityMenu
            // 
            this.pnlMainSecurityMenu.Controls.Add(this.pnlLoginHistory);
            this.pnlMainSecurityMenu.Controls.Add(this.btnEmergencyCancel);
            this.pnlMainSecurityMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainSecurityMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMainSecurityMenu.Name = "pnlMainSecurityMenu";
            this.pnlMainSecurityMenu.Padding = new System.Windows.Forms.Padding(7);
            this.pnlMainSecurityMenu.Size = new System.Drawing.Size(383, 310);
            this.pnlMainSecurityMenu.TabIndex = 0;
            // 
            // pnlLoginHistory
            // 
            this.pnlLoginHistory.Controls.Add(this.pnlLoginHistoryData);
            this.pnlLoginHistory.Controls.Add(this.label1);
            this.pnlLoginHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoginHistory.Location = new System.Drawing.Point(7, 53);
            this.pnlLoginHistory.Name = "pnlLoginHistory";
            this.pnlLoginHistory.Padding = new System.Windows.Forms.Padding(9);
            this.pnlLoginHistory.Size = new System.Drawing.Size(369, 250);
            this.pnlLoginHistory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("IRANSansDN", 14F);
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(351, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "تاریخچه ورود";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEmergencyCancel
            // 
            this.btnEmergencyCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmergencyCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmergencyCancel.Font = new System.Drawing.Font("IRANSansDN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmergencyCancel.ForeColor = System.Drawing.Color.Red;
            this.btnEmergencyCancel.Location = new System.Drawing.Point(7, 7);
            this.btnEmergencyCancel.Name = "btnEmergencyCancel";
            this.btnEmergencyCancel.Size = new System.Drawing.Size(369, 46);
            this.btnEmergencyCancel.TabIndex = 0;
            this.btnEmergencyCancel.Text = "فعال سازی لغو اضطراری";
            this.btnEmergencyCancel.UseVisualStyleBackColor = true;
            this.btnEmergencyCancel.Click += new System.EventHandler(this.btnEmergencyCancel_Click);
            // 
            // pnlLoginHistoryData
            // 
            this.pnlLoginHistoryData.AutoScroll = true;
            this.pnlLoginHistoryData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoginHistoryData.Location = new System.Drawing.Point(9, 51);
            this.pnlLoginHistoryData.Name = "pnlLoginHistoryData";
            this.pnlLoginHistoryData.Size = new System.Drawing.Size(351, 190);
            this.pnlLoginHistoryData.TabIndex = 1;
            // 
            // frmSecurity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(383, 310);
            this.Controls.Add(this.pnlMainSecurityMenu);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(383, 310);
            this.Name = "frmSecurity";
            this.Text = "frmSecurity";
            this.Load += new System.EventHandler(this.frmSecurity_Load);
            this.pnlMainSecurityMenu.ResumeLayout(false);
            this.pnlLoginHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainSecurityMenu;
        private System.Windows.Forms.Panel pnlLoginHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEmergencyCancel;
        private System.Windows.Forms.Panel pnlLoginHistoryData;
    }
}