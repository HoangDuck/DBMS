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
    public partial class shiftInformationUC : UserControl
    {
        Classes.NhanVien.NhanVien nv = new Classes.NhanVien.NhanVien();
        public shiftInformationUC()
        {
            InitializeComponent();
        }

        private void shiftInformationUC_Load(object sender, EventArgs e)
        {
            NapDLVaoDGV();
        }

        public void NapDLVaoDGV()
        {
            DataTable dataTable = nv.LayDSLamViec(1);
            dataGridViewCalam.DataSource = dataTable;
            dataGridViewCalam.ColumnHeadersHeight = 60;
            dataGridViewCalam.Columns["ID"].HeaderText = "Mã số nhân viên";
            dataGridViewCalam.Columns["Ngay"].HeaderText = "Ngày làm";
            dataGridViewCalam.Columns["Check_In"].HeaderText = "Giờ check in";
            dataGridViewCalam.Columns["Check_Out"].HeaderText = "Giờ check out";
            dataGridViewCalam.Columns["Ca"].HeaderText = "Ca làm";
            dataGridViewCalam.ReadOnly = true;
        }

        private void ButtonIn_Click(object sender, EventArgs e)
        {
            if (TextBoxin.Text.ToString().Trim() == ""&&TextBoxout.Text.ToString().Trim()=="")
            {
                DateTime dateTime = new DateTime();
                dateTime = DateTime.Now;
                
                if (!nv.InsertGioLam(1))
                {
                    MessageBox.Show("Check in không thành công", "Check in", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    TextBoxin.Text = dateTime.ToString();
                }
            }
            else
            {
                MessageBox.Show("Không thể check in", "Check in", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            shiftInformationUC_Load(null, null);
        }

        private void ButtonOut_Click(object sender, EventArgs e)
        {
            if (TextBoxout.Text.ToString().Trim() == ""&&TextBoxout.Text.ToString().Trim()!="")
            {
                DateTime dateTime = new DateTime();
                dateTime = DateTime.Now;
                TextBoxout.Text = dateTime.ToString();
                if (!nv.UpdateGioLam(1))
                {
                    MessageBox.Show("Check out không thành công", "Check out", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không thể check out", "Check out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            shiftInformationUC_Load(null, null);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            TextBoxin.Text = "";
            TextBoxout.Text = "";
            shiftInformationUC_Load(null, null);
        }
    }
}
