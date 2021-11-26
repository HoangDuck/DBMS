using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiGiuXeVer2.Forms.Manager.ManagerUC
{
    public partial class showInfoStaffUC : UserControl
    {
        public showInfoStaffUC()
        {
            InitializeComponent();
        }

        private void cboVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboVaiTro.Text == "Admin")
            {
                cboQuanLy.Enabled = false;
            }
            else
            {
                cboQuanLy.Enabled = true;
            }
        }
    }
}
