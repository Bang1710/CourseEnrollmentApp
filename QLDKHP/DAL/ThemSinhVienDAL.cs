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
    internal class ThemSinhVienDAL
    {
        DataConnection DataConnection;
        SqlDataAdapter data;
        SqlCommand cmd;
        
        public ThemSinhVienDAL()
        {
            DataConnection = new DataConnection();
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

        public bool insertSinhVien(SinhVien sv)
        {
            string sqlString = "Insert into SinhVien Values (@mssv, @tensv, @sex, @ngaysinh, @dantoc, @tongiao, @sdt, @email, @cccd, @manh, @malsv)";
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
