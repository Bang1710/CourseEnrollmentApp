using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QLDKHP.DTO
{
    internal class DataConnection
    {

        string connectionString;
        public DataConnection() {
            connectionString = "Data Source = ASUSVB\\ASUSVBSQLSERVER ; Initial Catalog=HeThongDangKyHocPhan; user id = MyASUS; pwd=17102002; Integrated Security = true";
        }

        public SqlConnection getConnect()
        {
            return new SqlConnection(connectionString);
        }
    }
}

