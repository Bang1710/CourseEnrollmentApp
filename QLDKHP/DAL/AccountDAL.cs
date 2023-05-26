using QLDKHP.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDKHP.DAL
{
    internal class AccountDAL
    {
        DataConnection DataConnection;
        SqlDataAdapter data;
        SqlCommand cmd;
        public AccountDAL()
        {
            DataConnection= new DataConnection();
        }

        public DataTable getAccount(string tdn, string ps, string ltk)
        {
            string sqlString = "";
            switch (ltk)
            {
                case "Sinh Viên":
                    sqlString = "select TK.TenDangNhap, TK.MatKhauDN, TK.LoaiTK  from TaiKhoan AS TK\r\nwhere TK.TenDangNhap = N'" + tdn + "' and TK.MatKhauDN = N'" + ps + "' and TK.LoaiTK = N'Sinh Viên'";
                    break;
                case "Giảng Viên":
                    sqlString = "select TK.TenDangNhap, TK.MatKhauDN, TK.LoaiTK  from TaiKhoan AS TK\r\nwhere TK.TenDangNhap = N'" + tdn + "' and TK.MatKhauDN = N'" + ps + "' and TK.LoaiTK = N'Giảng Viên'";
                    break;
                case "Admin":
                    sqlString = "select TK.TenDangNhap, TK.MatKhauDN, TK.LoaiTK  from TaiKhoan AS TK\r\nwhere TK.TenDangNhap = N'" + tdn + "' and TK.MatKhauDN = N'" + ps + "' and TK.LoaiTK = N'Admin'";
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

        //public DataTable getInformationAccount()
        //{
        //    return DataTable;
        //}
    }
}
