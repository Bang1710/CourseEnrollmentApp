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
    internal class ThemSinhVienBLL
    {
        ThemSinhVienDAL DALThemSinhVien;
        public ThemSinhVienBLL()
        {
            DALThemSinhVien = new ThemSinhVienDAL();
        }

        public DataTable getLSV()
        {
            return DALThemSinhVien.getLSV();
        }

        public DataTable getNH()
        {
            return DALThemSinhVien.getNH();
        }

        public bool insertSinhVien(SinhVien sv)
        {
            return DALThemSinhVien.insertSinhVien(sv);
        }
    }
}
