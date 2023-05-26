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
    public partial class FrmTraCuuLopHocPhan : Form
    {
        TraCuuLopHocPhanBLL BLLTraCuuLopHocPhan;
        public FrmTraCuuLopHocPhan()
        {
            InitializeComponent();
            BLLTraCuuLopHocPhan = new TraCuuLopHocPhanBLL();
        }

        private void cbHinhThuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cbHinhThuc.SelectedIndex;
            CbGiaTri.DataBindings.Clear();
            CbGiaTri.DataSource = null;
            DataTable dt = BLLTraCuuLopHocPhan.getThongTinHinhThucTimKiem(i);
            string temp = "";
            switch (i)
            {   
                case 0:
                    temp = "TenNH";
                    //CbGiaTri.DataSource = dt;
                    break;
                case 1:
                    temp = "TenCTDT";
                    //CbGiaTri.DataSource = dt;
                    break;
                case 2:
                    temp = "TenLoaiHP";
                    //CbGiaTri.DataSource = dt;
                    break;
                case 3:
                    temp = "TenKhoa";
                    //CbGiaTri.DataSource = dt;
                    break;
                default:
                    break;
            }
            CbGiaTri.DisplayMember = temp;
            CbGiaTri.DataSource = dt;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            int i = cbHinhThuc.SelectedIndex;
            int j = CbGiaTri.SelectedIndex + 1;
            //MessageBox.Show(cbHinhThuc.Text + i.ToString());
            //MessageBox.Show(CbGiaTri.Text + j.ToString());
            if (cbHinhThuc.Text == "" || CbGiaTri.Text == "" || j == -1)
            {
                MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                ShowListLopHocPhan(i, j);
                MessageBox.Show("Đà tìm thấy thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        public void ShowListLopHocPhan(int i, int j)
        {
            DataTable dt = BLLTraCuuLopHocPhan.getListLopHocPhan(i, j);
            dtgridviewListLHP.DataSource = dt;
        }

        private void dtgridviewListLHP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dtgridviewListLHP.Rows.Count - 1)
            {
                txtMaLHP.Text = dtgridviewListLHP.Rows[index].Cells["MaLHP"].Value.ToString();
                txtLoaiHP.Text = dtgridviewListLHP.Rows[index].Cells["TenLoaiHP"].Value.ToString();
                txtTenLHP.Text = dtgridviewListLHP.Rows[index].Cells["TenLHP"].Value.ToString();
                dtNgayBD.Value = DateTime.Parse(dtgridviewListLHP.Rows[index].Cells["NgayBD"].Value.ToString());
                dtNgayKT.Value = DateTime.Parse(dtgridviewListLHP.Rows[index].Cells["NgayKT"].Value.ToString());
                txtSoSV.Text = dtgridviewListLHP.Rows[index].Cells["SoLuongSV"].Value.ToString();
                txtSoSVMax.Text = dtgridviewListLHP.Rows[index].Cells["SoLuongSVmax"].Value.ToString();
                txtSoTC.Text = dtgridviewListLHP.Rows[index].Cells["SoTinChi"].Value.ToString();

                //cbKhoa.Text = dtgridviewHPBB.Rows[index].Cells["tenkhoa"].Value.ToString();
            }
        }
    }
}
