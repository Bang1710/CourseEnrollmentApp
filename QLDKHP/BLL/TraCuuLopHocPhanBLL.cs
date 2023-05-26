using QLDKHP.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDKHP.BLL
{
    internal class TraCuuLopHocPhanBLL
    {
        TraCuuLopHocPhanDAL DALTraCuuLopHocPhan;

        public TraCuuLopHocPhanBLL()
        {
            DALTraCuuLopHocPhan = new TraCuuLopHocPhanDAL();
        }
        public DataTable getThongTinHinhThucTimKiem(int i)
        {
            return DALTraCuuLopHocPhan.getThongTinHinhThucTimKiem(i);
        }

        public DataTable getListLopHocPhan(int i, int j)
        {
            return DALTraCuuLopHocPhan.getListLopHocPhan(i, j);
        }
    }
}
