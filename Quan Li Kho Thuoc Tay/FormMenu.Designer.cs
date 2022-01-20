
namespace Quan_Li_Kho_Thuoc_Tay
{
    partial class FormMenu
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
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaoMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPhanMem = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1167, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangNhap,
            this.mnuDangXuat,
            this.mnuTaoMatKhau,
            this.mnuDoiMatKhau,
            this.mnuThoat});
            this.mnuHeThong.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(114, 29);
            this.mnuHeThong.Text = "Hệ Thống";
            // 
            // mnuDangNhap
            // 
            this.mnuDangNhap.Name = "mnuDangNhap";
            this.mnuDangNhap.Size = new System.Drawing.Size(224, 30);
            this.mnuDangNhap.Text = "Đăng Nhập";
            this.mnuDangNhap.Click += new System.EventHandler(this.mnuDangNhap_Click);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(224, 30);
            this.mnuDangXuat.Text = "Đăng Xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // mnuTaoMatKhau
            // 
            this.mnuTaoMatKhau.Name = "mnuTaoMatKhau";
            this.mnuTaoMatKhau.Size = new System.Drawing.Size(224, 30);
            this.mnuTaoMatKhau.Text = "Tạo Mật Khẩu";
            // 
            // mnuDoiMatKhau
            // 
            this.mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            this.mnuDoiMatKhau.Size = new System.Drawing.Size(224, 30);
            this.mnuDoiMatKhau.Text = "Đổi Mật Khẩu";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(224, 30);
            this.mnuThoat.Text = "Thoát";
            // 
            // lblPhanMem
            // 
            this.lblPhanMem.AutoSize = true;
            this.lblPhanMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhanMem.Location = new System.Drawing.Point(242, 277);
            this.lblPhanMem.Name = "lblPhanMem";
            this.lblPhanMem.Size = new System.Drawing.Size(0, 46);
            this.lblPhanMem.TabIndex = 1;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 619);
            this.Controls.Add(this.lblPhanMem);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "QUẢN LÍ KHO THUỐC TÂY";
            this.Activated += new System.EventHandler(this.FormMenu_Activated);
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuDangNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuTaoMatKhau;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.Label lblPhanMem;
    }
}

