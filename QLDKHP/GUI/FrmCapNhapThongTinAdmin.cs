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
    public partial class FrmCapNhapThongTinAdmin : Form
    {
        CapNhatThongTinNguoiDungBLL BLLThongTinNguoiDung;
        public string tdn;
        public string ps;
        public string ltk;
        public string psn;
        public FrmCapNhapThongTinAdmin()
        {
            InitializeComponent();
            BLLThongTinNguoiDung = new CapNhatThongTinNguoiDungBLL();
        }

        private void FrmCapNhapThongTinAdmin_Load(object sender, EventArgs e)
        {
            DataTable dt = BLLThongTinNguoiDung.getThongTinCaNhanNguoiDung(tdn, ps, ltk);
            txtTenND.DataBindings.Add("Text", dt, "Hoten");
            txtCV.DataBindings.Add("Text", dt, "TenCV");
            txtTenDN.DataBindings.Add("Text", dt, "TenDangNhap");
            txtTenHT.DataBindings.Add("Text", dt, "Hoten");
            txtLTK.DataBindings.Add("Text", dt, "LoaiTK");
            txtPasswordCurrent.DataBindings.Add("Text", dt, "MatKhauDN");
            txtMSNV.DataBindings.Add("Text", dt, "MSNV");
            dtpickerNgaySinh.DataBindings.Add("Value", dt, "NgaySinh");
            cbGioiTinh.DataBindings.Add("Text", dt, "GioiTinh");
            txtDanToc.DataBindings.Add("Text", dt, "DanToc");
            txtTonGiao.DataBindings.Add("Text", dt, "TonGiao");
            txtSDT.DataBindings.Add("Text", dt, "SoDienThoai");
            txtCCCD.DataBindings.Add("Text", dt, "CCCD");
            dtpickerNgayVaoLam.DataBindings.Add("Value", dt, dataMember: "NgayLamViec");
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
                if(BLLThongTinNguoiDung.UpdatePassword(ac))
                {
                    txtPasswordNew.Text = "";
                    txtPasswordNewAgain.Text = "";
                    MessageBox.Show("Đã cập nhật mật khẩu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPasswordCurrent.Text = ac.psn;
                    //ac.mk = txtPasswordNew.Text;
                } else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, hãy thử lại sau !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }


        }

        public bool checkInforBase()
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

            if (txtCCCD.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin cccd!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return false;
            }

            if (txtTonGiao.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin tôn giáo", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return false;
            }

            if(txtSDT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return false;
            }

            if (dtpickerNgaySinh.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin dan tộc", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return false;
            }

            if (dtpickerNgayVaoLam.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin dan tộc", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnUpdateInforBase_Click(object sender, EventArgs e)
        {
            if (checkInforBase())
            {
                NhanVien nv = new NhanVien();
                nv.msnv = int.Parse(txtMSNV.Text);
                nv.dantoc = txtDanToc.Text;
                nv.tongiao = txtTonGiao.Text;
                nv.sex = cbGioiTinh.Text;
                nv.sdt = txtSDT.Text;
                nv.cccd = txtCCCD.Text;
                nv.ngaysinh = dtpickerNgaySinh.Value;
                nv.ngaylamviec = dtpickerNgayVaoLam.Value;
                if (BLLThongTinNguoiDung.UpdateInforBase(nv))
                {
                    MessageBox.Show("Đã cập nhật thông tin cơ bản thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);    
                } else {
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
