using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDKHP.DTO
{
    internal class LopHocPhan
    {
        public int id_lhp { get; set; }
        public int ma_lhp { get; set; }
        public string ten_lhp { get; set; }
        public DateTime ngaybd { get; set; }
        public DateTime ngaykt { get; set; }
        public int svhientai { get; set; }
        public int svtoida { get; set; }
    }
}
