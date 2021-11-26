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

namespace BaiGiuXeVer2.Forms.Staff
{
    public partial class mainFormStaff : Form
    {
        private int id;
        private string role;
        public mainFormStaff()
        {
            InitializeComponent();
        }
        public mainFormStaff(int id, String role)
        {
            this.id = id;
            this.role = role;
            InitializeComponent();
        }

        private void mainFormStaff_Load(object sender, EventArgs e)
        {
            this.closeAllUC();
            this.shiftInformationUC1.Visible = true;
            this.shiftInformationUC1.BringToFront();
        }

        private void closeAllUC()
        {
            editProfileUC1.Visible = false;
            changePasswordUC1.Visible = false;
            checkInOutCar1.Visible = false;
            receiveCarUC1.Visible = false;
            calendarUC1.Visible = false;
            shiftInformationUC1.Visible = false;
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            this.closeAllUC();
            editProfileUC1.Visible = true;
            editProfileUC1.BringToFront();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            this.closeAllUC();
            changePasswordUC1.Visible = true;
            changePasswordUC1.BringToFront();
        }

        private void btnNhanXe_Click(object sender, EventArgs e)
        {
            this.closeAllUC();
            receiveCarUC1.Visible = true;
            receiveCarUC1.BringToFront();
        }

        private void btnXeRaVao_Click(object sender, EventArgs e)
        {
            this.closeAllUC();
            checkInOutCar1.Visible = true;
            checkInOutCar1.BringToFront();
        }

        private void btnXeTrongbai_Click(object sender, EventArgs e)
        {
            this.closeAllUC();
            showListCarInPackUC1.Visible = true;
            showListCarInPackUC1.BringToFront();
        }

        private void btnLichLamViec_Click(object sender, EventArgs e)
        {
            this.closeAllUC();
            calendarUC1.Visible = true;
            calendarUC1.BringToFront();
        }

        private void btnThongTinCaLam_Click(object sender, EventArgs e)
        {
            this.closeAllUC();
            shiftInformationUC1.Visible = true;
            shiftInformationUC1.BringToFront();
        }

        private void shiftInformationUC1_Load(object sender, EventArgs e)
        {
            Classes.NhanVien.NhanVien nv = new Classes.NhanVien.NhanVien();
            DataTable data = nv.getNhanVien(this.id);
            label_Name.Text = data.Rows[0].ItemArray[1].ToString().Trim();
            try
            {
                byte[] b = (byte[])data.Rows[0].ItemArray[8];
                MemoryStream pic = new MemoryStream(b);
                Avatar_Pic.Image = Image.FromStream(pic);
            }
            catch
            {
                Avatar_Pic.Image = Properties.Resources.default_DDLK_avatar;
            }
        }
    }
}
