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
    internal class DangKyHocPhanDAL
    {
        DataConnection DataConnection;
        SqlDataAdapter data;
        SqlCommand cmd;

        public DangKyHocPhanDAL()
        {
            DataConnection = new DataConnection();
        }

        public DataTable getThongTinSinhVien(string tdn, string ps, string ltk)
        {
            string SqlString = "SELECT SV.id_sv, SV.MSSV, SV.HoTen, LSV.TenLSV from SinhVien AS SV, TaiKhoan AS TK, LopSinhVien AS LSV \r\n Where TK.TenDangNhap = N'" + tdn + "' and TK.MatKhauDN = N'" + ps + "' and TK.LoaiTK = N'Sinh Viên' and TK.MSSV = SV.id_sv and SV.MaLSV = LSV.MaLSV";
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

        public DataTable getThongTinHocPhanBatBuoc()
        {
            string SqlString = "SELECT LHP.id_lhp AS ID, LHP.MaLHP, LHP.TenLHP , LHP.NgayBD, LHP.NgayKT, LHP.SoluongSV, LHP.SoLuongSVmax\r\nFrom LopHocPhan AS LHP, HocPhan AS HP, LoaiHocPhan AS LoaiHP\r\nWhere LHP.MaHP = HP.MaHP and HP.MaLoaiHP = LoaiHP.MaLoaiHP and LoaiHP.MaLoaiHP = 1";
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

        public DataTable getThongTinHocPhanTuChon()
        {
            string SqlString = "SELECT LHP.id_lhp AS ID, LHP.MaLHP, LHP.TenLHP, LHP.NgayBD, LHP.NgayKT, LHP.SoluongSV, LHP.SoLuongSVmax  \r\nFrom LopHocPhan AS LHP, HocPhan AS HP, LoaiHocPhan AS LoaiHP\r\nWhere LHP.MaHP = HP.MaHP and HP.MaLoaiHP = LoaiHP.MaLoaiHP and LoaiHP.MaLoaiHP = 2";
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

        public DataTable getMaLopHocPhan()
        {
            string sqlString = "Select LHP.MaLHP From LopHocPhan AS LHP";

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

        public DataTable FindLopHocPhan(string malhp)
        {
            string sql = "select LHP.id_lhp AS ID, LHP.MaLHP, LHP.TenLHP, LHP.NgayBD, LHP.NgayKT, LHP.SoluongSV, LHP.SoLuongSVmax from LopHocPhan AS LHP where LHP.MaLHP = " + malhp ;

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

        public bool InsertDangKyHocPhan(PhieuDangKyHocPhan pdkhp)
        {
            string sqlString = "Insert into PhieuDangKyHocPhan Values (@idlhp, @idsv)";
            SqlConnection connection = DataConnection.getConnect();

            try
            {
                cmd = new SqlCommand(sqlString, connection);
                connection.Open();
                cmd.Parameters.Add("@idlhp", SqlDbType.Int).Value = pdkhp.id_lhp;
                cmd.Parameters.Add("@idsv", SqlDbType.Int).Value = pdkhp.id_sv;
                cmd.ExecuteNonQuery();
                connection.Close();

            }
            catch (Exception)
            {
                return false;
            }
           
            return true;
        }

        public DataTable getPhieuDangKyHocPhan(string id_sv, int i)
        {
            string sqlString = "Select LHP.id_lhp AS ID, LHP.MaLHP, LHP.TenLHP, HP.SoTinChi, LoaiHP.TenLoaiHP, LHP.NgayBD, LHP.NgayKT, (LHP.SoLuongSV + " + i +") AS SoLuongSV, LHP.SoLuongSVmax from LopHocPhan AS LHP, PhieuDangKyHocPhan as PDKHP, SinhVien AS SV, HocPhan AS HP, LoaiHocPhan AS LoaiHP\r\nwhere PDKHP.MaLHP = LHP.id_lhp and PDKHP.MSSV = SV.id_sv and LHP.MaHP = HP.MaHP and HP.MaLoaiHP = LoaiHP.MaLoaiHP and PDKHP.MSSV = " + id_sv;
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

        public bool deleteLopDangKyHocPhan(PhieuDangKyHocPhan pk)
        {
            string sqlString = "delete PhieuDangKyHocPhan where PhieuDangKyHocPhan.MaLHP = @id_lhp";
            SqlConnection connection = DataConnection.getConnect();

            try
            {
                cmd = new SqlCommand(sqlString, connection);
                connection.Open();
                cmd.Parameters.Add("@id_lhp", SqlDbType.Int).Value = pk.id_lhp;
                cmd.ExecuteNonQuery();
                connection.Close();

            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        //public bool UpdateSoSVHienTai(LopHocPhan lhp, int i)
        //{
        //    string sqlString = "Update LopHocPhan set SoLuongSV = SoLuongSV + "+ i +" where LopHocPhan.id_lhp = @id_lhp";
        //    SqlConnection connection = DataConnection.getConnect();
        //    try
        //    {
        //        cmd = new SqlCommand(sqlString, connection);
        //        connection.Open();
        //        cmd.Parameters.Add("@id_lhp", SqlDbType.Int).Value = lhp.id_lhp;
        //        cmd.ExecuteNonQuery();
        //        connection.Close();
        //    }
        //    catch (Exception)
        //    {

        //        return false;
        //    }
        //    return true;

        //}
    }
}
