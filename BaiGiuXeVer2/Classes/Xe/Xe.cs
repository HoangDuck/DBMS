using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
namespace BaiGiuXeVer2.Classes.Xe
{
    class Xe
    {
        //fields
        private String bienSo;
        private DateTime checkIn;
        private DateTime checkOut;
        private int tienPhi;
        private int tienPhat;
        private MemoryStream picture;
        MyDB.MyDBNV myDB = new MyDB.MyDBNV();
        //properties
        public String BienSo
        {
            get { return this.bienSo; }
            set { this.bienSo = value; }
        }
        public DateTime CheckIn
        {
            get { return this.checkIn; }
            set { this.checkIn = value; }
        }
        public DateTime CheckOut
        {
            get { return this.checkOut; }
            set { this.checkOut = value; }
        }
        public int TienPhi
        {
            get { return this.tienPhi; }
            set { this.tienPhi = value; }
        }
        public int TienPhat
        {
            get { return this.tienPhat; }
            set { this.tienPhat = value; }
        }
        public MemoryStream Picture
        {
            get { return this.picture; }
            set { this.picture = value; }
        }
        //constructor
        public Xe()
        {
            this.picture = new MemoryStream();
            this.checkIn = new DateTime();
            this.checkOut = new DateTime();
        }
        //methods
        public bool KiemTraXeCoTheGuiThangKhong(Xe xe)
        {
            KhachHang.KhachHang kh = new KhachHang.KhachHang();
            if (kh.KiemTraCoDkThangKhong(xe)&& kh.KiemTraGiayThangConHanKhong(xe))
            {
                return KiemTraXeCoTrongBaiTheoThangKhong(xe);
            }
            return false;
        }
        public bool KiemTraXeCoTheGuiNgayKhong(Xe xe)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * from f_Thong_Tin_Xe_Ve_Thang(@bienXe)");
            sqlCommand.Parameters.Add("@bienXe", SqlDbType.Char).Value = xe.BienSo;
            sqlCommand.Connection = myDB.GetSqlConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            if (data.Rows.Count == 0)
                return true;
            return false;
        }
        public bool KiemTraXeCoTrongBaiKhong(Xe xe)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * from f_Thong_Tin_Xe_Ve_Ngay(@bienXe)");
            sqlCommand.Parameters.Add("@bienXe", SqlDbType.Char).Value = xe.BienSo;
            sqlCommand.Connection = myDB.GetSqlConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            if (data.Rows.Count == 0)
                return true;
            return false;
        }
        public bool KiemTraXeCoTrongBaiTheoThangKhong(Xe xe)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * from f_Thong_Tin_Xe_Ve_Thang(@bienXe)");
            sqlCommand.Parameters.Add("@bienXe", SqlDbType.Char).Value = xe.BienSo;
            sqlCommand.Connection = myDB.GetSqlConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            if (data.Rows.Count == 0)
                return true;
            return false;
        }
        public bool GuiXeTheoNgay(Xe xe)
        {
            if (KiemTraXeCoTheGuiNgayKhong(xe))
            {
                SqlCommand sqlCommand = new SqlCommand("EXEC [dbo].[insert_khach_hang_ngay] @bienXe,@checkIn,@anh");
                sqlCommand.Parameters.Add("@bienXe", SqlDbType.Char).Value = xe.BienSo;
                sqlCommand.Parameters.Add("@checkIn", SqlDbType.DateTime).Value = xe.CheckIn;
                sqlCommand.Parameters.Add("@anh", SqlDbType.Image).Value = xe.Picture.ToArray();
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
        public bool GuiXeTheoThang(Xe xe)
        {
            if (KiemTraXeCoTheGuiThangKhong(xe))
            {
                SqlCommand sqlCommand = new SqlCommand("EXEC [dbo].[insert_check_in_out_thang] @bienXe,@checkIn,@anh");
                sqlCommand.Parameters.Add("@bienXe", SqlDbType.Char).Value = xe.BienSo;
                sqlCommand.Parameters.Add("@checkIn", SqlDbType.DateTime).Value = xe.CheckIn;
                sqlCommand.Parameters.Add("@anh", SqlDbType.Image).Value = xe.Picture.ToArray();
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
        public void GuiXe(Xe xe)
        {
            if (GuiXeTheoThang(xe))
            {
                return;
            }
            else if (GuiXeTheoNgay(xe))
            {
                return;
            }
        }
        public DataTable LayDSBienXeTheoNgay()
        {
            SqlCommand sqlCommand = new SqlCommand("Select BienXe from Xe_Gui_Theo_Ngay");
            sqlCommand.Connection = myDB.GetSqlConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            return data;
        }
        public DataTable LayDSBienXeTheoThang()
        {
            SqlCommand sqlCommand = new SqlCommand("Select BienXe from Xe_Gui_Theo_Thang");
            sqlCommand.Connection = myDB.GetSqlConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            return data;
        }
        public DataTable LayDSXeTheoNgay(String bienXe)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * from f_Thong_Tin_Xe_Ve_Ngay(@bienXe)");
            sqlCommand.Parameters.Add("@bienXe", SqlDbType.NChar).Value = bienXe;
            sqlCommand.Connection = myDB.GetSqlConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            return data;
        }
        public DataTable LayDSXeTheoThang(String bienXe)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * from f_Thong_Tin_Xe_Ve_Thang(@bienXe)");
            sqlCommand.Parameters.Add("@bienXe", SqlDbType.NChar).Value = bienXe;
            sqlCommand.Connection = myDB.GetSqlConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            return data;
        }
        public void LayThongTinXeTuMotTrongHaiBai(String bienXe)
        {
            DataTable data_Xe_Theo_Ngay = LayDSXeTheoNgay(bienXe);
            if (data_Xe_Theo_Ngay.Rows.Count == 1)
            {
                this.bienSo = bienXe;
                this.checkIn = Convert.ToDateTime(data_Xe_Theo_Ngay.Rows[0].ItemArray[1]);
                try
                {
                    byte[] b = (byte[])data_Xe_Theo_Ngay.Rows[0].ItemArray[3];
                    this.picture = new MemoryStream(b);
                }
                catch
                {
                    //picture = Properties.Resources.default_DDLK_avatar;
                }
                return;
            }
            DataTable data_Xe_Theo_Thang = LayDSXeTheoThang(bienXe);
            if (data_Xe_Theo_Thang.Rows.Count == 1)
            {
                this.bienSo = bienXe;
                this.checkIn = Convert.ToDateTime(data_Xe_Theo_Thang.Rows[0].ItemArray[1]);
                try
                {
                    byte[] b = (byte[])data_Xe_Theo_Thang.Rows[0].ItemArray[3];
                    this.picture = new MemoryStream(b);
                }
                catch
                {

                }
            }
        }
        public void CapNhatCheckOutXeHoiTrongBai(Xe xe)
        {
            SqlCommand sqlCommand;
            if (!KiemTraXeCoTrongBaiKhong(xe))//kiem tra theo ve ngay khong co thi xe se trong trong bai giu xe thang
            {
                xe.TienPhi = 10000;
                sqlCommand = new SqlCommand("EXEC [dbo].[update_khach_hang_ngay] @bienXe,@checkIn,@checkOut,@phi");
                sqlCommand.Parameters.Add("@bienXe", SqlDbType.Char).Value = xe.BienSo;
                sqlCommand.Parameters.Add("@checkIn", SqlDbType.DateTime).Value = xe.CheckIn;
                sqlCommand.Parameters.Add("@checkOut", SqlDbType.DateTime).Value = xe.CheckOut;
                sqlCommand.Parameters.Add("@phi", SqlDbType.Int).Value = xe.TienPhi;
                sqlCommand.Connection = myDB.GetSqlConnection;
                myDB.OpenConnection();
                if (sqlCommand.ExecuteNonQuery() == 1)
                {
                    myDB.CloseConnection();
                }
                else
                {
                    myDB.CloseConnection();
                }
                sqlCommand = new SqlCommand("Select * from f_TraThongTinXeTheoNgay(@bienXe,@checkIn)");
                sqlCommand.Parameters.Add("@bienXe", SqlDbType.NChar).Value = xe.BienSo;
                sqlCommand.Parameters.Add("@checkIn", SqlDbType.DateTime).Value = xe.CheckIn;
                sqlCommand.Connection = myDB.GetSqlConnection;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable data = new DataTable();
                sqlDataAdapter.Fill(data);
                xe.TienPhat = (int)data.Rows[0].ItemArray[5];
            }
            else
            {
                xe.TienPhi = 100000;
                sqlCommand = new SqlCommand("EXEC [dbo].[update_check_in_out_thang] @bienXe,@checkIn,@checkOut");
                sqlCommand.Parameters.Add("@bienXe", SqlDbType.Char).Value = xe.BienSo;
                sqlCommand.Parameters.Add("@checkIn", SqlDbType.DateTime).Value = xe.CheckIn;
                sqlCommand.Parameters.Add("@checkOut", SqlDbType.DateTime).Value = xe.CheckOut;
                sqlCommand.Connection = myDB.GetSqlConnection;
                myDB.OpenConnection();
                if (sqlCommand.ExecuteNonQuery() == 1)
                {
                    myDB.CloseConnection();
                }
                else
                {
                    myDB.CloseConnection();
                }
                sqlCommand = new SqlCommand("Select * from f_Thong_Tin_DKVeThang_Xe(@bienXe)");
                sqlCommand.Parameters.Add("@bienXe", SqlDbType.NChar).Value = xe.BienSo;
                sqlCommand.Connection = myDB.GetSqlConnection;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable data = new DataTable();
                sqlDataAdapter.Fill(data);
                int n = data.Rows.Count;
                try
                {
                    xe.TienPhat = (int)data.Rows[n - 1].ItemArray[4];
                }
                catch
                {
                    xe.TienPhat = 0;
                }
                
            }
        }
        public DataTable LayXeTrongBaiTheoNgay()
        {
            SqlCommand sqlCommand = new SqlCommand("Select BienXe,Check_in,Check_out from Xe_Gui_Theo_Ngay");
            sqlCommand.Connection = myDB.GetSqlConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            return data;
        }
        public DataTable LayXeTrongBaiTheoThang()
        {
            SqlCommand sqlCommand = new SqlCommand("Select BienXe,Check_in,Check_out from Xe_Gui_Theo_Thang");
            sqlCommand.Connection = myDB.GetSqlConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            return data;
        }
    }
}

