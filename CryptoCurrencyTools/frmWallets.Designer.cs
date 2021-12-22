
namespace CryptoCurrencyTools
{
    partial class frmWallets
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlWalletsContainer = new System.Windows.Forms.Panel();
            this.pnlWallets = new System.Windows.Forms.Panel();
            this.pnlSearchBar = new System.Windows.Forms.Panel();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.txtSearchQuery = new System.Windows.Forms.TextBox();
            this.pnlMain.SuspendLayout();
            this.pnlWalletsContainer.SuspendLayout();
            this.pnlSearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("IRANSansDN", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(15, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(480, 131);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "کیف پول های من";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlWalletsContainer);
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(15);
            this.pnlMain.Size = new System.Drawing.Size(510, 558);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlWalletsContainer
            // 
            this.pnlWalletsContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.pnlWalletsContainer.Controls.Add(this.pnlWallets);
            this.pnlWalletsContainer.Controls.Add(this.pnlSearchBar);
            this.pnlWalletsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWalletsContainer.Location = new System.Drawing.Point(15, 146);
            this.pnlWalletsContainer.Name = "pnlWalletsContainer";
            this.pnlWalletsContainer.Size = new System.Drawing.Size(480, 397);
            this.pnlWalletsContainer.TabIndex = 1;
            // 
            // pnlWallets
            // 
            this.pnlWallets.AutoScroll = true;
            this.pnlWallets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWallets.Location = new System.Drawing.Point(0, 62);
            this.pnlWallets.Name = "pnlWallets";
            this.pnlWallets.Padding = new System.Windows.Forms.Padding(5);
            this.pnlWallets.Size = new System.Drawing.Size(480, 335);
            this.pnlWallets.TabIndex = 1;
            // 
            // pnlSearchBar
            // 
            this.pnlSearchBar.Controls.Add(this.picSearch);
            this.pnlSearchBar.Controls.Add(this.txtSearchQuery);
            this.pnlSearchBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchBar.Name = "pnlSearchBar";
            this.pnlSearchBar.Size = new System.Drawing.Size(480, 62);
            this.pnlSearchBar.TabIndex = 0;
            // 
            // picSearch
            // 
            this.picSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.picSearch.Image = global::CryptoCurrencyTools.Properties.Resources.search_96px;
            this.picSearch.Location = new System.Drawing.Point(407, 0);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(73, 62);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearch.TabIndex = 2;
            this.picSearch.TabStop = false;
            // 
            // txtSearchQuery
            // 
            this.txtSearchQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchQuery.Font = new System.Drawing.Font("IRANSansDN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchQuery.Location = new System.Drawing.Point(21, 16);
            this.txtSearchQuery.Name = "txtSearchQuery";
            this.txtSearchQuery.Size = new System.Drawing.Size(380, 33);
            this.txtSearchQuery.TabIndex = 1;
            this.txtSearchQuery.TextChanged += new System.EventHandler(this.txtSearchQuery_TextChanged);
            // 
            // frmWallets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(510, 558);
            this.Controls.Add(this.pnlMain);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(510, 550);
            this.Name = "frmWallets";
            this.Text = "frmWallets";
            this.Load += new System.EventHandler(this.frmWallets_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlWalletsContainer.ResumeLayout(false);
            this.pnlSearchBar.ResumeLayout(false);
            this.pnlSearchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlWalletsContainer;
        private System.Windows.Forms.Panel pnlWallets;
        private System.Windows.Forms.Panel pnlSearchBar;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.TextBox txtSearchQuery;
    }
}