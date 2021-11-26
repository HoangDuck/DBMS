using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiGiuXeVer2.Forms.Staff.StaffUC
{
    public partial class changePasswordUC : UserControl
    {
        public changePasswordUC()
        {
            InitializeComponent();
        }

        private void textCurrentPassword_Enter(object sender, EventArgs e)
        {
            if (textCurrentPassword.Text == "Current Password")
            {
                if (!cbShowPassword.Checked)
                {
                    textCurrentPassword.UseSystemPasswordChar = true;
                }
                else
                {
                    textCurrentPassword.UseSystemPasswordChar = false;
                }
                textCurrentPassword.Text = "";
            }
        }

        private void textCurrentPassword_Leave(object sender, EventArgs e)
        {
            if (textCurrentPassword.Text == "")
            {
                textCurrentPassword.UseSystemPasswordChar = false;
                textCurrentPassword.Text = "Current Password";
            }
        }

        private void textNewPassword_Enter(object sender, EventArgs e)
        {
            if (textNewPassword.Text == "New Password")
            {
                if (!cbShowPassword.Checked)
                {
                    textNewPassword.UseSystemPasswordChar = true;
                }
                else
                {
                    textNewPassword.UseSystemPasswordChar = false;
                }
                textNewPassword.Text = "";
            }
        }

        private void textNewPassword_Leave(object sender, EventArgs e)
        {
            if (textNewPassword.Text == "")
            {
                textNewPassword.UseSystemPasswordChar = false;
                textNewPassword.Text = "New Password";
            }
        }

        private void textConfirmNewPassword_Enter(object sender, EventArgs e)
        {
            if (textConfirmNewPassword.Text == "Confirm New Password")
            {
                if (!cbShowPassword.Checked)
                {
                    textConfirmNewPassword.UseSystemPasswordChar = true;
                }
                else
                {
                    textConfirmNewPassword.UseSystemPasswordChar = false;
                }
                textConfirmNewPassword.Text = "";
            }
        }

        private void textConfirmNewPassword_Leave(object sender, EventArgs e)
        {
            if (textConfirmNewPassword.Text == "")
            {
                textConfirmNewPassword.UseSystemPasswordChar = false;
                textConfirmNewPassword.Text = "Confirm New Password";
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                textCurrentPassword.UseSystemPasswordChar = false;
                textNewPassword.UseSystemPasswordChar = false;
                textConfirmNewPassword.UseSystemPasswordChar = false;
            }
            else
            {
                if (textCurrentPassword.Text != "Current Password")
                {
                    textCurrentPassword.UseSystemPasswordChar = true;
                }
                if (textNewPassword.Text != "New Password")
                {
                    textNewPassword.UseSystemPasswordChar = true;
                }
                if (textConfirmNewPassword.Text != "Confirm New Password")
                {
                    textConfirmNewPassword.UseSystemPasswordChar = true;
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Classes.NhanVien.NhanVien nv = new Classes.NhanVien.NhanVien();
            if ((textNewPassword.Text != textConfirmNewPassword.Text) || (textNewPassword.Text == ""))
            {
                MessageBox.Show("Mật khẩu mới không khớp", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (nv.changePass(textCurrentPassword.Text.Trim(), textNewPassword.Text.Trim(), 1))
                {
                    MessageBox.Show("Đã đổi mật khẩu", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Mật khẩu không khớp", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
