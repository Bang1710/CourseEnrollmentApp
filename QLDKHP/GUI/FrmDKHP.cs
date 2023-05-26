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
    public partial class FrmDKHP : Form
    {
        DangKyHocPhanBLL BLLDangKyHocPhan;
        public string tdn;
        public string ps;
        public string ltk;
        public int i = 0;
        public FrmDKHP()
        {
            InitializeComponent();
            BLLDangKyHocPhan = new DangKyHocPhanBLL();
        }

        private void FrmDKHP_Load(object sender, EventArgs e)
        {
            DataTable dt = BLLDangKyHocPhan.getThongTinSinhVien(tdn, ps, ltk);
            txtID_SV.DataBindings.Add("Text", dt, "id_sv");
            txtMSSV.DataBindings.Add("Text", dt, "MSSV");
            txtHoTenSV.DataBindings.Add("Text", dt, "HoTen");
            txtLSV.DataBindings.Add("Text", dt, "TenLSV");
            dtNgayBD.Value = DateTime.Parse("1999-01-01");
            dtNgayKT.Value = DateTime.Parse("2022-01-01");
            ShowHPBB();
            ShowHPTC();
            DataTable dtMaLHP = BLLDangKyHocPhan.getMaLopHocPhan();
            cbFind.DisplayMember= "MaLHP";
            cbFind.DataSource= dtMaLHP;
            cbFind.Text = "";
            ShowPhieuDangKyHocPhan();
        }

        public void ShowPhieuDangKyHocPhan()
        {
           
            DataTable dt = BLLDangKyHocPhan.getPhieuDangKyHocPhan(txtID_SV.Text, i);
            dtgridviewPhieuDangKyHocPhan.DataSource= dt;
        }

        private void ShowHPBB()
        {
            DataTable dtHPBB = BLLDangKyHocPhan.getThongTinHocPhanBatBuoc();
            dtgridviewHPBB.DataSource = dtHPBB;
        }

        private void ShowHPTC()
        {
            DataTable dtHPTC = BLLDangKyHocPhan.getThongTinHocPhanTuChon();
            dtgridviewHPTC.DataSource = dtHPTC;
        }

        private void dtgridviewHPBB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dtgridviewHPBB.Rows.Count - 1)
            {
                txtIdLHP.Text = dtgridviewHPBB.Rows[index].Cells["ID"].Value.ToString();
                txtMaLHP.Text = dtgridviewHPBB.Rows[index].Cells["MaLHP"].Value.ToString();
                txtTenLHP.Text = dtgridviewHPBB.Rows[index].Cells["TenLHP"].Value.ToString();
                dtNgayBD.Value = DateTime.Parse(dtgridviewHPBB.Rows[index].Cells["NgayBD"].Value.ToString());
                dtNgayKT.Value = DateTime.Parse(dtgridviewHPBB.Rows[index].Cells["NgayKT"].Value.ToString());
                txtSoSV.Text = dtgridviewHPBB.Rows[index].Cells["SoLuongSV"].Value.ToString();
                txtSoSVMax.Text = dtgridviewHPBB.Rows[index].Cells["SoLuongSVmax"].Value.ToString();
                //cbKhoa.Text = dtgridviewHPBB.Rows[index].Cells["tenkhoa"].Value.ToString();
            }
        }

        private void dtgridviewHPTC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dtgridviewHPTC.Rows.Count - 1)
            {
                txtIdLHP.Text = dtgridviewHPTC.Rows[index].Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                txtMaLHP.Text = dtgridviewHPTC.Rows[index].Cells["dataGridViewTextBoxColumn2"].Value.ToString();
                txtTenLHP.Text = dtgridviewHPTC.Rows[index].Cells["dataGridViewTextBoxColumn3"].Value.ToString();
                dtNgayBD.Value = DateTime.Parse(dtgridviewHPTC.Rows[index].Cells["dataGridViewTextBoxColumn4"].Value.ToString());
                dtNgayKT.Value = DateTime.Parse(dtgridviewHPTC.Rows[index].Cells["dataGridViewTextBoxColumn5"].Value.ToString());
                txtSoSV.Text = dtgridviewHPTC.Rows[index].Cells["dataGridViewTextBoxColumn6"].Value.ToString();
                txtSoSVMax.Text = dtgridviewHPTC.Rows[index].Cells["dataGridViewTextBoxColumn7"].Value.ToString();
                //cbKhoa.Text = dtgridviewHPBB.Rows[index].Cells["tenkhoa"].Value.ToString();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string malhp = cbFind.Text;
            if (!string.IsNullOrEmpty(malhp))
            {

                DataTable dt = BLLDangKyHocPhan.FindLopHocPhan(malhp);
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("Tìm kiếm lớp học phần thành công ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Không tìm thấy lớp học phần ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowHPBB();
                    ShowHPTC();
                }
                txtIdLHP.DataBindings.Clear();
                txtMaLHP.DataBindings.Clear();
                txtTenLHP.DataBindings.Clear();
                txtSoSV.DataBindings.Clear();
                txtSoSVMax.DataBindings.Clear();
                dtNgayBD.DataBindings.Clear();
                dtNgayKT.DataBindings.Clear();
                dtgridviewHPBB.DataSource = dt;
                dtgridviewHPTC.DataSource = dt;
                txtIdLHP.DataBindings.Add("Text", dt, "ID");
                txtMaLHP.DataBindings.Add("Text", dt, "MaLHP");
                txtTenLHP.DataBindings.Add("Text", dt, "TenLHP");
                txtSoSV.DataBindings.Add("Text", dt, "SoLuongSV");
                txtSoSVMax.DataBindings.Add("Text", dt, "SoLuongSVmax");
                dtNgayBD.DataBindings.Add("Value", dt, "NgayBD");
                dtNgayKT.DataBindings.Add("Value", dt, "NgayKT");
            }
            else
            {
                MessageBox.Show("Hãy chọn mã lớp học phần cần tìm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (cbFind.Text == "")
            {
                ShowHPBB();
                ShowHPTC();
            }
        }

        public bool checkDataLopHocPhan()
        {
            if (txtID_SV.Text == "")
            {
                MessageBox.Show("Hãy kiểm tra lại mã số sinh viên của sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtIdLHP.Text == "")
            {
                MessageBox.Show("Hãy kiểm tra lại thông tin ID lớp học phần", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtMaLHP.Text == "")
            {
                MessageBox.Show("Hãy kiểm tra lại mã lớp học phần", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtTenLHP.Text == "")
            {
                MessageBox.Show("Hãy kiểm tra lại tên lớp học phần", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtSoSV.Text == "")
            {
                MessageBox.Show("Hãy kiểm tra lại số sinh viên của lớp học phần", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtSoSVMax.Text == "")
            {
                MessageBox.Show("Hãy kiểm tra lại số sinh viên tối đa của lớp học phần", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (Int32.Parse(txtSoSV.Text) >= Int32.Parse(txtSoSVMax.Text))
            {
                MessageBox.Show("Số lượng sinh hiện tại lớn hơn số lượng sinh viên tối đa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (checkDataLopHocPhan())
            {
                PhieuDangKyHocPhan pk = new PhieuDangKyHocPhan();
                //LopHocPhan lhp = new LopHocPhan();
                //lhp.id_lhp = Int32.Parse(txtIdLHP.Text);
                pk.id_lhp = Int32.Parse(txtIdLHP.Text);
                pk.id_sv = Int32.Parse(txtID_SV.Text);
                if (BLLDangKyHocPhan.InsertDangKyHocPhan(pk))
                {
                    i = 1;
                    ShowPhieuDangKyHocPhan();
                    //BLLDangKyHocPhan.UpdateSoSVHienTai(lhp, i);
                    MessageBox.Show("Đã đăng ký thành công lớp học phần này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Lớp học phần này đã đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtgridviewPhieuDangKyHocPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dtgridviewPhieuDangKyHocPhan.Rows.Count - 1)
            {
                txtIdLHP.Text = dtgridviewPhieuDangKyHocPhan.Rows[index].Cells["dataGridViewTextBoxColumn17"].Value.ToString();
                txtMaLHP.Text = dtgridviewPhieuDangKyHocPhan.Rows[index].Cells["dataGridViewTextBoxColumn18"].Value.ToString();
                txtTenLHP.Text = dtgridviewPhieuDangKyHocPhan.Rows[index].Cells["dataGridViewTextBoxColumn19"].Value.ToString();
                dtNgayBD.Value = DateTime.Parse(dtgridviewPhieuDangKyHocPhan.Rows[index].Cells["dataGridViewTextBoxColumn20"].Value.ToString());
                dtNgayKT.Value = DateTime.Parse(dtgridviewPhieuDangKyHocPhan.Rows[index].Cells["dataGridViewTextBoxColumn21"].Value.ToString());
                txtSoSV.Text = dtgridviewPhieuDangKyHocPhan.Rows[index].Cells["dataGridViewTextBoxColumn22"].Value.ToString();
                txtSoSVMax.Text = dtgridviewPhieuDangKyHocPhan.Rows[index].Cells["dataGridViewTextBoxColumn23"].Value.ToString();
                //cbKhoa.Text = dtgridviewHPBB.Rows[index].Cells["tenkhoa"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            PhieuDangKyHocPhan pk = new PhieuDangKyHocPhan();
            pk.id_lhp = Int32.Parse(txtIdLHP.Text);
            if (BLLDangKyHocPhan.deleteLopDangKyHocPhan(pk))
            {
                ShowPhieuDangKyHocPhan();
                txtIdLHP.Text = "";
                txtMaLHP.Text = "";
                txtTenLHP.Text = "";
                txtSoSV.Text = "";
                txtSoSVMax.Text = "";
                dtNgayBD.Text = "1999-01-01";
                dtNgayKT.Text = "2022-01-01";

                MessageBox.Show("Bạn đã xóa lớp học phần thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Đã xảy ra lỗi, hãy thử lại sau !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDKHP_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn tắt cửa sổ này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
