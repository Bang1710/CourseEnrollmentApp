using QLDKHP.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDKHP.DAL
{
    internal class DangKyMonHocDAL
    {
        DataConnection DataConnection;
        SqlDataAdapter data;
        SqlCommand cmd;
        public DangKyMonHocDAL()
        {
            DataConnection= new DataConnection();
        }

        public DataTable getThongTinGiangVien(string tdn, string ps)
        {
            string sqlString = "Select GV.id_gv, GV.MSGV, GV.HoTen, CV.TenCV, KH.TenKhoa from GiangVien AS GV, Khoa AS KH, ChucVu AS CV, TaiKhoan AS TK\r\nwhere TK.TenDangNhap = N'"+ tdn +"' and TK.MatKhauDN = "+ ps +" and GV.MaKhoa = KH.MaKhoa and GV.MaCV = CV.MaCV and TK.MSGV = GV.id_gv";
            SqlConnection connection = DataConnection.getConnect();
            data = new SqlDataAdapter(sqlString, connection);

            // B4: Mở kết nối
            connection.Open();

            //B5: Đổ dữ liệu SqlAdapter vào datatable
            DataTable dataTable = new DataTable();
            data.Fill(dataTable);

            //B6: Đóng kết nối
            connection.Close();
            return dataTable;
        }

        public DataTable getListMonHoc()
        {
            string SqlString = "select MH.MaMH, MH.TenMH, HP.SoTinChi, KH.TenKhoa from HocPhan AS HP, MonHoc AS MH, Khoa AS KH\r\nwhere MH.MaKhoa = KH.MaKhoa and MH.MaMH = HP.MaMH ";
            SqlConnection connection = DataConnection.getConnect();
            data = new SqlDataAdapter(SqlString, connection);

            // B4: Mở kết nối
            connection.Open();

            //B5: Đổ dữ liệu SqlAdapter vào datatable
            DataTable dataTable = new DataTable();
            data.Fill(dataTable);

            //B6: Đóng kết nối
            connection.Close();
            return dataTable;
        }

        public DataTable getSoLopHienTai(int id)
        {
            string SqlString = "select count(LHP.MaHP) AS N'SLL' from LopHocPhan AS LHP, HocPhan AS HP, MonHoc AS MH\r\nwhere MH.MaMH = " + id + " and MH.MaMH = HP.MaMH and HP.MaHP = LHP.MaHP";
            SqlConnection connection = DataConnection.getConnect();
            data = new SqlDataAdapter(SqlString, connection);

            // B4: Mở kết nối
            connection.Open();

            //B5: Đổ dữ liệu SqlAdapter vào datatable
            DataTable dataTable = new DataTable();
            data.Fill(dataTable);

            //B6: Đóng kết nối
            connection.Close();
            return dataTable;
        }

        public bool InsertDangKyMonHoc(PhieuDangKyMonHoc pdkmh)
        {
            string sqlString = "Insert into PhieuDangKyMonHoc Values (@slht, @sldk, @idgv, @idmh)";
            SqlConnection connection = DataConnection.getConnect();

            try
            {
                cmd = new SqlCommand(sqlString, connection);
                connection.Open();
                cmd.Parameters.Add("@idmh", SqlDbType.Int).Value = pdkmh.mamh;
                cmd.Parameters.Add("@idgv", SqlDbType.Int).Value = pdkmh.msgv;
                cmd.Parameters.Add("@slht", SqlDbType.Int).Value = pdkmh.slht;
                cmd.Parameters.Add("@sldk", SqlDbType.Int).Value = pdkmh.sldk;
                cmd.ExecuteNonQuery();
                connection.Close();

            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public DataTable getPhieDangKyMonHoc(int id)
        {
            string SqlString = "select PDKMH.MaPDKMH,MH.MaMH, MH.TenMH, HP.SoTinChi, KH.TenKhoa, PDKMH.SoLopHienTai, PDKMH.SoLopDangKy from PhieuDangKyMonHoc AS PDKMH, Khoa AS KH, HocPhan AS HP, MonHoc AS MH, GiangVien AS GV\r\nwhere MH.MaMH = HP.MaMH and MH.MaKhoa = KH.MaKhoa and PDKMH.MSGV = GV.id_gv and GV.id_gv = "+ id +" and MH.MaMH = PDKMH.MaMH";
            SqlConnection connection = DataConnection.getConnect();
            data = new SqlDataAdapter(SqlString, connection);

            // B4: Mở kết nối
            connection.Open();

            //B5: Đổ dữ liệu SqlAdapter vào datatable
            DataTable dataTable = new DataTable();
            data.Fill(dataTable);

            //B6: Đóng kết nối
            connection.Close();
            return dataTable;
        }

        public bool deleteLopDangKyHocPhan(PhieuDangKyMonHoc pk)
        {
            string sqlString = "delete PhieuDangKyMonHoc where PhieuDangKyMonHoc.MaMH = @mamh";
            SqlConnection connection = DataConnection.getConnect();

            try
            {
                cmd = new SqlCommand(sqlString, connection);
                connection.Open();
                cmd.Parameters.Add("@mamh", SqlDbType.Int).Value = pk.mamh;
                cmd.ExecuteNonQuery();
                connection.Close();

            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        public DataTable getMaMonHoc()
        {
            string sqlString = "select MH.MaMH from MonHoc AS MH";

            //B2: Tạo một kết nối đến SQL

            SqlConnection connection = DataConnection.getConnect();

            //B3: Khởi tạo đối tượng của lớp SqlDataAdapter
            data = new SqlDataAdapter(sqlString, connection);

            // B4: Mở kết nối
            connection.Open();

            //B5: Đổ dữ liệu SqlAdapter vào datatable
            DataTable dataTable = new DataTable();
            data.Fill(dataTable);

            //B6: Đóng kết nối
            connection.Close();
            return dataTable;
        }

        public DataTable FindMonHoc(string id)
        {
            string sql = "select MH.MaMH, MH.TenMH, HP.SoTinChi, KH.TenKhoa from HocPhan AS HP, MonHoc AS MH, Khoa AS KH\r\nwhere MH.MaKhoa = KH.MaKhoa and MH.MaMH = HP.MaMH and MH.MaMH = " + id;

            SqlConnection connection = DataConnection.getConnect();

            //B3: Khởi tạo đối tượng của lớp SqlDataAdapter
            data = new SqlDataAdapter(sql, connection);

            // B4: Mở kết nối
            connection.Open();

            //B5: Đổ dữ liệu SqlAdapter vào datatable
            DataTable dataTable = new DataTable();
            data.Fill(dataTable);

            //B6: Đóng kết nối
            connection.Close();
            return dataTable;
        }

        public bool UpdatePhieuDangKyMonHoc(PhieuDangKyMonHoc pdkmh)
        {
            string sqlString = "Update PhieuDangKyMonHoc SET MaMH = @idmh, MSGV = @idgv, SoLopHienTai = @slht, SoLopDangKy = @sldk where PhieuDangKyMonHoc.MaPDKMH = @id ";
            SqlConnection connection = DataConnection.getConnect();
            try
            {
                cmd = new SqlCommand(sqlString, connection);
                connection.Open();
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = pdkmh.id_pdkmh;
                cmd.Parameters.Add("@idmh", SqlDbType.Int).Value = pdkmh.mamh;
                cmd.Parameters.Add("@idgv", SqlDbType.Int).Value = pdkmh.msgv;
                cmd.Parameters.Add("@slht", SqlDbType.Int).Value = pdkmh.slht;
                cmd.Parameters.Add("@sldk", SqlDbType.Int).Value = pdkmh.sldk;
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }







    }
}
