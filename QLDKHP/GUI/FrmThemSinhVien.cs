using QLDKHP.BLL;
using QLDKHP.DTO;
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
    public partial class FrmThemSinhVien : Form
    {
        ThemSinhVienBLL BLLThemSinhVien;
        public FrmThemSinhVien()
        {
            InitializeComponent();
            BLLThemSinhVien = new ThemSinhVienBLL();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowLSV()
        {
            DataTable dt = BLLThemSinhVien.getLSV();
            cbLSV.DataBindings.Clear();
            cbLSV.DisplayMember = "TenLSV";
            cbLSV.DataSource = dt;
        }

        public void ShowNH()
        {
            DataTable dt = BLLThemSinhVien.getNH();
            txtNganhHoc.DataBindings.Clear();
            txtNganhHoc.DisplayMember = "TenNH";
            txtNganhHoc.DataSource = dt;
        }

        private void FrmThemSinhVien_Load(object sender, EventArgs e)
        {
            ShowLSV();
            ShowNH();

        }

        public bool checkData()
        {
            if (txtMSSV.Text == "")
            {
                MessageBox.Show("Hãy kiểm tra lại mã số sinh viên của sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Hãy kiểm tra lại họ tên của sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (txtCCCD.Text == "")
            {
                MessageBox.Show("Hãy kiểm tra lại cccd của sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (txtDanToc.Text == "")
            {
                MessageBox.Show("Hãy kiểm tra lại dân tộc của sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (txtSDT.Text == "")
            {
                MessageBox.Show("Hãy kiểm tra lại số điện thoại sinh viên của sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (txtTonGiao.Text == "")
            {
                MessageBox.Show("Hãy kiểm tra lại tôn giáo của sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (cbGioiTinh.Text == "")
            {
                MessageBox.Show("Hãy kiểm tra lại giới tính của sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (cbLSV.Text == "")
            {
                MessageBox.Show("Hãy kiểm tra lại lớp sinh viên của sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (txtNganhHoc.Text == "")
            {
                MessageBox.Show("Hãy kiểm tra lại ngành học của sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                SinhVien sv = new SinhVien();
                sv.mssv = Int32.Parse(txtMSSV.Text);
                sv.tensv = txtHoTen.Text;
                sv.sex = cbGioiTinh.Text;
                sv.ngaysinh = dtNgaySinh.Value;
                sv.dantoc = txtDanToc.Text;
                sv.tongiao = txtTonGiao.Text;
                sv.email = txtEmail.Text;
                sv.sdt = txtSDT.Text;
                sv.cccd= txtCCCD.Text;
                sv.manh = txtNganhHoc.SelectedIndex + 1;
                sv.malsv = cbLSV.SelectedIndex + 1;

                if (BLLThemSinhVien.insertSinhVien(sv))
                {
                    MessageBox.Show("Đã Thêm sinh viên thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi, hãy thử lại sau !", "Thông báo");
                }

            }
        }
    }
}
