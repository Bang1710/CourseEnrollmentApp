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
    internal class DangKyMonHocBLL
    {
        DangKyMonHocDAL DALDangKyMonHoc;
        public DangKyMonHocBLL() { 
            DALDangKyMonHoc = new DangKyMonHocDAL();
        }

        public DataTable getThongTinGiangVien(string tdn, string ps)
        {
            return DALDangKyMonHoc.getThongTinGiangVien(tdn, ps);
        }

        public DataTable getListMonHoc()
        {
            return DALDangKyMonHoc.getListMonHoc();
        }

        public DataTable getSoLopHienTai(int id)
        {
            return DALDangKyMonHoc.getSoLopHienTai(id);
        }

        public bool InsertDangKyMonHoc(PhieuDangKyMonHoc pdkmh)
        {
            return DALDangKyMonHoc.InsertDangKyMonHoc(pdkmh);
        }

        public DataTable getPhieDangKyMonHoc(int id)
        {
            return DALDangKyMonHoc.getPhieDangKyMonHoc(id);
        }

        public bool deleteLopDangKyHocPhan(PhieuDangKyMonHoc pk)
        {
            return DALDangKyMonHoc.deleteLopDangKyHocPhan(pk);
        }

        public DataTable getMaMonHoc()
        {
            return DALDangKyMonHoc.getMaMonHoc();
        }

        public DataTable FindMonHoc(string id)
        {
            return DALDangKyMonHoc.FindMonHoc(id);
        }

        public bool UpdatePhieuDangKyMonHoc(PhieuDangKyMonHoc pdkmh)
        {
            return DALDangKyMonHoc.UpdatePhieuDangKyMonHoc(pdkmh) ;
        }
    }
}
