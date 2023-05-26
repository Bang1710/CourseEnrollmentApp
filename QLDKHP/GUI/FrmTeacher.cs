using QLDKHP.BLL;
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
    public partial class FrmTeacher : Form
    {
        ThongTinTaiKhoanBLL BLLInforUser;
        public string tdn;
        public string ps;
        public string ltk;
        public FrmTeacher()
        {
            InitializeComponent();
            BLLInforUser= new ThongTinTaiKhoanBLL();
        }

        private void FrmTeacher_Load(object sender, EventArgs e)
        {
            DataTable dt = BLLInforUser.getInforUserAccount(tdn, ps, ltk);
            txtTenNV.DataBindings.Add("Text", dt, "Hoten");
            txtTenPB.DataBindings.Add("Text", dt, "TenCV");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCapNhatThongTinTeacher frmCapNhatThongTinTeacher = new FrmCapNhatThongTinTeacher();
            frmCapNhatThongTinTeacher.tdn = tdn;
            frmCapNhatThongTinTeacher.ps = ps;
            frmCapNhatThongTinTeacher.ltk = ltk;
            frmCapNhatThongTinTeacher.ShowDialog();
            this.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmQuanLyLopHocPhanPhuTrach frmQuanLyLopHocPhanPhuTrach = new FrmQuanLyLopHocPhanPhuTrach();
            frmQuanLyLopHocPhanPhuTrach.tdn = tdn;
            frmQuanLyLopHocPhanPhuTrach.ps = ps;
            //frmDangKyMonHoc.ltk = ltk;
            frmQuanLyLopHocPhanPhuTrach.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmQuanLyLopHocPhanPhuTrach frmQuanLyLopHocPhanPhuTrach = new FrmQuanLyLopHocPhanPhuTrach();
            frmQuanLyLopHocPhanPhuTrach.tdn = tdn;
            frmQuanLyLopHocPhanPhuTrach.ps = ps;
            //frmDangKyMonHoc.ltk = ltk;
            frmQuanLyLopHocPhanPhuTrach.ShowDialog();
            this.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmQuanLyLopHocPhanPhuTrach frmQuanLyLopHocPhanPhuTrach = new FrmQuanLyLopHocPhanPhuTrach();
            frmQuanLyLopHocPhanPhuTrach.tdn = tdn;
            frmQuanLyLopHocPhanPhuTrach.ps = ps;
            //frmDangKyMonHoc.ltk = ltk;
            frmQuanLyLopHocPhanPhuTrach.ShowDialog();
            this.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangKyMonHoc frmDangKyMonHoc = new FrmDangKyMonHoc();
            frmDangKyMonHoc.tdn = tdn;
            frmDangKyMonHoc.ps = ps;
            //frmDangKyMonHoc.ltk = ltk;
            frmDangKyMonHoc.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangKyMonHoc frmDangKyMonHoc = new FrmDangKyMonHoc();
            frmDangKyMonHoc.tdn = tdn;
            frmDangKyMonHoc.ps = ps;
            //frmDangKyMonHoc.ltk = ltk;
            frmDangKyMonHoc.ShowDialog();
            this.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangKyMonHoc frmDangKyMonHoc = new FrmDangKyMonHoc();
            frmDangKyMonHoc.tdn = tdn;
            frmDangKyMonHoc.ps = ps;
            //frmDangKyMonHoc.ltk = ltk;
            frmDangKyMonHoc.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTeacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn tắt cửa sổ này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
