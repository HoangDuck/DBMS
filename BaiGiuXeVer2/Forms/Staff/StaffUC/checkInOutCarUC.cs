using BaiGiuXeVer2.Properties;
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
    public partial class checkInOutCarUC : UserControl
    {
        public checkInOutCarUC()
        {
            InitializeComponent();
            checkInOutCarUC_Load(null,null);
            
        }
        private void InitializeDate()
        {
            dtmGui.Value = DateTime.Now;
        }

        private void btnCapNhatVao_Click(object sender, EventArgs e)
        {
            if (gunaTextBoxBienXeNhap.Text.Trim() == "")
            {
                MessageBox.Show("Nhập biển số xe vào!", "Xe vào", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BaiGiuXeVer2.Classes.Xe.Xe xe = new Classes.Xe.Xe();
                xe.BienSo = gunaTextBoxBienXeNhap.Text.Trim();
                xe.CheckIn = DateTime.Now;
                pic_bieienso_nhap.Image.Save(xe.Picture, pic_bieienso_nhap.Image.RawFormat);
                xe.GuiXe(xe);
            }
            gunaTextBoxBienXeNhap.Text = "";
            pic_bieienso_nhap.Image = Resources.default_DDLK_avatar;
            InitializeDate();
            checkInOutCarUC_Load(null, null);
        }

        private void pic_bieienso_nhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Image(*.jpg;*.png;*.gif|*.jpg;*.png;*.gif)";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pic_bieienso_nhap.Image = Image.FromFile(open.FileName);
            }
        }

        private void checkInOutCarUC_Load(object sender, EventArgs e)
        {
            InitializeDate();
            LayDSBienXeVaoComboBox();
        }
        private void LayDSBienXeVaoComboBox()
        {
            BaiGiuXeVer2.Classes.Xe.Xe xe = new Classes.Xe.Xe();
            DataTable data = new DataTable();
            DataTable dataTable_Xe_Theo_Ngay = xe.LayDSBienXeTheoNgay();
            DataTable dataTable_Xe_Theo_Thang = xe.LayDSBienXeTheoThang();
            data.Merge(dataTable_Xe_Theo_Ngay);
            data.Merge(dataTable_Xe_Theo_Thang);
            cboBienSoRa.DataSource = data;
            cboBienSoRa.DisplayMember = "BienXe";
            cboBienSoRa.ValueMember = "BienXe";
            cboBienSoRa.SelectedItem = null;

        }

        private void cboBienSoRa_SelectedValueChanged(object sender, EventArgs e)
        {
            BaiGiuXeVer2.Classes.Xe.Xe xe = new Classes.Xe.Xe();
            String bienXe = cboBienSoRa.Text.Trim();
            if(bienXe== "System.Data.DataRowView"||bienXe==null||bienXe=="")
            {
                pic_bieienso_ra.Image = Resources.default_DDLK_avatar;
            }
            else
            {
                dtmRa.Value = DateTime.Now;
                xe.LayThongTinXeTuMotTrongHaiBai(bienXe);
                try
                {
                    pic_bieienso_ra.Image = Image.FromStream(xe.Picture);
                }
                catch
                {
                    MessageBox.Show("Không thể cho xe ra", "Xe ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            
        }

        private void btnCapNhatRa_Click(object sender, EventArgs e)
        {
            InitializeDate();
            if (cboBienSoRa.Text.Trim() == "")
            {
                MessageBox.Show("Nhập biển số xe vào!", "Xe ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BaiGiuXeVer2.Classes.Xe.Xe xe = new Classes.Xe.Xe();
                xe.BienSo = cboBienSoRa.Text.Trim().ToString();
                xe.LayThongTinXeTuMotTrongHaiBai(xe.BienSo);
                xe.CheckOut=DateTime.Now;
                xe.CapNhatCheckOutXeHoiTrongBai(xe);
                textPhi.Text = xe.TienPhi.ToString()+" VND";
                textPhat.Text = xe.TienPhat.ToString() + " VND";
                this.LayDSBienXeVaoComboBox();
            }
        }
    }
}
