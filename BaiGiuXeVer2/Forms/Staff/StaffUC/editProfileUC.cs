using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiGiuXeVer2.Forms.Staff.StaffUC
{
    public partial class editProfileUC : UserControl
    {
        Classes.NhanVien.NhanVien nv = new Classes.NhanVien.NhanVien();
        private int maQL;
        public editProfileUC()
        {
            InitializeComponent();
        }

        private void editProfileUC_Load(object sender, EventArgs e)
        {
            DataTable table = nv.getNhanVien(1);
            TextBox_MaSo.Text = table.Rows[0]["Id"].ToString();
            TextBox_HoTen.Text = table.Rows[0]["TenNV"].ToString();
            if (table.Rows[0]["GioiTinh"].ToString().Trim() == "Nam")
                cboGioiTinh.SelectedItem = "Nam";
            else
                cboGioiTinh.SelectedItem = "Nữ";
            dtmNgaySinh.Value = (DateTime)table.Rows[0]["NgaySinh"];
            TextBox_SDT.Text = table.Rows[0]["SoDT"].ToString();
            TextBox_DiaChi.Text = table.Rows[0]["DiaChi"].ToString();
            int maQL = Convert.ToInt32(table.Rows[0]["MaQL"]);
            this.maQL = maQL;
            String tenQL = nv.LayTenQL(maQL);
            TextBox_TenQuanLy.Text = tenQL;
            
            try
            {
                byte[] pic = (byte[])table.Rows[0]["Anh"];
                MemoryStream picture = new MemoryStream(pic);
                pic_bienso.Image = Image.FromStream(picture);
            }
            catch
            {
                pic_bienso.Image = Properties.Resources.default_DDLK_avatar;
            }
        }

        bool verif()
        {
            if ((TextBox_MaSo.Text.Trim() == "") ||
                (TextBox_HoTen.Text.Trim() == "") ||
                (TextBox_DiaChi.Text.Trim() == "") ||
                (TextBox_SDT.Text.Trim() == ""))
                return true;
            else
                return false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                MessageBox.Show("Nội dung mới không khớp", "Update Nhan Vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = int.Parse(TextBox_MaSo.Text);
                String ten = TextBox_HoTen.Text.ToString() ;
                String gtinh = cboGioiTinh.Text.ToString();
                DateTime ngsinh = dtmNgaySinh.Value;
                String sdt = TextBox_SDT.Text;
                String diachi = TextBox_DiaChi.Text;
                MemoryStream pic = new MemoryStream();
                pic_bienso.Image.Save(pic, pic_bienso.Image.RawFormat);
                if (nv.updateNhanVien(id, ten, ngsinh, gtinh, sdt, diachi, pic,this.maQL))
                {
                    MessageBox.Show("Đã cập nhật nhân viên", "Update Nhan Vien", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thông tin không hợp lệ", "Update Nhan Vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pic_bienso_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Image(*.jpg;*.png;*.gif|*.jpg;*.png;*.gif)";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pic_bienso.Image = Image.FromFile(open.FileName);
            }
        }
    }
}
