using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDKHP.DTO
{
    internal class NhanVien
    {
        public int id_nv { get; set; }
        public int msnv { get; set; }    
        public string tennv { get; set; }
        public string sex { get; set; }
        public DateTime ngaysinh { get; set; }
        public string dantoc { get; set; }
        public string tongiao { get; set; }
        public string sdt { get; set; }
        public string cccd { get; set; }
        public DateTime ngaylamviec { get; set; }

        public string tdn { get; set; }
        public string ps { get; set; }
        public string ltk { get; set; }

    }
}
