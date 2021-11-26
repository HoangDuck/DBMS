using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiGiuXeVer2.Forms.Manager
{
    public partial class mainFormManager : Form
    {
        public mainFormManager()
        {
            InitializeComponent();
        }

        private void mainFormManager_Load(object sender, EventArgs e)
        {
            this.closeAllUC();
        }
        private void closeAllUC()
        {
            changePasswordUC1.Visible = false;
            editProfileUC1.Visible = false;
            showInfoStaffUC1.Visible = false;
            showListCarInPackUC1.Visible = false;
            statisticUC1.Visible = false;
            registerUC1.Visible = false;
            chiaCaUC1.Visible = false;
        }
        
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            this.closeAllUC();
            registerUC1.Visible = true;
            registerUC1.BringToFront();
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

        private void btnThongTinNhanVien_Click(object sender, EventArgs e)
        {
            this.closeAllUC();
            showInfoStaffUC1.Visible = true;
            showInfoStaffUC1.BringToFront();
        }

        private void btnXeTrongBai_Click(object sender, EventArgs e)
        {
            this.closeAllUC();
            showListCarInPackUC1.Visible = true;
            showListCarInPackUC1.BringToFront();
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            this.closeAllUC();
            statisticUC1.Visible = true;
            statisticUC1.BringToFront();
        }

        private void btnChiaCa_Click(object sender, EventArgs e)
        {
            this.closeAllUC();
            chiaCaUC1.Visible = true;
            chiaCaUC1.BringToFront();
        }
    }
}
