using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.Data.SqlClient;

namespace Quan_Li_Kho_Thuoc_Tay
{
    public partial class FormDangNhap : Form
    {
        BUS_TaiKhoan tk = new BUS_TaiKhoan();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void chbShow_CheckedChanged(object sender, EventArgs e)
        {
            if(chbShow.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            } 
                
        }

        private void ptrclose_Click(object sender, EventArgs e)
        {
            Close();
        }


       
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Tài Khoản", "Thông Báo",MessageBoxButtons.OK);
                mySave.KT = false;
            }
            else if(txtMatKhau.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Mật Khẩu", "Thông Báo",MessageBoxButtons.OK);
            }
            else
            {
                DataTable x = tk.LoadTaiKhoan();
                int size = x.Rows.Count;
                bool check = false;
                for (int i = 0; i < size; i++)
                {
                    if(txtTaiKhoan.Text == x.Rows[i]["TaiKhoan"].ToString()&& txtMatKhau.Text == x.Rows[i]["MatKhau"].ToString())
                    {
                        check = true;
                        break;
                    }    
                }    
                if (check == true)
                {
                    MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo");
                    mySave.KT = !mySave.KT;
                    Close();

                }
                else
                {
                    MessageBox.Show("Tài Khoản hoặc mật khẩu sai", "Lỗi");
                }
            } 
                
                

            

        }
    }
}
