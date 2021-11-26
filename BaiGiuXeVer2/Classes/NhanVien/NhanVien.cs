using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiGiuXeVer2.Classes.NhanVien
{
    class NhanVien
    {
        //fields
        MyDB.MyDBNV myDB = new MyDB.MyDBNV();
        private int id;
        private String role;
        //properties
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        //constructor
        public NhanVien()
        {
           
        }
        public NhanVien(String role)
        {
            this.role = role;
        }
        //methods
        public DataTable LayTKB(int msnv)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * from f_Thong_Tin_Lich_LV_NV(@msnv)");
            sqlCommand.Parameters.Add("@msnv", SqlDbType.Int).Value = msnv;
            sqlCommand.Connection = myDB.GetSqlConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            return data;
        }
        public DataTable LayTKB_DS_Ngay(int msnv)
        {
            SqlCommand sqlCommand = new SqlCommand("Select DISTINCT Ngay from f_Thong_Tin_Lich_LV_NV(@msnv)");
            sqlCommand.Parameters.Add("@msnv", SqlDbType.Int).Value = msnv;
            sqlCommand.Connection = myDB.GetSqlConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            return data;
        }
        public DataTable LayDSLamViec(int msnv)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * from f_Thong_Tin_CheckIn_Out_NV(@msnv)");
            sqlCommand.Parameters.Add("@msnv", SqlDbType.Int).Value = msnv;
            sqlCommand.Connection = myDB.GetSqlConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            return data;
        }
        public bool UpdateGioLam(int id)
        {
            int ca = this.CaLam();
            DateTime date = DateTime.Now.Date;
            SqlCommand sqlCommand = new SqlCommand("EXEC [dbo].[update_gio_lam_nv] @id,@ngay,@ca,@checkOut");
            sqlCommand.Parameters.Add("@id", SqlDbType.Char).Value = id;
            sqlCommand.Parameters.Add("@ngay", SqlDbType.Date).Value = date;
            sqlCommand.Parameters.Add("@ca", SqlDbType.Int).Value = ca;
            sqlCommand.Parameters.Add("@checkOut", SqlDbType.DateTime).Value = DateTime.Now;
            sqlCommand.Connection = myDB.GetSqlConnection;
            myDB.OpenConnection();
            if (sqlCommand.ExecuteNonQuery() == 1)
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
        public bool InsertGioLam(int id)
        {
            int ca = this.CaLam();
            if(CheckGioLamCoKhong(id,ca))
            {
                SqlCommand sqlCommand = new SqlCommand("EXEC [dbo].[insert_gio_lam_nv] @id,@ngay,@ca,@checkIn");
                sqlCommand.Parameters.Add("@id", SqlDbType.Char).Value = id;
                sqlCommand.Parameters.Add("@ngay", SqlDbType.Date).Value = DateTime.Now;
                sqlCommand.Parameters.Add("@ca", SqlDbType.Int).Value = ca;
                sqlCommand.Parameters.Add("@checkIn", SqlDbType.DateTime).Value = DateTime.Now ;
                sqlCommand.Connection = myDB.GetSqlConnection;
                myDB.OpenConnection();
                if (sqlCommand.ExecuteNonQuery() == 1)
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
            return false;
        }

        public bool CheckGioLamCoKhong(int id, int ca)
        {
            if (ca == -1)
                return false;
            else
            {
                DateTime date = new DateTime();
                date = DateTime.Now.Date;
                SqlCommand sqlCommand = new SqlCommand("Select * from f_Thong_Tin_Ca_Lam (@maNV,@ca,@date)");
                sqlCommand.Parameters.Add("@maNV", SqlDbType.Int).Value = id;
                sqlCommand.Parameters.Add("@ca", SqlDbType.Int).Value = ca;
                sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
                sqlCommand.Connection = myDB.GetSqlConnection;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable data = new DataTable();
                sqlDataAdapter.Fill(data);
                if (data.Rows.Count == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public int CaLam()
        {
            int ca = -1;
            String time = DateTime.Now.TimeOfDay.ToString();
            SqlCommand sqlCommand = new SqlCommand("Select * from f_Ca_Lam_Theo_Gio(@gioLam)");
            sqlCommand.Parameters.Add("@gioLam", SqlDbType.Time).Value = time;
            sqlCommand.Connection = myDB.GetSqlConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            ca = (int)data.Rows[0].ItemArray[0];
            return ca;
        }
        public DataTable getNhanVien(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * From [dbo].[f_Thong_Tin_NV](@id)", myDB.GetSqlConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool updateNhanVien(int id, string hoten, DateTime ngaysinh, string gioitinh, string sodt, string diachi, MemoryStream anh, int maQL)
        {
            SqlCommand command = new SqlCommand("EXEC [dbo].[update_thong_tin_nhan_vien] @id,@hoTen,@gioiTinh,@sodt,@diachi,@maQL,@anh,@ngaysinh", myDB.GetSqlConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@hoTen", SqlDbType.NChar).Value = hoten;
            command.Parameters.Add("@gioiTinh", SqlDbType.NChar).Value = gioitinh;
            command.Parameters.Add("@sodt", SqlDbType.NChar).Value = sodt;
            command.Parameters.Add("@diachi", SqlDbType.Text).Value = diachi;
            command.Parameters.Add("@anh", SqlDbType.Image).Value = anh.ToArray();
            command.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = ngaysinh;
            command.Parameters.Add("@maQL", SqlDbType.Int).Value = maQL;
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
        public bool changePass(String oldPass, String newPass, int maNV)
        {
            myDB.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * from [dbo].[f_Lay_MK_NV] (@maNV)", myDB.GetSqlConnection);
            command.Parameters.Add("@maNV", SqlDbType.Int).Value = maNV;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            String passTemp = (String)table.Rows[0].ItemArray[0];
            if (oldPass.Trim() == passTemp.Trim())
            {
                command = new SqlCommand("EXEC [dbo].[update_pass] @maNV,@newPass", myDB.GetSqlConnection);
                command.Parameters.Add("@maNV", SqlDbType.Int).Value = maNV;
                command.Parameters.Add("@newPass", SqlDbType.Char).Value = newPass;
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
            return false;
        }
        public String LayTenQL(int maQL)
        {
            SqlCommand command = new SqlCommand("SELECT * From [dbo].[f_Thong_Tin_NV](" + maQL + ")", myDB.GetSqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            String tenQL = table.Rows[0].ItemArray[1].ToString();
            return tenQL;
        }
    }
}
