using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiGiuXeVer2.MyDB
{
    class MyDBNV
    {
        //field
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; 
        Initial Catalog = BaiXeOto; 
        User ID = DBStaff; Password = 123456789;
        Integrated Security = True; Connect Timeout = 120; 
        Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; 
        MultiSubnetFailover = False");
        //property
        public SqlConnection GetSqlConnection {
            get { return this.sqlConnection; }
        }
        //methods
        public void OpenConnection()
        {
            sqlConnection.Open();
        }
        public void CloseConnection()
        {
            sqlConnection.Close();
        }

    }
}
