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
    internal class DangKyHocPhanBLL
    {
        DangKyHocPhanDAL DALDangKyHocPhan;
        public DangKyHocPhanBLL()
        {
            DALDangKyHocPhan = new DangKyHocPhanDAL();
        }

        public DataTable getThongTinSinhVien(string tdn, string ps, string ltk)
        {
            return DALDangKyHocPhan.getThongTinSinhVien(tdn, ps, ltk);
        }

        public DataTable getThongTinHocPhanBatBuoc()
        {
            return DALDangKyHocPhan.getThongTinHocPhanBatBuoc();
        }

        public DataTable getThongTinHocPhanTuChon()
        {
            return DALDangKyHocPhan.getThongTinHocPhanTuChon();
        }

        public DataTable getMaLopHocPhan()
        {
            return DALDangKyHocPhan.getMaLopHocPhan();
        }

        public DataTable FindLopHocPhan(string malhp)
        {
            return DALDangKyHocPhan.FindLopHocPhan(malhp);
        }

        public bool InsertDangKyHocPhan(PhieuDangKyHocPhan pdkhp)
        {
            return DALDangKyHocPhan.InsertDangKyHocPhan(pdkhp);
        }

        public DataTable getPhieuDangKyHocPhan(string id_sv, int i)
        {
            return DALDangKyHocPhan.getPhieuDangKyHocPhan(id_sv, i);
        }

        //public bool UpdateSoSVHienTai(LopHocPhan lhp, int i)
        //{
        //    return DALDangKyHocPhan.UpdateSoSVHienTai(lhp, i);
        //}

        public bool deleteLopDangKyHocPhan(PhieuDangKyHocPhan pk)
        {
            return DALDangKyHocPhan.deleteLopDangKyHocPhan(pk);
        }
    }
}
