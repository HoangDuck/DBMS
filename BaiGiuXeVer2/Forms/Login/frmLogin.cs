using BaiGiuXeVer2.Forms.Manager;
using BaiGiuXeVer2.Forms.Staff;
using BaiGiuXeVer2.MyDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiGiuXeVer2.Forms.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        //------------DESIGN EVENT FORM----------------------------------------------------------
        private void textUser_Enter(object sender, EventArgs e)
        {
            if (textUser.Text == "Username")
            {
                textUser.Text = "";
            }
        }

        private void textUser_Leave(object sender, EventArgs e)
        {
            if (textUser.Text == "")
            {
                textUser.Text = "Username";
            }
        }

        private void textPassword_Enter(object sender, EventArgs e)
        {
            if (textPassword.Text == "Password")
            {
                if (!CheckBox_HienThiMK.Checked)
                {
                    textPassword.UseSystemPasswordChar = true;
                }
                textPassword.Text = "";
            }
        }

        private void textPassword_Leave(object sender, EventArgs e)
        {
            if (textPassword.Text == "")
            {
                textPassword.UseSystemPasswordChar = false;
                textPassword.Text = "Password";
            }
        }

        private void CheckBox_HienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_HienThiMK.Checked)
            {
                textPassword.UseSystemPasswordChar = false;
            }
            else if (textPassword.Text != "Password")
            {
                textPassword.UseSystemPasswordChar = true;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            MyDBConnection conn = new MyDBConnection("QuanLi");
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand com = new SqlCommand("select nhanvien.id, role_name from NhanVien, role_acc where username = @user and pass = @pass and nhanvien.id = role_acc.id_nv", conn.getConnection());
            com.Parameters.Add("@user", SqlDbType.VarChar).Value = textUser.Text.Trim();
            com.Parameters.Add("@pass", SqlDbType.VarChar).Value = textPassword.Text.Trim();
            da.SelectCommand = com;
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                int id = Convert.ToInt32(dt.Rows[0][0].ToString());
                string role = dt.Rows[0][1].ToString().Trim();
                if (role == "Admin" || role == "QuanLi")
                {
                    /*mainFormManager frm = new mainFormManager(id, role);
                    this.Visible = false;
                    frm.ShowDialog();*/
                }
                else
                {
                    mainFormStaff frm = new mainFormStaff(id, role);
                    this.Visible = false;
                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //--------------------------------------------------------------------------------

    }
}
