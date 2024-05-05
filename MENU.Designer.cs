namespace BTN1
{
    partial class MENU
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhòngKhámToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.chứcNăngToolStripMenuItem,
            this.trợGiúpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(960, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DangNhap,
            this.thoátToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // DangNhap
            // 
            this.DangNhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangNhap.Image = global::BTN1.Properties.Resources.icons8_login_64;
            this.DangNhap.Name = "DangNhap";
            this.DangNhap.Size = new System.Drawing.Size(224, 26);
            this.DangNhap.Text = "Đăng nhập";
            this.DangNhap.Click += new System.EventHandler(this.DangNhap_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoátToolStripMenuItem.Image = global::BTN1.Properties.Resources.icons8_logout_100;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thoátToolStripMenuItem.Text = "Thoát ";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýPhòngKhámToolStripMenuItem,
            this.quảnLýSinhViênToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // quảnLýPhòngKhámToolStripMenuItem
            // 
            this.quảnLýPhòngKhámToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýPhòngKhámToolStripMenuItem.Image = global::BTN1.Properties.Resources.icons8_hospital_64;
            this.quảnLýPhòngKhámToolStripMenuItem.Name = "quảnLýPhòngKhámToolStripMenuItem";
            this.quảnLýPhòngKhámToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.quảnLýPhòngKhámToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.quảnLýPhòngKhámToolStripMenuItem.Text = "Quản lý phòng khám";
            this.quảnLýPhòngKhámToolStripMenuItem.Click += new System.EventHandler(this.quảnLýPhòngKhámToolStripMenuItem_Click);
            // 
            // quảnLýSinhViênToolStripMenuItem
            // 
            this.quảnLýSinhViênToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýSinhViênToolStripMenuItem.Image = global::BTN1.Properties.Resources.icons8_woman_student_48;
            this.quảnLýSinhViênToolStripMenuItem.Name = "quảnLýSinhViênToolStripMenuItem";
            this.quảnLýSinhViênToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.quảnLýSinhViênToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.quảnLýSinhViênToolStripMenuItem.Text = "Quản lý khách hàng";
            this.quảnLýSinhViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSinhViênToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem1
            // 
            this.trợGiúpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinToolStripMenuItem});
            this.trợGiúpToolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trợGiúpToolStripMenuItem1.Name = "trợGiúpToolStripMenuItem1";
            this.trợGiúpToolStripMenuItem1.Size = new System.Drawing.Size(89, 24);
            this.trợGiúpToolStripMenuItem1.Text = "Trợ giúp";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thôngTinToolStripMenuItem.Image = global::BTN1.Properties.Resources.icons8_info_popup_100;
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BTN1.Properties.Resources.phan_mem_quan_ly_nhan_vien_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 576);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MENU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ ĐA DỊCH VỤ";
            this.Load += new System.EventHandler(this.MENU_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DangNhap;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhòngKhámToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}