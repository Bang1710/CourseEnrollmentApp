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
    public partial class FrmAdmin : Form
    {
        ThongTinTaiKhoanBLL BLLInforUser;
        //CapNhatThongTinNguoiDungBLL BLLThongTinNguoiDung;
        public FrmAdmin()
        {
            InitializeComponent();
            BLLInforUser= new ThongTinTaiKhoanBLL();
            //BLLThongTinNguoiDung = new CapNhatThongTinNguoiDungBLL();
        }

        public string tdn;
        public string ps;
        public string ltk;

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            DataTable dt = BLLInforUser.getInforUserAccount(tdn, ps, ltk);
            txtTenNV.DataBindings.Add("Text", dt, "Hoten");
            txtTenPB.DataBindings.Add("Text", dt, "TenPhongBan");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCapNhapThongTinAdmin frmInformationAdmin= new FrmCapNhapThongTinAdmin();
            frmInformationAdmin.tdn = tdn;
            frmInformationAdmin.ps = ps;
            frmInformationAdmin.ltk = ltk;
            //DataTable dt = BLLThongTinNguoiDung.getThongTinCaNhanNguoiDung(tdn, ps, ltk);
            frmInformationAdmin.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn tắt cửa sổ này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmQuanLySinhVien frmQuanLySinhVien = new FrmQuanLySinhVien();
            frmQuanLySinhVien.ShowDialog();
            this.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmQuanLySinhVien frmQuanLySinhVien = new FrmQuanLySinhVien();
            frmQuanLySinhVien.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmQuanLySinhVien frmQuanLySinhVien = new FrmQuanLySinhVien();
            frmQuanLySinhVien.ShowDialog();
            this.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmQuanLyGiangVien frmQuanLyGiangVien = new FrmQuanLyGiangVien();
            frmQuanLyGiangVien.ShowDialog();
            this.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmQuanLyGiangVien frmQuanLyGiangVien = new FrmQuanLyGiangVien();
            frmQuanLyGiangVien.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmQuanLyGiangVien frmQuanLyGiangVien = new FrmQuanLyGiangVien();
            frmQuanLyGiangVien.ShowDialog();
            this.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmQuanLyHocPhan frmQuanLyHocPhan = new FrmQuanLyHocPhan();
            frmQuanLyHocPhan.ShowDialog();
            this.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmQuanLyHocPhan frmQuanLyHocPhan = new FrmQuanLyHocPhan();
            frmQuanLyHocPhan.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmQuanLyHocPhan frmQuanLyHocPhan = new FrmQuanLyHocPhan();
            frmQuanLyHocPhan.ShowDialog();
            this.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmQuanLyQuyDinh frmQuanLyQuyDinh = new FrmQuanLyQuyDinh();
            frmQuanLyQuyDinh.ShowDialog();
            this.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmQuanLyQuyDinh frmQuanLyQuyDinh = new FrmQuanLyQuyDinh();
            frmQuanLyQuyDinh.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmQuanLyQuyDinh frmQuanLyQuyDinh = new FrmQuanLyQuyDinh();
            frmQuanLyQuyDinh.ShowDialog();
            this.Show();
        }
    }
}
