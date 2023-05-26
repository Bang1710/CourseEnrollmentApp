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
    internal class QuanLYLopHocPhanPhuTrachDAL
    {
        DataConnection DataConnection;
        SqlDataAdapter data;
        SqlCommand cmd;
        public QuanLYLopHocPhanPhuTrachDAL()
        {
            DataConnection = new DataConnection();
        }

        public DataTable getThongTinGiangVien(string tdn, string ps)
        {
            string sqlString = "Select GV.id_gv, GV.MSGV, GV.HoTen, CV.TenCV, KH.TenKhoa from GiangVien AS GV, Khoa AS KH, ChucVu AS CV, TaiKhoan AS TK\r\nwhere TK.TenDangNhap = N'" + tdn + "' and TK.MatKhauDN = " + ps + " and GV.MaKhoa = KH.MaKhoa and GV.MaCV = CV.MaCV and TK.MSGV = GV.id_gv";
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

        public DataTable getLopHocPhanPhuTrach(string id)
        {
            string sqlString = "SELECT LHP.id_lhp AS ID, LHP.MaLHP, LHP.TenLHP , LoaiHP.TenLoaiHP, HP.SoTinChi, LHP.NgayBD, LHP.NgayKT, LHP.SoluongSV, LHP.SoLuongSVmax\r\n  From LopHocPhan AS LHP, HocPhan AS HP, LoaiHocPhan AS LoaiHP, PhanCongGiangDay AS PCGD, GiangVien AS GV\r\n  Where LHP.MaHP = HP.MaHP and HP.MaLoaiHP = LoaiHP.MaLoaiHP and PCGD.MaLHP = LHP.id_lhp and PCGD.MSGV = GV.id_gv and GV.id_gv = " + id;
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
            string sql = "  SELECT LHP.id_lhp AS ID, LHP.MaLHP, LHP.TenLHP , LoaiHP.TenLoaiHP, HP.SoTinChi, LHP.NgayBD, LHP.NgayKT, LHP.SoluongSV, LHP.SoLuongSVmax\r\n  From LopHocPhan AS LHP, HocPhan AS HP, LoaiHocPhan AS LoaiHP, PhanCongGiangDay AS PCGD, GiangVien AS GV\r\n  Where LHP.MaHP = HP.MaHP and HP.MaLoaiHP = LoaiHP.MaLoaiHP and PCGD.MaLHP = LHP.id_lhp and PCGD.MSGV = GV.id_gv \r\n  and LHP.MaLHP =" + malhp;

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

        public DataTable getDanhSachSinhVien(string id)
        {
            //string sql = "  SELECT LHP.id_lhp AS ID, LHP.MaLHP, LHP.TenLHP , LoaiHP.TenLoaiHP, HP.SoTinChi, LHP.NgayBD, LHP.NgayKT, LHP.SoluongSV, LHP.SoLuongSVmax\r\n  From LopHocPhan AS LHP, HocPhan AS HP, LoaiHocPhan AS LoaiHP, PhanCongGiangDay AS PCGD, GiangVien AS GV\r\n  Where LHP.MaHP = HP.MaHP and HP.MaLoaiHP = LoaiHP.MaLoaiHP and PCGD.MaLHP = LHP.id_lhp and PCGD.MSGV = GV.id_gv \r\n  and LHP.MaLHP =" + malhp;

            string sql = "  select SV.id_sv, SV.MSSV, SV.HoTen, SV.GioiTinh, SV.NgaySinh \r\n  from SinhVien AS SV, LopHocPhan AS LHP, PhieuDangKyHocPhan AS PDKHP\r\n  where PDKHP.MaLHP = LHP.id_lhp and PDKHP.MSSV = SV.id_sv and LHP.id_lhp =" + id;
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




    }
}
