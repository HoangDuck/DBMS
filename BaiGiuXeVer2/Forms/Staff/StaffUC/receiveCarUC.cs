using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiGiuXeVer2.Forms.Staff.StaffUC
{
    public partial class receiveCarUC : UserControl
    {
        Classes.KhachHang.KhachHang kh = new Classes.KhachHang.KhachHang();
        public receiveCarUC()
        {
            InitializeComponent();
            dtmNgayGui.Value = DateTime.Now;
            dtmNgayTra.Value = DateTime.Now.AddDays(30);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dtmNgayGui.Value = DateTime.Now;
            dtmNgayTra.Value = DateTime.Now.AddDays(30);
            if (verif())
            {
                MessageBox.Show("Nội dung mới không khớp", "Nhận Xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String bienso = TextBox_BienSo.Text.Trim();
                String ten = TextBox_TenKH.Text.Trim();
                String diachi = TextBox_DiaChi.Text.Trim();
                DateTime ngaydk = dtmNgayGui.Value;
                DateTime ngayhh = dtmNgayTra.Value;
                String sdt = TextBox_SDT.Text.Trim();
                int phi = int.Parse(TextBox_Phi.Text.Trim());
                MemoryStream anh = new MemoryStream();
                pic_bieienso.Image.Save(anh, pic_bieienso.Image.RawFormat);
                try
                {
                    kh.themKhachHang(bienso, ten, diachi, sdt, anh);
                }
                catch
                {
                    //khong co code o day
                }
                    if (kh.dangkyThang(bienso, ngaydk, ngayhh, phi))
                {
                    MessageBox.Show("Đã thêm xe của khách hàng mới", "Them xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thông tin không hợp lệ", "Update Nhan Vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool verif()
        {
            if ((TextBox_BienSo.Text.Trim() == "") ||
                (TextBox_TenKH.Text.Trim() == "") ||
                (TextBox_DiaChi.Text.Trim() == "") ||
                (TextBox_SDT.Text.Trim() == "") ||
                (TextBox_Phi.Text.Trim() == ""))
                return true;
            else
                return false;
        }

        private void pic_bieienso_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Image(*.jpg;*.png;*.gif|*.jpg;*.png;*.gif)";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pic_bieienso.Image = Image.FromFile(open.FileName);
            }
        }
    }
}
