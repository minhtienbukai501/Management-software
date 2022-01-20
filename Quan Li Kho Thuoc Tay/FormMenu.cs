using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Kho_Thuoc_Tay
{
    public partial class FormMenu : Form
    {

        void Lock_Unlock(bool check)
        {
            mnuDangXuat.Enabled = !check;
            mnuDangNhap.Enabled = mnuDoiMatKhau.Enabled = mnuTaoMatKhau.Enabled =  mnuThoat.Enabled = check;
        }
        public FormMenu()
        {
            InitializeComponent();
            Lock_Unlock(mySave.KT);
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            string s = "Phần Mềm Quản Lý Kho Thuốc Tây";
            int length = s.Length;
            for (int i = 0; i < length; i++)
            {
                lblPhanMem.Text += ' ';
            }
            lblPhanMem.Text += 'A'; 

        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            FormDangNhap frm = new FormDangNhap();
            frm.ShowDialog();

        }

        private void FormMenu_Activated(object sender, EventArgs e)
        {
            Lock_Unlock(mySave.KT);
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Chắc Muốn Đăng Xuất", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                mySave.KT = !mySave.KT;
                Lock_Unlock(mySave.KT);
            }    
           


        }
    }
}
