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
    public partial class showListCarInPackUC : UserControl
    {
        public showListCarInPackUC()
        {
            InitializeComponent();
            showListCarInPackUC_Load(null, null);
        }
        public void ClearController()
        {
            TextBox_BienSo.Text = "";
            TextBoxt_GhiChu.Text = "";
            gunaTextBox1.Text = "";
            gunaTextBox2.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Classes.Xe.Xe xe = new Classes.Xe.Xe();
            Classes.KhachHang.KhachHang kh = new Classes.KhachHang.KhachHang();
            if (TextBox_Search.Text.Trim() != "")
            {
                String bienXe = TextBox_Search.Text.Trim();
                DataTable data = new DataTable();
                if (radiobtnNgay.Checked)
                {
                    data = xe.LayDSXeTheoNgay(bienXe);
                    TextBox_BienSo.Text = data.Rows[0].ItemArray[0].ToString();
                    gunaDateTimePicker1.Value = (DateTime)data.Rows[0].ItemArray[1];
                }
                else if (radiobtnThang.Checked)
                {
                    data = xe.LayDSXeTheoThang(bienXe);
                    DataTable thongTinKH = kh.ThongTinKH(bienXe);
                    gunaTextBox1.Text = thongTinKH.Rows[0].ItemArray[1].ToString();
                    gunaTextBox2.Text = thongTinKH.Rows[0].ItemArray[3].ToString();
                    TextBoxt_GhiChu.Text = thongTinKH.Rows[0].ItemArray[2].ToString();
                    TextBox_BienSo.Text = data.Rows[0].ItemArray[0].ToString();
                    gunaDateTimePicker1.Value = (DateTime)data.Rows[0].ItemArray[1];
                }
            }
            else
            {
                ClearController();
            }
        }

        private void showListCarInPackUC_Load(object sender, EventArgs e)
        {
            //NapDLVaoDGV();
        }

        public void NapDLVaoDGV()
        {
            Classes.Xe.Xe xe = new Classes.Xe.Xe();
            DataTable dataXeNgay = xe.LayXeTrongBaiTheoNgay();
            DataColumn dataColumnXeNgay = new DataColumn("Gửi theo", typeof(String));
            dataColumnXeNgay.DefaultValue = "Ngày";
            dataXeNgay.Columns.Add(dataColumnXeNgay);
            DataTable dataXeThang = xe.LayXeTrongBaiTheoThang();
            DataColumn dataColumnXeThang = new DataColumn("Gửi theo", typeof(String));
            dataColumnXeThang.DefaultValue = "Tháng";
            dataXeThang.Columns.Add(dataColumnXeThang);
            DataTable data = new DataTable();
            data.Merge(dataXeNgay);
            data.Merge(dataXeThang);
            gunaDataGridView1.DataSource = data;
            gunaDataGridView1.Columns["BienXe"].HeaderText = "Biển xe";
            gunaDataGridView1.Columns["Check_in"].HeaderText = "Check In";
            gunaDataGridView1.Columns["Check_out"].HeaderText = "Check Out";
            
            gunaDataGridView1.ColumnHeadersHeight = 60;
            gunaDataGridView1.ReadOnly = true;
        }

        private void radiobtnNgay_CheckedChanged(object sender, EventArgs e)
        {
            ClearController();
            label1.Visible = false;
            label6.Visible = false;
            label3.Visible = false;
            gunaTextBox1.Visible = false;
            gunaTextBox2.Visible = false;
            TextBoxt_GhiChu.Visible = false;
        }

        private void radiobtnThang_CheckedChanged(object sender, EventArgs e)
        {
            ClearController();
            label1.Visible = true;
            label6.Visible = true;
            label3.Visible = true;
            gunaTextBox1.Visible = true;
            gunaTextBox2.Visible = true;
            TextBoxt_GhiChu.Visible = true;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            NapDLVaoDGV();
        }
    }
}
