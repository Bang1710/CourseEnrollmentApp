using QLDKHP.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDKHP.DAL
{
    internal class CapNhatThongTinNguoiDungDAL
    {
        DataConnection DataConnection;
        SqlDataAdapter data;
        SqlCommand cmd;

        public CapNhatThongTinNguoiDungDAL()
        {
            DataConnection = new DataConnection();
        }

        public DataTable getThongTinCaNhanNguoiDung(string tdn, string ps, string ltk)
        {
            string sqlString = "";
            switch (ltk)
            {
                case "Sinh Viên":
                    sqlString = "select TK.TenDangNhap, TK.MatKhauDN, TK.LoaiTK, SV.MSSV, SV.HoTen, SV.NgaySinh, SV.GioiTinh, SV.DanToc, SV.TonGiao, SV.SoDienThoai, SV.CCCD, SV.EmailT, NH.TenNH, LSV.TenLSV from TaiKhoan AS TK, SinhVien AS SV, NganhHoc AS NH, LopSinhVien AS LSV\r\nwhere TK.TenDangNhap = N'" + tdn + "' and TK.MatKhauDN = N'" + ps + "' and TK.LoaiTK = N'Sinh Viên' and TK.MSSV = SV.id_sv and SV.MaNH = NH.MaNH and SV.MaLSV = LSV.MaLSV";
                    break;
                case "Giảng Viên":
                    sqlString = "select TK.TenDangNhap, TK.MatKhauDN, TK.LoaiTK, GV.MSGV, GV.HoTen, GV.NgaySinh, GV.GioiTinh, GV.DanToc, GV.TonGiao, GV.SoDienThoai, GV.CCCD, GV.EmailT, BC.TenBC, CV.TenCV, KH.TenKhoa from TaiKhoan AS TK, GiangVien AS GV, Khoa AS KH, BangCap AS BC, ChucVu AS CV\r\nwhere TK.TenDangNhap = N'" + tdn + "' and TK.MatKhauDN = N'" + ps + "' and TK.LoaiTK = N'Giảng Viên' and TK.MSGV = GV.id_gv and GV.MaKhoa = KH.MaKhoa and GV.MaCV = CV.MaCV and GV.MaBC = BC.MaBC";
                    break;
                case "Admin":
                    sqlString = "select TK.TenDangNhap, TK.MatKhauDN, TK.LoaiTK, NV.MSNV, NV.HoTen, NV.NgaySinh, NV.GioiTinh, NV.DanToc, NV.TonGiao, NV.SoDienThoai, NV.CCCD, NV.NgayLamViec, CV.TenCV from TaiKhoan AS TK, NhanVien AS NV, ChucVu AS CV\r\nwhere TK.TenDangNhap = N'" + tdn + "' and TK.MatKhauDN = N'" + ps + "' and TK.LoaiTK = N'Admin' and TK.MSNV = NV.id_nv and NV.MaCV = CV.MaCV";
                    break;
                default:
                    break;
            }

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

        //public bool UpdatePassword(string tdn, string ps, string ltk, string psn)
        //{
        //    string sqlString = "Update TaiKhoan SET MatKhauDN = N'"+ psn +" where TK.TenDangNhap = N'" + tdn + "' and TK.MatKhauDN = N'" + ps + "' and TK.LoaiTK = N'" + ltk + "'";
        //    SqlConnection connection = DataConnection.getConnect();
        //    try
        //    {
        //        cmd = new SqlCommand(sqlString, connection);
        //        connection.Open();
        //        //cmd.Parameters.Add("@matkhau", SqlDbType.Char).Value = psn;
        //        cmd.ExecuteNonQuery();
        //        connection.Close();
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //    return true;
        //}

        public bool UpdatePassword(Account ac)
        {
            string sqlString = "Update TaiKhoan SET MatKhauDN = @MatKhauDNM where TaiKhoan.TenDangNhap = @TenDangNhap and TaiKhoan.MatKhauDN = @MatKhauDN and TaiKhoan.LoaiTK = @LoaiTK";
            SqlConnection connection = DataConnection.getConnect();
            try
            {
                cmd = new SqlCommand(sqlString, connection);
                connection.Open();
                cmd.Parameters.Add("@MatKhauDNM", SqlDbType.Char).Value = ac.psn;
                cmd.Parameters.Add("@TenDangNhap", SqlDbType.Char).Value = ac.tendn;
                cmd.Parameters.Add("@MatKhauDN", SqlDbType.Char).Value = ac.mk;
                cmd.Parameters.Add("@LoaiTK", SqlDbType.NVarChar).Value = ac.loaitk;
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool UpdateInforBase(NhanVien nv)
        {
            string sqlString = "Update NhanVien SET NgaySinh = @NgaySinh, GioiTinh = @GioiTinh,TonGiao = @TonGiao, DanToc = @DanToc,SoDienThoai = @SoDienThoai,CCCD = @CCCD, NgayLamViec = @NgayLamViec \r\nwhere NhanVien.MSNV = @MSNV";
            SqlConnection connection = DataConnection.getConnect();
            try
            {
                cmd = new SqlCommand(sqlString, connection);
                connection.Open();
                cmd.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = nv.ngaysinh;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = nv.sex;
                cmd.Parameters.Add("@TonGiao", SqlDbType.NVarChar).Value = nv.tongiao;
                cmd.Parameters.Add("@DanToc", SqlDbType.NVarChar).Value = nv.dantoc;
                cmd.Parameters.Add("@SoDienThoai", SqlDbType.Char).Value = nv.sdt;
                cmd.Parameters.Add("@CCCD", SqlDbType.Char).Value = nv.cccd;
                cmd.Parameters.Add("@NgayLamViec", SqlDbType.DateTime).Value = nv.ngaylamviec;
                cmd.Parameters.Add("@MSNV", SqlDbType.Int).Value = nv.msnv;
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        public bool UpdateInforBaseSinhVien(SinhVien sv)
        {
            string sqlString = "Update SinhVien SET NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, DanToc = @DanToc, TonGiao = @TonGiao, SoDienThoai = @SoDienThoai, EmailT = @EmailT, CCCD = @CCCD where SinhVien.MSSV = @MSSV";
            SqlConnection connection = DataConnection.getConnect();
            try
            {
                cmd = new SqlCommand(sqlString, connection);
                connection.Open();
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = sv.sex;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = sv.ngaysinh;
                cmd.Parameters.Add("@DanToc", SqlDbType.NVarChar).Value = sv.dantoc;
                cmd.Parameters.Add("@TonGiao", SqlDbType.NVarChar).Value = sv.tongiao;
                cmd.Parameters.Add("@SoDienThoai", SqlDbType.Char).Value = sv.sdt;
                cmd.Parameters.Add("@EmailT", SqlDbType.Char).Value = sv.email;
                cmd.Parameters.Add("@CCCD", SqlDbType.Char).Value = sv.cccd;
                cmd.Parameters.Add("@MSSV", SqlDbType.Int).Value = sv.mssv;
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        public bool UpdateInforBaseGiangVien(GiangVien gv)
        {
            string sqlString = "Update GiangVien SET NgaySinh = @NgaySinh,GioiTinh = @GioiTinh, DanToc = @DanToc, TonGiao = @TonGiao, SoDienThoai = @SoDienThoai, EmailT = @EmailT, CCCD = @CCCD, MaBC = @MaBC where GiangVien.MSGV = @MSGV ";
            SqlConnection connection = DataConnection.getConnect();
            try
            {
                cmd = new SqlCommand(sqlString, connection);
                connection.Open();
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = gv.sex;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = gv.ngaysinh;
                cmd.Parameters.Add("@DanToc", SqlDbType.NVarChar).Value = gv.dantoc;
                cmd.Parameters.Add("@TonGiao", SqlDbType.NVarChar).Value = gv.tongiao;
                cmd.Parameters.Add("@SoDienThoai", SqlDbType.Char).Value = gv.sdt;
                cmd.Parameters.Add("@EmailT", SqlDbType.Char).Value = gv.email;
                cmd.Parameters.Add("@CCCD", SqlDbType.Char).Value = gv.cccd;
                cmd.Parameters.Add("@MSGV", SqlDbType.Int).Value = gv.msgv;
                cmd.Parameters.Add("@MaBC", SqlDbType.Int).Value = gv.mabc;
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
