using QLDKHP.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDKHP.BLL
{
    internal class QuanLyHocPhanPhuTrachBLL
    {
        QuanLYLopHocPhanPhuTrachDAL DALQuanLyHocPhanPhuTrach;
        public QuanLyHocPhanPhuTrachBLL()
        {
            DALQuanLyHocPhanPhuTrach = new QuanLYLopHocPhanPhuTrachDAL();
        }

        public DataTable getThongTinGiangVien(string tdn, string ps)
        {
            return DALQuanLyHocPhanPhuTrach.getThongTinGiangVien(tdn, ps);
        }

        public DataTable getMaLopHocPhan()
        {
            return DALQuanLyHocPhanPhuTrach.getMaLopHocPhan();
        }

        public DataTable getLopHocPhanPhuTrach(string id)
        {
            return DALQuanLyHocPhanPhuTrach.getLopHocPhanPhuTrach(id);
        }

        public DataTable FindLopHocPhan(string malhp)
        {
            return DALQuanLyHocPhanPhuTrach.FindLopHocPhan(malhp);
        }

        public DataTable getDanhSachSinhVien(string id)
        {
            return DALQuanLyHocPhanPhuTrach.getDanhSachSinhVien(id);
        }
    }
}
