using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDKHP.GUI
{
    public partial class FrmDanhSachSinhVienLopHocPhan : Form
    {

        public string MaLHP;
        public string TenLHP;
        public string GiangVien;
        public string SoTinChi;
        public DataTable dt;
        public FrmDanhSachSinhVienLopHocPhan()
        {
            InitializeComponent();
        }

        private void FrmDanhSachSinhVienLopHocPhan_Load(object sender, EventArgs e)
        {
            txtMaLHP.Text = MaLHP;
            txtTenLHP.Text = TenLHP;
            txtHoTenGV.Text = GiangVien;
            txtSoTC.Text = SoTinChi;
            dtListSV.DataSource = dt;
        }
    }
}
