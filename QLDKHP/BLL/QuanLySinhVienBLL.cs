using QLDKHP.DAL;
using QLDKHP.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDKHP.BLL
{
    internal class QuanLySinhVienBLL
    {
        QuanLySinhVienDAL DALQuanLySinhVien;
        public QuanLySinhVienBLL()
        {
            DALQuanLySinhVien = new QuanLySinhVienDAL();
        }

        public DataTable getMSSV()
        {
            return DALQuanLySinhVien.getMSSV();
        }

        public DataTable getListSinhVien()
        {
            return DALQuanLySinhVien.getListSinhVien();
        }

        public DataTable FindSinhVien(string id)
        {
            return DALQuanLySinhVien.FindSinhVien(id);
        }

        public DataTable getLSV()
        {
            return DALQuanLySinhVien.getLSV();
        }

        public DataTable getNH()
        {
            return DALQuanLySinhVien.getNH();
        }

        public bool UpdateSinhVien(SinhVien sv)
        {
            return DALQuanLySinhVien.UpdateSinhVien(sv);
        }

        public bool deleteSinhVien(SinhVien sv)
        {
            return DALQuanLySinhVien.deleteSinhVien(sv);
        }
    }
}
