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
    internal class QuanLySinhVienDAL
    {
        DataConnection DataConnection;
        SqlDataAdapter data;
        SqlCommand cmd;

        public QuanLySinhVienDAL()
        {
            DataConnection = new DataConnection();
        }

        public DataTable getMSSV()
        {
            string sqlString = "Select SV.MSSV from SinhVien AS SV";
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

        public DataTable getLSV()
        {
            string sqlString = "  select TenLSV from LopSinhVien AS LSV";
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

        public DataTable getNH()
        {
            string sqlString = "  select TenNH from NganhHoc";
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

        public DataTable getListSinhVien()
        {
            string sqlString = "Select SV.id_sv, SV.MSSV, SV.HoTen, SV.GioiTinh, SV.NgaySinh, SV.DanToc, SV.TonGiao, SV.SoDienThoai, SV.EmailT, SV.CCCD, NH.TenNH, LSV.TenLSV\r\nfrom SinhVien AS SV, NganhHoc AS NH, LopSinhVien AS LSV\r\nwhere SV.MaNH = NH.MaNH and SV.MaLSV = LSV.MaLSV";
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

        public DataTable FindSinhVien(string id)
        {
            string sql = "Select SV.id_sv, SV.MSSV, SV.HoTen, SV.GioiTinh, SV.NgaySinh, SV.DanToc, SV.TonGiao, SV.SoDienThoai, SV.EmailT, SV.CCCD, NH.TenNH, LSV.TenLSV\r\nfrom SinhVien AS SV, NganhHoc AS NH, LopSinhVien AS LSV\r\nwhere SV.MaNH = NH.MaNH and SV.MaLSV = LSV.MaLSV and SV.MSSV =" + id;
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

        public bool UpdateSinhVien(SinhVien sv)
        {
            string sqlString = "Update SinhVien set MSSV = @mssv,HoTen = @tensv, GioiTinh = @sex,NgaySinh = @ngaysinh,DanToc = @dantoc,TonGiao = @tongiao,SoDienThoai = @sdt,EmailT = @email,CCCD = @cccd, MaNH = @manh, MaLSV = @malsv where MSSV = @id";
            SqlConnection connection = DataConnection.getConnect();

            try
            {
                cmd = new SqlCommand(sqlString, connection);
                connection.Open();
                cmd.Parameters.Add("@mssv", SqlDbType.Int).Value = sv.mssv;
                cmd.Parameters.Add("@tensv", SqlDbType.NVarChar).Value = sv.tensv;
                cmd.Parameters.Add("@sex", SqlDbType.NVarChar).Value = sv.sex;
                cmd.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = sv.ngaysinh;
                cmd.Parameters.Add("@dantoc", SqlDbType.NVarChar).Value = sv.dantoc;
                cmd.Parameters.Add("@tongiao", SqlDbType.NVarChar).Value = sv.tongiao;
                cmd.Parameters.Add("@sdt", SqlDbType.Char).Value = sv.sdt;
                cmd.Parameters.Add("@cccd", SqlDbType.Char).Value = sv.cccd;
                cmd.Parameters.Add("@email", SqlDbType.Char).Value = sv.email;
                cmd.Parameters.Add("@manh", SqlDbType.Int).Value = sv.manh;
                cmd.Parameters.Add("@malsv", SqlDbType.Int).Value = sv.malsv;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = sv.mssv;
                cmd.ExecuteNonQuery();
                connection.Close();

            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public bool deleteSinhVien(SinhVien sv)
        {
            string sqlString = "delete SinhVien where MSSV = @id ";
            SqlConnection connection = DataConnection.getConnect();
            try
            {
                cmd = new SqlCommand(sqlString, connection);
                connection.Open();
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = sv.mssv;
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
