namespace Khenthuong
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khenThưởngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khenThưởngCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khenThưởngPhòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiKhenThưởngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem,
            this.nhânViênToolStripMenuItem,
            this.khenThưởngToolStripMenuItem,
            this.hệThốngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1605, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phòngBanToolStripMenuItem,
            this.chứcVụToolStripMenuItem,
            this.lươngToolStripMenuItem,
            this.ngườiDùngToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(144, 38);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // phòngBanToolStripMenuItem
            // 
            this.phòngBanToolStripMenuItem.Name = "phòngBanToolStripMenuItem";
            this.phòngBanToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.phòngBanToolStripMenuItem.Text = "Phòng ban";
            // 
            // chứcVụToolStripMenuItem
            // 
            this.chứcVụToolStripMenuItem.Name = "chứcVụToolStripMenuItem";
            this.chứcVụToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.chứcVụToolStripMenuItem.Text = "Chức vụ";
            // 
            // lươngToolStripMenuItem
            // 
            this.lươngToolStripMenuItem.Name = "lươngToolStripMenuItem";
            this.lươngToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.lươngToolStripMenuItem.Text = "Lương";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StaffToolStripMenuItem,
            this.tìmKiếmNhânViênToolStripMenuItem});
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(144, 38);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            // 
            // StaffToolStripMenuItem
            // 
            this.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem";
            this.StaffToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.StaffToolStripMenuItem.Text = "Quản lý nhân viên";
            this.StaffToolStripMenuItem.Click += new System.EventHandler(this.StaffToolStripMenuItem_Click);
            // 
            // tìmKiếmNhânViênToolStripMenuItem
            // 
            this.tìmKiếmNhânViênToolStripMenuItem.Name = "tìmKiếmNhânViênToolStripMenuItem";
            this.tìmKiếmNhânViênToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.tìmKiếmNhânViênToolStripMenuItem.Text = "Tìm kiếm nhân viên";
            // 
            // khenThưởngToolStripMenuItem
            // 
            this.khenThưởngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khenThưởngCáNhânToolStripMenuItem,
            this.khenThưởngPhòngBanToolStripMenuItem,
            this.loạiKhenThưởngToolStripMenuItem});
            this.khenThưởngToolStripMenuItem.Name = "khenThưởngToolStripMenuItem";
            this.khenThưởngToolStripMenuItem.Size = new System.Drawing.Size(174, 38);
            this.khenThưởngToolStripMenuItem.Text = "Khen thưởng";
            // 
            // khenThưởngCáNhânToolStripMenuItem
            // 
            this.khenThưởngCáNhânToolStripMenuItem.Name = "khenThưởngCáNhânToolStripMenuItem";
            this.khenThưởngCáNhânToolStripMenuItem.Size = new System.Drawing.Size(411, 44);
            this.khenThưởngCáNhânToolStripMenuItem.Text = "Khen thưởng cá nhân";
            // 
            // khenThưởngPhòngBanToolStripMenuItem
            // 
            this.khenThưởngPhòngBanToolStripMenuItem.Name = "khenThưởngPhòngBanToolStripMenuItem";
            this.khenThưởngPhòngBanToolStripMenuItem.Size = new System.Drawing.Size(411, 44);
            this.khenThưởngPhòngBanToolStripMenuItem.Text = "Khen thưởng phòng ban";
            // 
            // loạiKhenThưởngToolStripMenuItem
            // 
            this.loạiKhenThưởngToolStripMenuItem.Name = "loạiKhenThưởngToolStripMenuItem";
            this.loạiKhenThưởngToolStripMenuItem.Size = new System.Drawing.Size(411, 44);
            this.loạiKhenThưởngToolStripMenuItem.Text = "Loại khen thưởng";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(135, 38);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.ExitToolStripMenuItem.Text = "Thoát";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // ngườiDùngToolStripMenuItem
            // 
            this.ngườiDùngToolStripMenuItem.Name = "ngườiDùngToolStripMenuItem";
            this.ngườiDùngToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.ngườiDùngToolStripMenuItem.Text = "Người dùng";
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(0, 132);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1593, 779);
            this.panelMain.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1605, 923);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý khen thưởng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lươngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khenThưởngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khenThưởngCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khenThưởngPhòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loạiKhenThưởngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.Panel panelMain;
    }
}