using QLDKHP.BLL;
using QLDKHP.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDKHP.GUI
{
    public partial class FrmQuanLySinhVien : Form
    {

        QuanLySinhVienBLL BLLQuanLySinhVien;
        public FrmQuanLySinhVien()
        {
            InitializeComponent();
            BLLQuanLySinhVien = new QuanLySinhVienBLL();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowListSV()
        {
            DataTable dt = BLLQuanLySinhVien.getListSinhVien();
            dtgridviewListSV.DataSource= dt;
        }

        public void ShowMSSV()
        {
            DataTable dt = BLLQuanLySinhVien.getMSSV();
            cbIDSV.DataBindings.Clear();
            cbIDSV.DisplayMember = "MSSV";
            cbIDSV.DataSource = dt;
        }

        public void ShowLSV()
        {
            DataTable dt = BLLQuanLySinhVien.getLSV();
            cbLSV.DataBindings.Clear();
            cbLSV.DisplayMember = "TenLSV";
            cbLSV.DataSource = dt;
        }

        public void ShowNH()
        {
            DataTable dt = BLLQuanLySinhVien.getNH();
            txtNganhHoc.DataBindings.Clear();
            txtNganhHoc.DisplayMember = "TenNH";
            txtNganhHoc.DataSource = dt;
        }

        private void FrmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            ShowMSSV();
            ShowLSV();
            ShowNH();
            ShowListSV();
        }

        private void dtgridviewListSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dtgridviewListSV.Rows.Count - 1)
            {
                txtMSSV.Text = dtgridviewListSV.Rows[index].Cells["MSSV"].Value.ToString();
                txtHoTen.Text = dtgridviewListSV.Rows[index].Cells["HoTen"].Value.ToString();
                txtSDT.Text = dtgridviewListSV.Rows[index].Cells["SoDienThoai"].Value.ToString();
                dtNgaySinh.Value = DateTime.Parse(dtgridviewListSV.Rows[index].Cells["NgaySinh"].Value.ToString());
                txtTonGiao.Text = dtgridviewListSV.Rows[index].Cells["TonGiao"].Value.ToString();
                txtDanToc.Text = dtgridviewListSV.Rows[index].Cells["DanToc"].Value.ToString();
                txtCCCD.Text = dtgridviewListSV.Rows[index].Cells["CCCD"].Value.ToString();
                txtNganhHoc.Text = dtgridviewListSV.Rows[index].Cells["TenNH"].Value.ToString();
                txtEmail.Text = dtgridviewListSV.Rows[index].Cells["EmailT"].Value.ToString();
                cbGioiTinh.Text = dtgridviewListSV.Rows[index].Cells["GioiTinh"].Value.ToString();
                cbLSV.Text = dtgridviewListSV.Rows[index].Cells["TenLSV"].Value.ToString();
                //cbKhoa.Text = dtgridviewHPBB.Rows[index].Cells["tenkhoa"].Value.ToString();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string id = cbIDSV.Text;
            if (!string.IsNullOrEmpty(id))
            {
                DataTable dt = BLLQuanLySinhVien.FindSinhVien(id);
                if (dt.Rows.Count >= 1)
                {
                    dtgridviewListSV.DataSource = dt;
                    MessageBox.Show("Tìm kiếm sinh viên thành công ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      ShowListSV();
                }
                txtMSSV.DataBindings.Clear();
                txtHoTen.DataBindings.Clear();
                txtSDT.DataBindings.Clear();
                dtNgaySinh.DataBindings.Clear();
                txtTonGiao.DataBindings.Clear();
                txtDanToc.DataBindings.Clear();
                txtCCCD.DataBindings.Clear();
                txtNganhHoc.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                cbGioiTinh.DataBindings.Clear();
                cbLSV.DataBindings.Clear();
                txtMSSV.DataBindings.Add("Text", dt, "MSSV");
                txtHoTen.DataBindings.Add("Text", dt, "HoTen");
                txtSDT.DataBindings.Add("Text", dt, "SoDienThoai");
                dtNgaySinh.DataBindings.Add("Value", dt, "NgaySinh");
                txtTonGiao.DataBindings.Add("Text", dt, "TonGiao");
                txtDanToc.DataBindings.Add("Text", dt, "DanToc");
                txtCCCD.DataBindings.Add("Text", dt, "CCCD");
                txtNganhHoc.DataBindings.Add("Text", dt, "TenNH");
                txtEmail.DataBindings.Add("Text", dt, "EmailT");
                cbGioiTinh.DataBindings.Add("Text", dt, "GioiTinh");
                cbLSV.DataBindings.Add("Text", dt, "TenLSV");

            } else
            {
                MessageBox.Show("Hãy chọn mssv cần tìm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (cbIDSV.Text == "")
            {
                ShowListSV();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmThemSinhVien frmThemSinhVien = new FrmThemSinhVien();
            frmThemSinhVien.ShowDialog();
            this.Show();
            ShowListSV();
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

        private void button3_Click(object sender, EventArgs e)
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
                sv.cccd = txtCCCD.Text;
                sv.manh = txtNganhHoc.SelectedIndex + 1;
                sv.malsv = cbLSV.SelectedIndex + 1;

                if (BLLQuanLySinhVien.UpdateSinhVien(sv))
                {
                    MessageBox.Show("Đã cập nhật inh viên thành công", "Thông báo");
                    ShowListSV();
                    txtHoTen.Text = "";
                    txtMSSV.Text = "";
                    cbGioiTinh.Text = "";
                    txtDanToc.Text = "";
                    txtTonGiao.Text = ""; 
                    txtEmail.Text = "";
                    txtSDT.Text = "";
                    txtCCCD.Text = "";
                    txtNganhHoc.Text = "";
                    cbLSV.Text = "";
                } else
                {
                    MessageBox.Show("Đã xảy ra lỗi, hãy thử lại sau !", "Thông báo");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SinhVien sv = new SinhVien();
                sv.mssv = Int32.Parse(txtMSSV.Text);
                if (BLLQuanLySinhVien.deleteSinhVien(sv))
                {
                    ShowListSV();
                    MessageBox.Show("Đã xóa sinh viên thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtHoTen.Text = "";
                    txtMSSV.Text = "";
                    cbGioiTinh.Text = "";
                    txtDanToc.Text = "";
                    txtTonGiao.Text = "";
                    txtEmail.Text = "";
                    txtSDT.Text = "";
                    txtCCCD.Text = "";
                    txtNganhHoc.Text = "";
                    cbLSV.Text = "";
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, hãy thử lại sau !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
    }
}
