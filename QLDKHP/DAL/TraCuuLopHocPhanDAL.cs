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
    internal class TraCuuLopHocPhanDAL
    {
        DataConnection DataConnection;
        SqlDataAdapter data;
        SqlCommand cmd;

        public TraCuuLopHocPhanDAL()
        {
            DataConnection = new DataConnection();
        }

        public DataTable getThongTinHinhThucTimKiem(int i)
        {

            string sqlString = "";
            switch (i)
            {
                case 0:
                    sqlString = "SELECT NH.TenNH from NganhHoc AS NH";
                    break;
                case 1:
                    sqlString = "Select CTDT.TenCTDT from ChuongTrinhDaoTao AS CTDT";
                    break;
                case 2:
                    sqlString = "SELECT LoaiHP.TenLoaiHP from LoaiHocPhan AS LoaiHP";
                    break;
                case 3:
                    sqlString = "SELECT KH.TenKhoa from Khoa AS KH";
                    break;
                default:
                    sqlString = "";
                    break;
            }

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

        public DataTable getListLopHocPhan(int i, int j)
        {
            string sqlString = "";

            if(j == -1)
            {
                sqlString = "";
            }
            switch (i)
            {
                case 0:
                    sqlString = "Select LHP.MaLHP ,LHP.TenLHP, LoaiHP.TenLoaiHP, HP.SoTinChi, LHP.NgayBD, LHP.NgayKT, LHP.SoluongSV, LHP.SoLuongSVmax from LopHocPhan AS LHP, LoaiHocPhan AS LoaiHP, HocPhan AS HP, MonHoc AS MH, ChuongTrinhDaoTao AS CTDT, NganhHoc AS NH, Khoa AS KH\r\nwhere LHP.MaHP = HP.MaHP and HP.MaLoaiHP = LoaiHP.MaLoaiHP\r\nand HP.MaMH = MH.MaMH and MH.MaCTDT = CTDT.MaCTDT and MH.MaKhoa = KH.MaKhoa and \r\nNH.MaCTDT = CTDT.MaCTDT and NH.MaNH =" + j;
                    break;
                case 1:
                    sqlString = "Select LHP.MaLHP ,LHP.TenLHP, LoaiHP.TenLoaiHP, HP.SoTinChi, LHP.NgayBD, LHP.NgayKT, LHP.SoluongSV, LHP.SoLuongSVmax from LopHocPhan AS LHP, LoaiHocPhan AS LoaiHP, HocPhan AS HP, MonHoc AS MH, ChuongTrinhDaoTao AS CTDT, NganhHoc AS NH, Khoa AS KH\r\nwhere LHP.MaHP = HP.MaHP and HP.MaLoaiHP = LoaiHP.MaLoaiHP\r\nand HP.MaMH = MH.MaMH and MH.MaCTDT = CTDT.MaCTDT and MH.MaKhoa = KH.MaKhoa and \r\nNH.MaCTDT = CTDT.MaCTDT and CTDT.MaCTDT =" + j;
                    break;
                case 2:
                    sqlString = "Select LHP.MaLHP ,LHP.TenLHP, LoaiHP.TenLoaiHP, HP.SoTinChi, LHP.NgayBD, LHP.NgayKT, LHP.SoluongSV, LHP.SoLuongSVmax from LopHocPhan AS LHP, LoaiHocPhan AS LoaiHP, HocPhan AS HP, MonHoc AS MH, ChuongTrinhDaoTao AS CTDT, NganhHoc AS NH, Khoa AS KH\r\nwhere LHP.MaHP = HP.MaHP and HP.MaLoaiHP = LoaiHP.MaLoaiHP\r\nand HP.MaMH = MH.MaMH and MH.MaCTDT = CTDT.MaCTDT and MH.MaKhoa = KH.MaKhoa and \r\nNH.MaCTDT = CTDT.MaCTDT and LoaiHP.MaLoaiHP =" + j;
                    break;
                case 3:
                    sqlString = "Select LHP.MaLHP ,LHP.TenLHP, LoaiHP.TenLoaiHP, HP.SoTinChi, LHP.NgayBD, LHP.NgayKT, LHP.SoluongSV, LHP.SoLuongSVmax from LopHocPhan AS LHP, LoaiHocPhan AS LoaiHP, HocPhan AS HP, MonHoc AS MH, ChuongTrinhDaoTao AS CTDT, NganhHoc AS NH, Khoa AS KH\r\nwhere LHP.MaHP = HP.MaHP and HP.MaLoaiHP = LoaiHP.MaLoaiHP\r\nand HP.MaMH = MH.MaMH and MH.MaCTDT = CTDT.MaCTDT and MH.MaKhoa = KH.MaKhoa and \r\nNH.MaCTDT = CTDT.MaCTDT and KH.MaKhoa =" + j;
                    break;
                default:
                    sqlString = "";
                    break;
            }
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
    }
}
