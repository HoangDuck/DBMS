using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
namespace BaiGiuXeVer2.Classes.KhachHang
{
    class KhachHang
    {
        //fields
        private String bienSo;
        private String tenKH;
        private String sdt;
        private MemoryStream picture;
        private DateTime ngayDK;
        private DateTime ngayHetHan;
        MyDB.MyDBNV myDB = new MyDB.MyDBNV();
        //properties
        public String BienSo
        {
            get { return this.bienSo; }
            set { this.bienSo = value; }
        }
        public String TenKH
        {
            get { return this.tenKH; }
            set { this.tenKH = value; }
        }
        public String Sdt
        {
            get { return this.sdt; }
            set { this.sdt = value; }
        }
        public MemoryStream Picture
        {
            get { return this.picture; }
            set { this.picture = value; }
        }
        public DateTime NgayDK
        {
            get { return this.ngayDK; }
            set { this.ngayDK = value; }
        }
        public DateTime NgayHetHan
        {
            get { return this.ngayHetHan; }
            set { this.ngayHetHan = value; }
        }
        //constructor
        public KhachHang(){
            
        }
        //methods
        public bool KiemTraCoDkThangKhong(Xe.Xe xe)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * from f_Thong_Tin_KH_DKVeThang(@bienXe)");
            sqlCommand.Parameters.Add("@bienXe", SqlDbType.Char).Value = xe.BienSo;
            sqlCommand.Connection = myDB.GetSqlConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            if (data.Rows.Count == 0)
                return false;
            return true;
        }

        public bool themKhachHang(string bienso, string ten, string diachi, string sdt, MemoryStream anh)
        {
            SqlCommand command = new SqlCommand("Exec [dbo].[insert_Khach_hang_thang] @bienso,@ten,@diachi,@sdt,@anh", myDB.GetSqlConnection);
            command.Parameters.Add("@bienso", SqlDbType.NChar).Value = bienso;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
            command.Parameters.Add("@diachi", SqlDbType.Text).Value = diachi;
            command.Parameters.Add("@sdt", SqlDbType.NChar).Value = sdt;
            command.Parameters.Add("@anh", SqlDbType.Image).Value = anh.ToArray();
            myDB.OpenConnection();
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    myDB.CloseConnection();
                    return true;
                }
                else
                {
                    myDB.CloseConnection();
                    return false;
                }
            }
            catch
            {
                myDB.CloseConnection();
                return false;
            }
            
        }

        public bool dangkyThang(string bienso, DateTime ngaydk, DateTime ngayhh, int phi)
        {
            SqlCommand command = new SqlCommand("Exec [dbo].[insert_Dang_ky_thang] @bienso,@ngaydk,@ngayhh,@phi", myDB.GetSqlConnection);
            command.Parameters.Add("@bienso", SqlDbType.NChar).Value = bienso;
            command.Parameters.Add("@ngaydk", SqlDbType.DateTime).Value = ngaydk;
            command.Parameters.Add("@ngayhh", SqlDbType.DateTime).Value = ngayhh;
            command.Parameters.Add("@phi", SqlDbType.Int).Value = phi;
            myDB.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                myDB.CloseConnection();
                return true;
            }
            else
            {
                myDB.CloseConnection();
                return false;
            }
        }
        public DataTable ThongTinKH(String bienXe)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * from f_Thong_Tin_KH_DKVeThang(@bienXe)");
            sqlCommand.Parameters.Add("@bienXe", SqlDbType.NChar).Value = bienXe;
            sqlCommand.Connection = myDB.GetSqlConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            return data;
        }
        public bool KiemTraGiayThangConHanKhong(Xe.Xe xe)
        {
            DateTime date = DateTime.Now;
            SqlCommand sqlCommand = new SqlCommand("Select * from f_Thong_Tin_DKVeThang_Xe_Con_Han(@bienXe,@ngayKT)");
            sqlCommand.Parameters.Add("@bienXe", SqlDbType.Char).Value = xe.BienSo;
            sqlCommand.Parameters.Add("@ngayKT", SqlDbType.DateTime).Value = date;
            sqlCommand.Connection = myDB.GetSqlConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            if (data.Rows.Count == 0)
                return false;
            return true;
        }

    }
}
