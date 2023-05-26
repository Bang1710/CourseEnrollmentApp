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
    public partial class FrmDangKyMonHoc : Form
    {
        DangKyMonHocBLL BLLDangKyMonHoc;
        public string tdn;
        public string ps;
        //public string ltk;
        public FrmDangKyMonHoc()
        {
            InitializeComponent();
            BLLDangKyMonHoc = new DangKyMonHocBLL();
        }

        public void ShowListMonHoc()
        {
            DataTable dt = BLLDangKyMonHoc.getListMonHoc();
            dtgridviewListMonHoc.DataSource= dt;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            PhieuDangKyMonHoc pk = new PhieuDangKyMonHoc();
            pk.mamh = int.Parse(txtMaMH.Text);
            if (BLLDangKyMonHoc.deleteLopDangKyHocPhan(pk))
            {
                DataTable dt = BLLDangKyMonHoc.getPhieDangKyMonHoc(Int32.Parse(txtID_GV.Text));
                dtgridviewPhieuDangKyMonHoc.DataSource = dt;
                txtMaMH.Text = "";
                txtSoTC.Text = "";
                txtTenMH.Text = "";
                txtTenKhoa.Text = "";
                txtSoLDK.Text = "";
                txtSoLHT.Text = "";
                 MessageBox.Show("Bạn đã xóa môn học này thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Đã xảy ra lỗi, hãy thử lại sau !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void getMaMH()
        {
            DataTable MaMonHoc = BLLDangKyMonHoc.getMaMonHoc();
            cbFind.DisplayMember = "MaMH";
            cbFind.DataSource = MaMonHoc;
        }

        private void FrmDangKyMonHoc_Load(object sender, EventArgs e)
        {
            DataTable dt = BLLDangKyMonHoc.getThongTinGiangVien(tdn, ps);
            txtID_GV.DataBindings.Add("Text", dt, "id_gv");
            txtMSGV.DataBindings.Add("Text", dt, "MSGV");
            txtHoTenGV.DataBindings.Add("Text", dt, "HoTen");
            txtCV.DataBindings.Add("Text", dt, "TenCV");
            txtKhoa.DataBindings.Add("Text", dt, "TenKhoa");

            ShowListMonHoc();
            ShowPhieuDangKyMonHoc();
            getMaMH();

        }

        public void getSoLHT(int id)
        {
            DataTable dt = BLLDangKyMonHoc.getSoLopHienTai(id);
            txtSoLHT.DataBindings.Clear();
            txtSoLHT.DataBindings.Add("Text", dt, "SLL");
        }

        private void dtgridviewListMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dtgridviewListMonHoc.Rows.Count - 1)
            {
                txtMaMH.Text = dtgridviewListMonHoc.Rows[index].Cells["MaMH"].Value.ToString();
                txtSoTC.Text = dtgridviewListMonHoc.Rows[index].Cells["SoTinChi"].Value.ToString();
                txtTenMH.Text = dtgridviewListMonHoc.Rows[index].Cells["TenMH"].Value.ToString();
                txtTenKhoa.Text = dtgridviewListMonHoc.Rows[index].Cells["TenKhoa"].Value.ToString();
                int id = Int32.Parse(txtMaMH.Text);
                getSoLHT(id);
                txtSoLDK.Text = "";
            }
        }

        public bool checkDataDangKy()
        {
            if (txtMaMH.Text == "")
            {
                MessageBox.Show("Bạn chưa điền thông tin mã môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtSoTC.Text == "")
            {
                MessageBox.Show("Bạn chưa điền thông tin số tín chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtTenMH.Text == "")
            {
                MessageBox.Show("Bạn chưa điền thông tin tên khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (txtSoLHT.Text == "")
            {
                MessageBox.Show("Bạn chưa điền thông tin số lớp hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if(txtSoLDK.Text == "")
            {
                MessageBox.Show("Bạn chưa điền thông tin số lớp đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (Int32.Parse(txtSoLDK.Text) > Int32.Parse(txtSoLHT.Text))
            {
                MessageBox.Show("Số lớp đăng ký không được nhiều hơn số lớp hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }


            return true;
        }

        public void ShowPhieuDangKyMonHoc()
        {
            DataTable dt = BLLDangKyMonHoc.getPhieDangKyMonHoc(Int32.Parse(txtID_GV.Text));
            dtgridviewPhieuDangKyMonHoc.DataSource= dt;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (checkDataDangKy())
            {
                PhieuDangKyMonHoc pk = new PhieuDangKyMonHoc();
                pk.mamh = Int32.Parse(txtMaMH.Text);
                pk.msgv = Int32.Parse(txtID_GV.Text);
                pk.slht = Int32.Parse(txtSoLHT.Text);
                pk.sldk = Int32.Parse(txtSoLDK.Text);
                if (BLLDangKyMonHoc.InsertDangKyMonHoc(pk))
                {
                    ShowPhieuDangKyMonHoc();
                    MessageBox.Show("Đã đăng ký thành công môn học này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoLDK.Text = "";
                } else
                {
                    MessageBox.Show("Môn học này đã đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        int id;

        private void dtgridviewPhieuDangKyMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dtgridviewPhieuDangKyMonHoc.Rows.Count - 1)
            {
                id = Int32.Parse(dtgridviewPhieuDangKyMonHoc.Rows[index].Cells["MaPDKMH"].Value.ToString());
                txtMaMH.Text = dtgridviewPhieuDangKyMonHoc.Rows[index].Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                txtSoTC.Text = dtgridviewPhieuDangKyMonHoc.Rows[index].Cells["dataGridViewTextBoxColumn2"].Value.ToString();
                txtTenMH.Text = dtgridviewPhieuDangKyMonHoc.Rows[index].Cells["dataGridViewTextBoxColumn3"].Value.ToString();
                txtTenKhoa.Text = dtgridviewPhieuDangKyMonHoc.Rows[index].Cells["dataGridViewTextBoxColumn4"].Value.ToString();
                txtSoLHT.Text = dtgridviewPhieuDangKyMonHoc.Rows[index].Cells["SoLopHienTai"].Value.ToString();
                txtSoLDK.Text = dtgridviewPhieuDangKyMonHoc.Rows[index].Cells["SoLopDangKy"].Value.ToString();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string mamh = cbFind.Text;
            if (!string.IsNullOrEmpty(mamh))
            {
                DataTable dt = BLLDangKyMonHoc.FindMonHoc(mamh);
                if (dt.Rows.Count >= 1)
                {
                    dtgridviewListMonHoc.DataSource = dt;
                    MessageBox.Show("Tìm kiếm môn học thành công ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy môn học ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowListMonHoc();
                }

            }
                if (cbFind.Text == "")
                {
                    ShowListMonHoc();
                }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkDataDangKy())
            {
                PhieuDangKyMonHoc pk = new PhieuDangKyMonHoc();
                pk.id_pdkmh = id;
                pk.mamh = Int32.Parse(txtMaMH.Text);
                pk.msgv = Int32.Parse(txtID_GV.Text);
                pk.slht = Int32.Parse(txtSoLHT.Text);
                pk.sldk = Int32.Parse(txtSoLDK.Text);
               
                if (BLLDangKyMonHoc.UpdatePhieuDangKyMonHoc(pk))
                {
                    txtMaMH.Text = "";
                    txtSoTC.Text = "";
                    txtTenMH.Text = "";
                    txtTenKhoa.Text = "";
                    txtSoLDK.Text = "";
                    txtSoLHT.Text = "";
                    MessageBox.Show("Đã cập nhật thông tin đăng ký môn học thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowPhieuDangKyMonHoc();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, hãy thử lại sau !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDangKyMonHoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn tắt cửa sổ này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
