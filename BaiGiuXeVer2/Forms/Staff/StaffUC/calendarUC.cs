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

namespace BaiGiuXeVer2.Forms.Staff.StaffUC
{
    public partial class calendarUC : UserControl
    {
        Classes.NhanVien.NhanVien nv = new Classes.NhanVien.NhanVien();
        DataTable dataTable = new DataTable();
        private int id;
        private String role;
        public calendarUC(int id,String role)
        {
            this.id = id;
            this.role = role;
            InitializeComponent();
            XuLyDataGridView();
            NapDLVaoComboBox();
        }
        public calendarUC()
        {
            InitializeComponent();
            XuLyDataGridView();
            NapDLVaoComboBox();
        }

        private void calendarUC_Load(object sender, EventArgs e)
        {

        }
        private void NapDLVaoComboBox()
        {
            DataTable dataTable = nv.LayTKB_DS_Ngay(this.id);
            ComboBoxLich.DataSource = dataTable;
            ComboBoxLich.DisplayMember = "Ngay";
            ComboBoxLich.ValueMember = "Ngay";
            ComboBoxLich.SelectedItem = null;
        }
        public void XuLyDataGridView()
        {
            dataTable = nv.LayTKB(this.id);
            int n = dataTable.Rows.Count;
            int index = -1;
            for (int i = 0; i < n; i++)
            {
                if (CheckDataTableTKB(dataTable,i,index))
                {
                    index++;
                    DGV_LichLamViec.Rows.Add();
                    DateTime date = (DateTime)dataTable.Rows[i].ItemArray[2];
                    DGV_LichLamViec.Rows[index].Cells["Column1"].Value = date.ToString();
                    String columnIndex = CheckIndex(dataTable, i);
                    DGV_LichLamViec.Rows[index].Cells[columnIndex].Value = "x";

                }
                else
                {
                    DateTime date = (DateTime)dataTable.Rows[i].ItemArray[2];
                    String columnIndex = CheckIndex(dataTable,i);
                    DGV_LichLamViec.Rows[index].Cells[columnIndex].Value = "x";
                }
            }
        }

        private string CheckIndex(DataTable dataTable, int i)
        {
            String columnindex = dataTable.Rows[i].ItemArray[1].ToString();
            if (columnindex == "1")
            {
                return "Column2";
            }
            if (columnindex == "2")
            {
                return "Column3";
            }
            if (columnindex == "3")
            {
                return "Column4";
            }
            return "";
        }

        public bool CheckDataTableTKB(DataTable dataTable, int i, int index)
        {
            if(index==-1)
                return true;
            else
            {
                if (dataTable.Rows[i].ItemArray[2].ToString() != dataTable.Rows[i - 1].ItemArray[2].ToString())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
