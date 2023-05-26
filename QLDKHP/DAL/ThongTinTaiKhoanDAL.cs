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
    internal class ThongTinTaiKhoanDAL
    {
        DataConnection DataConnection;
        SqlDataAdapter data;
        //SqlCommand cmd;
        public ThongTinTaiKhoanDAL()
        {
            DataConnection = new DataConnection();
        }

        public DataTable getInforUserAccount(string tdn, string ps, string ltk)
        {
            string sqlString = "";
            switch (ltk)
            {
                case "Sinh Viên":
                    sqlString = "select SV.HoTen, NH.TenNH from TaiKhoan AS TK, SinhVien AS SV, NganhHoc AS NH\r\nwhere TK.TenDangNhap = N'" + tdn + "' and TK.MatKhauDN = N'" + ps + "' and TK.LoaiTK = N'Sinh Viên' and TK.MSSV = SV.id_sv and SV.MaNH = NH.MaNH";
                    break;
                case "Giảng Viên":
                    sqlString = "select GV.HoTen, CV.TenCV from TaiKhoan AS TK, GiangVien AS GV, ChucVu AS CV\r\nwhere TK.TenDangNhap = N'" + tdn + "' and TK.MatKhauDN = N'" + ps + "' and TK.LoaiTK = N'Giảng Viên' and TK.MSGV = GV.id_gv and GV.MaCV = CV.MaCV";
                    break;
                case "Admin":
                    sqlString = "select NV.Hoten, PB.TenPhongBan from TaiKhoan AS TK, NhanVien AS NV, PhongBan AS PB\r\nwhere TK.TenDangNhap = N'" + tdn + "' and TK.MatKhauDN = N'" + ps + "' and TK.LoaiTK = N'Admin' and TK.MSNV = NV.id_nv and NV.MaPhongBan = PB.MaPhongBan";
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


    }
}
