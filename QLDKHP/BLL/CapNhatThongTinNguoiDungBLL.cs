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
    internal class CapNhatThongTinNguoiDungBLL
    {
        CapNhatThongTinNguoiDungDAL DALInforUser;
        public CapNhatThongTinNguoiDungBLL()
        {
            DALInforUser = new CapNhatThongTinNguoiDungDAL();
        }

        public DataTable getThongTinCaNhanNguoiDung(string tdn, string ps, string ltk)
        {
            return DALInforUser.getThongTinCaNhanNguoiDung(tdn, ps, ltk);
        }

        //public bool UpdatePassword(string tdn, string ps, string ltk, string psn)
        //{
        //    return DALInforUser.UpdatePassword(tdn, ps, ltk, psn);
        //}

        public bool UpdatePassword(Account ac)
        {
            return DALInforUser.UpdatePassword(ac);
        }

        public bool UpdateInforBase(NhanVien nv)
        {
            return DALInforUser.UpdateInforBase(nv);
        }

        public bool UpdateInforBaseSinhVien(SinhVien sv)
        {
            return DALInforUser.UpdateInforBaseSinhVien(sv);
        }

        public bool UpdateInforBaseGiangVien(GiangVien gv)
        {
            return DALInforUser.UpdateInforBaseGiangVien(gv);
        }
    }
}
