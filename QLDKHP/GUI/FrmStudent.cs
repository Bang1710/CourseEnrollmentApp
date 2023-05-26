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
    public partial class FrmStudent : Form
    {
        ThongTinTaiKhoanBLL BLLInforUser;
        public string tdn;
        public string ps;
        public string ltk;

        public FrmStudent()
        {
            InitializeComponent();
            BLLInforUser = new ThongTinTaiKhoanBLL();
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            DataTable dt = BLLInforUser.getInforUserAccount(tdn, ps, ltk);
            txtTenNV.DataBindings.Add("Text", dt, "Hoten");
            txtTenPB.DataBindings.Add("Text", dt, "TenNH");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCapNhatThongTinSinhVien frmCapNhatThongTinSinhVien = new FrmCapNhatThongTinSinhVien();
            frmCapNhatThongTinSinhVien.tdn = tdn;
            frmCapNhatThongTinSinhVien.ps = ps;
            frmCapNhatThongTinSinhVien.ltk = ltk;
            frmCapNhatThongTinSinhVien.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDKHP frmDKHP = new FrmDKHP();
            frmDKHP.tdn = tdn;
            frmDKHP.ps = ps;
            frmDKHP.ltk = ltk;
            frmDKHP.ShowDialog();
            this.Show();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDKHP frmDKHP = new FrmDKHP();
            frmDKHP.tdn = tdn;
            frmDKHP.ps = ps;
            frmDKHP.ltk = ltk;
            frmDKHP.ShowDialog();
            this.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDKHP frmDKHP = new FrmDKHP();
            frmDKHP.tdn = tdn;
            frmDKHP.ps = ps;
            frmDKHP.ltk = ltk;
            frmDKHP.ShowDialog();
            this.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTraCuuLopHocPhan frmTraCuuLopHocPhan = new FrmTraCuuLopHocPhan();
            frmTraCuuLopHocPhan.ShowDialog();
            this.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTraCuuLopHocPhan frmTraCuuLopHocPhan = new FrmTraCuuLopHocPhan();
            frmTraCuuLopHocPhan.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTraCuuLopHocPhan frmTraCuuLopHocPhan = new FrmTraCuuLopHocPhan();
            frmTraCuuLopHocPhan.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void FrmStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn tắt cửa sổ này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
