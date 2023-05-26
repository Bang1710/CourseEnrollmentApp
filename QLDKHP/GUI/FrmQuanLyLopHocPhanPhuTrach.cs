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
    public partial class FrmQuanLyLopHocPhanPhuTrach : Form
    {
        QuanLyHocPhanPhuTrachBLL BLLQuanLyHocPhanPhuTrach;
        public string tdn;
        public string ps;
        public FrmQuanLyLopHocPhanPhuTrach()
        {
            InitializeComponent();
            BLLQuanLyHocPhanPhuTrach = new QuanLyHocPhanPhuTrachBLL();
        }

        private void FrmQuanLyLopHocPhanPhuTrach_Load(object sender, EventArgs e)
        {
            DataTable dt = BLLQuanLyHocPhanPhuTrach.getThongTinGiangVien(tdn, ps);
            txtID_GV.DataBindings.Add("Text", dt, "id_gv");
            txtMSGV.DataBindings.Add("Text", dt, "MSGV");
            txtHoTenGV.DataBindings.Add("Text", dt, "HoTen");
            txtCV.DataBindings.Add("Text", dt, "TenCV");
            txtKhoa.DataBindings.Add("Text", dt, "TenKhoa");
            ShowMaLHP();
            ShowLOpHocPhanPhuTrach();
        }

        public void ShowMaLHP()
        {
            DataTable dt = BLLQuanLyHocPhanPhuTrach.getMaLopHocPhan();
            cbFind.DisplayMember = "MaLHP";
            cbFind.DataSource = dt;
        }

        public void ShowLOpHocPhanPhuTrach()
        {
            DataTable dt = BLLQuanLyHocPhanPhuTrach.getLopHocPhanPhuTrach(txtID_GV.Text);
            dtgridviewListLHP.DataSource = dt;
        }

        private void dtgridviewListLHP_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            if (index >= 0 && index < dtgridviewListLHP.Rows.Count - 1)
            {
                txtID.Text = dtgridviewListLHP.Rows[index].Cells["ID"].Value.ToString();
                txtMaLHP.Text = dtgridviewListLHP.Rows[index].Cells["MaLHP"].Value.ToString();
                txtTenLHP.Text = dtgridviewListLHP.Rows[index].Cells["TenLHP"].Value.ToString();
                dtNgayBD.Value = DateTime.Parse(dtgridviewListLHP.Rows[index].Cells["NgayBD"].Value.ToString());
                dtNgayKT.Value = DateTime.Parse(dtgridviewListLHP.Rows[index].Cells["NgayKT"].Value.ToString());
                txtSoSV.Text = dtgridviewListLHP.Rows[index].Cells["SoLuongSV"].Value.ToString();
                txtSoSVMax.Text = dtgridviewListLHP.Rows[index].Cells["SoLuongSVmax"].Value.ToString();
                txtLoaiHP.Text = dtgridviewListLHP.Rows[index].Cells["TenLoaiHP"].Value.ToString();
                txtSoTC.Text = dtgridviewListLHP.Rows[index].Cells["SoTinChi"].Value.ToString();
                //cbKhoa.Text = dtgridviewHPBB.Rows[index].Cells["tenkhoa"].Value.ToString();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDanhSachSinhVienLopHocPhan frmDanhSachSinhVienLopHocPhan = new FrmDanhSachSinhVienLopHocPhan();
            frmDanhSachSinhVienLopHocPhan.MaLHP = txtMaLHP.Text;
            frmDanhSachSinhVienLopHocPhan.TenLHP= txtTenLHP.Text;
            frmDanhSachSinhVienLopHocPhan.GiangVien = txtHoTenGV.Text;
            frmDanhSachSinhVienLopHocPhan.SoTinChi= txtSoTC.Text;
            DataTable dt = BLLQuanLyHocPhanPhuTrach.getDanhSachSinhVien(txtID.Text);
            frmDanhSachSinhVienLopHocPhan.dt = dt;
            frmDanhSachSinhVienLopHocPhan.ShowDialog();
            this.Show();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string malhp = cbFind.Text;
            if (!string.IsNullOrEmpty(malhp))
            {

                DataTable dt = BLLQuanLyHocPhanPhuTrach.FindLopHocPhan(malhp);
                if (dt.Rows.Count >= 1)
                {
                    dtgridviewListLHP.DataSource= dt;
                    MessageBox.Show("Tìm kiếm lớp học phần thành công ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy lớp học phần ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowLOpHocPhanPhuTrach();
                }
                txtID.DataBindings.Clear();
                txtMaLHP.DataBindings.Clear();
                txtTenLHP.DataBindings.Clear();
                txtSoSV.DataBindings.Clear();
                txtSoSVMax.DataBindings.Clear();
                dtNgayBD.DataBindings.Clear();
                dtNgayKT.DataBindings.Clear();
                txtLoaiHP.DataBindings.Clear();
                txtSoTC.DataBindings.Clear();
                dtgridviewListLHP.DataSource = dt;
                txtID.DataBindings.Add("Text", dt, "ID");
                txtMaLHP.DataBindings.Add("Text", dt, "MaLHP");
                txtTenLHP.DataBindings.Add("Text", dt, "TenLHP");
                txtSoSV.DataBindings.Add("Text", dt, "SoLuongSV");
                txtSoSVMax.DataBindings.Add("Text", dt, "SoLuongSVmax");
                dtNgayBD.DataBindings.Add("Value", dt, "NgayBD");
                dtNgayKT.DataBindings.Add("Value", dt, "NgayKT");
                txtLoaiHP.DataBindings.Add("Text", dt, "TenLoaiHP");
                txtSoTC.DataBindings.Add("Text", dt, "SoTinChi");
            }
            else
            {
                MessageBox.Show("Hãy chọn mã lớp học phần cần tìm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (cbFind.Text == "")
            {
                ShowLOpHocPhanPhuTrach();
            }
        }
    }
}
