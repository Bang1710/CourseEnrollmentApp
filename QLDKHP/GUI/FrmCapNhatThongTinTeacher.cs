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
    public partial class FrmCapNhatThongTinTeacher : Form
    {
        CapNhatThongTinNguoiDungBLL BLLThongTinNguoiDung;
        public string tdn;
        public string ps;
        public string ltk;
        public string psn;

        public FrmCapNhatThongTinTeacher()
        {
            InitializeComponent();
            BLLThongTinNguoiDung = new CapNhatThongTinNguoiDungBLL();
        }

        private void FrmCapNhatThongTinTeacher_Load(object sender, EventArgs e)
        {
            DataTable dt = BLLThongTinNguoiDung.getThongTinCaNhanNguoiDung(tdn, ps, ltk);
            txtTenND.DataBindings.Add("Text", dt, "Hoten");
            txtKhoa.DataBindings.Add("Text", dt, "TenCV");
            txtTenDN.DataBindings.Add("Text", dt, "TenDangNhap");
            txtTenHT.DataBindings.Add("Text", dt, "HoTen");
            txtLTK.DataBindings.Add("Text", dt, "LoaiTK");
            txtPasswordCurrent.DataBindings.Add("Text", dt, "MatKhauDN");
            txtMSGV.DataBindings.Add("Text", dt, "MSGV");
            dtpickerNgaySinh.DataBindings.Add("Value", dt, "NgaySinh");
            cbGioiTinh.DataBindings.Add("Text", dt, "GioiTinh");
            txtDanToc.DataBindings.Add("Text", dt, "DanToc");
            txtTonGiao.DataBindings.Add("Text", dt, "TonGiao");
            txtSDT.DataBindings.Add("Text", dt, "SoDienThoai");
            txtCCCD.DataBindings.Add("Text", dt, "CCCD");
            txtEmail.DataBindings.Add("Text", dt, "EmailT");
            txtKh.DataBindings.Add("Text", dt, "TenKhoa");
            txtChucVu.DataBindings.Add("Text", dt, "TenCV");
            txtBangCap.DataBindings.Add("Text", dt, "TenBC");
        }

        public bool CheckPassword()
        {
            if (txtPasswordNew.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu mới !", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return false;
            }
            else if (txtPasswordNewAgain.Text == "")
            {
                MessageBox.Show("Chưa nhập lại mật khẩu mới !", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return false;
            }
            else if (txtPasswordNewAgain.Text != txtPasswordNew.Text)
            {
                MessageBox.Show("Mật khẩu mới nhập lại chưa chính xác !", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if (CheckPassword())
            {
                //ps = txtPasswordNew.Text;
                Account ac = new Account();
                ac.tendn = tdn;
                ac.mk = txtPasswordCurrent.Text;
                ac.loaitk = ltk;
                ac.psn = txtPasswordNew.Text;

                //psn = txtPasswordNew.Text;
                //if (BLLThongTinNguoiDung.UpdatePassword(tdn, ps, ltk, psn))
                if (BLLThongTinNguoiDung.UpdatePassword(ac))
                {
                    txtPasswordNew.Text = "";
                    txtPasswordNewAgain.Text = "";
                    MessageBox.Show("Đã cập nhật mật khẩu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPasswordCurrent.Text = ac.psn;
                    //ac.mk = txtPasswordNew.Text;
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, hãy thử lại sau !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        public bool CheckInforBase()
        {
            if (cbGioiTinh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn giới tính !", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return false;
            }
            if (txtDanToc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin dân tộc", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return false;
            }

            if (txtTonGiao.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin tôn giáo", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return false;
            }

            if (txtSDT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return false;
            }

            if (dtpickerNgaySinh.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin dan tộc", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return false;
            }

            if (txtBangCap.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin bằng cấp", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return false;
            }

            if (txtCCCD.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin cccd", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return false;
            }

            if (txtEmail.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin email", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnUpdateInforBase_Click(object sender, EventArgs e)
        {
            if (CheckInforBase())
            {
                GiangVien gv = new GiangVien();
                gv.msgv = int.Parse(txtMSGV.Text);
                gv.email = txtEmail.Text;
                gv.ngaysinh = dtpickerNgaySinh.Value;
                gv.dantoc = txtDanToc.Text;
                gv.tongiao = txtTonGiao.Text;
                gv.cccd = txtCCCD.Text;
                gv.sex = cbGioiTinh.Text;
                gv.sdt = txtSDT.Text;
                gv.mabc = txtBangCap.SelectedIndex + 1;
                if (BLLThongTinNguoiDung.UpdateInforBaseGiangVien(gv))
                {
                    MessageBox.Show("Đã cập nhật thông tin cơ bản thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, hãy thử lại sau !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
