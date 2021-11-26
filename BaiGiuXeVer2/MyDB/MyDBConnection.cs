using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiGiuXeVer2.MyDB
{
    class MyDBConnection
    {
        private string role;
        public MyDBConnection(string role)
        {
            this.role = role;
        }
        public MyDBConnection()
        {

        }
        private string nvURL = @"Data Source=DESKTOP-5O12LN5\TAIPHAN;Initial Catalog=GiuXe;User ID=NhanVien;Password=123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private string qlURL = @"Data Source=DESKTOP-5O12LN5\TAIPHAN;Initial Catalog=GiuXe;User ID=QuanLi;Password=123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private string adURL = @"Data Source=DESKTOP-5O12LN5\TAIPHAN;Initial Catalog=GiuXe;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public string getURL()
        {
            string url;
            if(this.role == "QuanLi")
            {
                url = qlURL;
            }
            else
            {
                if(this.role == "Admin")
                {
                    url = adURL;
                }
                else
                {
                    url = nvURL;
                }
            }
            return url;
        }
        SqlConnection connection;
        public SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection(getURL());
            connection = con;
            return connection;
        }

        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void ClosedConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
