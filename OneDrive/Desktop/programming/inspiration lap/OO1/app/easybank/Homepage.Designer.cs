namespace easybank
{
    partial class home_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home_page));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profilebtn = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAccountToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.send_money_page = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.transaction_page_link = new System.Windows.Forms.Button();
            this.saved_transactionsbtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilebtn});
            this.menuStrip1.Location = new System.Drawing.Point(864, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(85, 503);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profilebtn
            // 
            this.profilebtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.profilebtn.Name = "profilebtn";
            this.profilebtn.Size = new System.Drawing.Size(72, 29);
            this.profilebtn.Text = "profile";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem1,
            this.deleteAccountToolStripMenuItem1});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(176, 34);
            this.settingsToolStripMenuItem.Text = "settings";
            // 
            // changePasswordToolStripMenuItem1
            // 
            this.changePasswordToolStripMenuItem1.Name = "changePasswordToolStripMenuItem1";
            this.changePasswordToolStripMenuItem1.Size = new System.Drawing.Size(253, 34);
            this.changePasswordToolStripMenuItem1.Text = "change password";
            // 
            // deleteAccountToolStripMenuItem1
            // 
            this.deleteAccountToolStripMenuItem1.Name = "deleteAccountToolStripMenuItem1";
            this.deleteAccountToolStripMenuItem1.Size = new System.Drawing.Size(253, 34);
            this.deleteAccountToolStripMenuItem1.Text = "delete account";
            // 
            // send_money_page
            // 
            this.send_money_page.Location = new System.Drawing.Point(287, 299);
            this.send_money_page.Name = "send_money_page";
            this.send_money_page.Size = new System.Drawing.Size(121, 53);
            this.send_money_page.TabIndex = 1;
            this.send_money_page.Text = "send money";
            this.send_money_page.UseVisualStyleBackColor = true;
            this.send_money_page.Click += new System.EventHandler(this.send_money_page_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Lavender;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // transaction_page_link
            // 
            this.transaction_page_link.Location = new System.Drawing.Point(449, 165);
            this.transaction_page_link.Name = "transaction_page_link";
            this.transaction_page_link.Size = new System.Drawing.Size(180, 54);
            this.transaction_page_link.TabIndex = 3;
            this.transaction_page_link.Text = "Transaction history";
            this.transaction_page_link.UseVisualStyleBackColor = true;
            this.transaction_page_link.Click += new System.EventHandler(this.transaction_page_link_Click);
            // 
            // saved_transactionsbtn
            // 
            this.saved_transactionsbtn.Location = new System.Drawing.Point(109, 165);
            this.saved_transactionsbtn.Name = "saved_transactionsbtn";
            this.saved_transactionsbtn.Size = new System.Drawing.Size(170, 54);
            this.saved_transactionsbtn.TabIndex = 4;
            this.saved_transactionsbtn.Text = "Saved Transactions";
            this.saved_transactionsbtn.UseVisualStyleBackColor = true;
            this.saved_transactionsbtn.Click += new System.EventHandler(this.saved_transactionsbtn_Click);
            // 
            // home_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(949, 503);
            this.Controls.Add(this.saved_transactionsbtn);
            this.Controls.Add(this.transaction_page_link);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.send_money_page);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "home_page";
            this.Text = "Home page";
            this.Load += new System.EventHandler(this.home_page_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profilebtn;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Button send_money_page;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteAccountToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button transaction_page_link;
        private System.Windows.Forms.Button saved_transactionsbtn;
    }
}

