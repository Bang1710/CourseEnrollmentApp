using QLDKHP.BLL;
using QLDKHP.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDKHP
{
    public partial class FrmLogin : Form
    {

        AccountBLL BLLAccount;

        public FrmLogin()
        {
            InitializeComponent();
            BLLAccount= new AccountBLL();
        }

        public void CheckAccount(string tdn, string ps, string ltk)
        {
            DataTable dt = BLLAccount.getAccount(tdn, ps, ltk);
            if (dt.Rows.Count > 0)
            {
                if(ltk == "Sinh Viên")
                {
                    this.Hide();
                    FrmStudent frmStudent = new FrmStudent();
                    frmStudent.tdn = txtTenDN.Text;
                    frmStudent.ps = txtPassword.Text;
                    frmStudent.ltk = ltk;
                    frmStudent.ShowDialog();
                    this.Show();
                } else if(ltk == "Giảng Viên")
                {
                    this.Hide();
                    FrmTeacher frmTeacher= new FrmTeacher();
                    frmTeacher.tdn = txtTenDN.Text;
                    frmTeacher.ps = txtPassword.Text;
                    frmTeacher.ltk = ltk;
                    frmTeacher.ShowDialog();
                    this.Show();
                } else
                {
                    this.Hide();
                    FrmAdmin frmAdmin = new FrmAdmin();
                    frmAdmin.tdn= txtTenDN.Text;
                    frmAdmin.ps= txtPassword.Text;
                    frmAdmin.ltk= ltk;
                    frmAdmin.ShowDialog();
                    this.Show();
                }
            } else
            {
                MessageBox.Show("Hãy kiểm tra lại thông tin và người dùng !", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        public bool checkInfoAccount()
        {
            if (string.IsNullOrEmpty(txtTenDN.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (rdSV.Checked == false && rdGV.Checked == false && rdNV.Checked == false )
            {
                MessageBox.Show("Bạn chưa chọn người dùng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }

            //if (MessageBox.Show("Bạn có thật sự muốn tắt cửa sổ này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            //{
            //    e.Cancel = true;
            //}
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tdn = txtTenDN.Text;
            string ps = txtPassword.Text;
            string ltk = "";
            if (rdSV.Checked == true)
            {
                ltk = rdSV.Text;
            }
            else if (rdGV.Checked == true)
            {
                ltk = rdGV.Text;
            }
            else
            {
                ltk = rdNV.Text;
            }
            if (checkInfoAccount())
            {
               CheckAccount(tdn, ps, ltk);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGioiThieu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGioiThieu frmGioiThieu = new FrmGioiThieu();
            frmGioiThieu.ShowDialog();
            this.Show();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
