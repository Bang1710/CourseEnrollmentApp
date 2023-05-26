using QLDKHP.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDKHP.BLL
{
    internal class ThongTinTaiKhoanBLL
    {
        ThongTinTaiKhoanDAL DALInforUser;
        public ThongTinTaiKhoanBLL() {
            DALInforUser = new ThongTinTaiKhoanDAL();
        }

        public DataTable getInforUserAccount(string tdn, string ps, string ltk)
        {
            return DALInforUser.getInforUserAccount(tdn, ps, ltk);
        }
    }
}
