namespace QLDKHP.GUI
{
    partial class FrmTraCuuLopHocPhan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.CbGiaTri = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbHinhThuc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgridviewListLHP = new System.Windows.Forms.DataGridView();
            this.MaLHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongSVmax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMaLHP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTenLHP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoSV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoSVMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtNgayBD = new System.Windows.Forms.DateTimePicker();
            this.dtNgayKT = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSoTC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLoaiHP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridviewListLHP)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.CbGiaTri);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbHinhThuc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(653, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra cứu";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(425, 166);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(197, 44);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // CbGiaTri
            // 
            this.CbGiaTri.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CbGiaTri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(104)))));
            this.CbGiaTri.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbGiaTri.ForeColor = System.Drawing.SystemColors.Window;
            this.CbGiaTri.FormattingEnabled = true;
            this.CbGiaTri.Location = new System.Drawing.Point(28, 171);
            this.CbGiaTri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbGiaTri.Name = "CbGiaTri";
            this.CbGiaTri.Size = new System.Drawing.Size(369, 33);
            this.CbGiaTri.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(104)))));
            this.label2.Location = new System.Drawing.Point(23, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn hoặc nhập giá trị:";
            // 
            // cbHinhThuc
            // 
            this.cbHinhThuc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbHinhThuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(104)))));
            this.cbHinhThuc.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHinhThuc.ForeColor = System.Drawing.SystemColors.Window;
            this.cbHinhThuc.FormattingEnabled = true;
            this.cbHinhThuc.Items.AddRange(new object[] {
            "Ngành học",
            "Chương trình đào tạo",
            "Loại học phần",
            "Khoa"});
            this.cbHinhThuc.Location = new System.Drawing.Point(28, 75);
            this.cbHinhThuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbHinhThuc.Name = "cbHinhThuc";
            this.cbHinhThuc.Size = new System.Drawing.Size(369, 33);
            this.cbHinhThuc.TabIndex = 1;
            this.cbHinhThuc.SelectedIndexChanged += new System.EventHandler(this.cbHinhThuc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(104)))));
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn hình thức tìm kiếm:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgridviewListLHP);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.groupBox2.Location = new System.Drawing.Point(677, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1309, 630);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách lớp học phần";
            // 
            // dtgridviewListLHP
            // 
            this.dtgridviewListLHP.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgridviewListLHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridviewListLHP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLHP,
            this.TenLHP,
            this.TenLoaiHP,
            this.SoTinChi,
            this.NgayBD,
            this.NgayKT,
            this.SoLuongSV,
            this.SoLuongSVmax});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgridviewListLHP.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgridviewListLHP.Location = new System.Drawing.Point(8, 30);
            this.dtgridviewListLHP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgridviewListLHP.Name = "dtgridviewListLHP";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgridviewListLHP.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgridviewListLHP.RowHeadersWidth = 49;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(104)))));
            this.dtgridviewListLHP.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgridviewListLHP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgridviewListLHP.Size = new System.Drawing.Size(972, 592);
            this.dtgridviewListLHP.TabIndex = 0;
            this.dtgridviewListLHP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridviewListLHP_CellClick);
            // 
            // MaLHP
            // 
            this.MaLHP.DataPropertyName = "MaLHP";
            this.MaLHP.HeaderText = "Mã LHP";
            this.MaLHP.MinimumWidth = 6;
            this.MaLHP.Name = "MaLHP";
            this.MaLHP.Width = 125;
            // 
            // TenLHP
            // 
            this.TenLHP.DataPropertyName = "TenLHP";
            this.TenLHP.HeaderText = "Tên LHP";
            this.TenLHP.MinimumWidth = 6;
            this.TenLHP.Name = "TenLHP";
            this.TenLHP.Width = 250;
            // 
            // TenLoaiHP
            // 
            this.TenLoaiHP.DataPropertyName = "TenLoaiHP";
            this.TenLoaiHP.HeaderText = "Loại HP";
            this.TenLoaiHP.MinimumWidth = 6;
            this.TenLoaiHP.Name = "TenLoaiHP";
            this.TenLoaiHP.Width = 150;
            // 
            // SoTinChi
            // 
            this.SoTinChi.DataPropertyName = "SoTinChi";
            this.SoTinChi.HeaderText = "Số tín chỉ";
            this.SoTinChi.MinimumWidth = 6;
            this.SoTinChi.Name = "SoTinChi";
            this.SoTinChi.Width = 125;
            // 
            // NgayBD
            // 
            this.NgayBD.DataPropertyName = "NgayBD";
            this.NgayBD.HeaderText = "Ngày BĐ";
            this.NgayBD.MinimumWidth = 6;
            this.NgayBD.Name = "NgayBD";
            this.NgayBD.Width = 125;
            // 
            // NgayKT
            // 
            this.NgayKT.DataPropertyName = "NgayKT";
            this.NgayKT.HeaderText = "Ngày KT";
            this.NgayKT.MinimumWidth = 6;
            this.NgayKT.Name = "NgayKT";
            this.NgayKT.Width = 125;
            // 
            // SoLuongSV
            // 
            this.SoLuongSV.DataPropertyName = "SoLuongSV";
            this.SoLuongSV.HeaderText = "Số SV hiện tại";
            this.SoLuongSV.MinimumWidth = 6;
            this.SoLuongSV.Name = "SoLuongSV";
            this.SoLuongSV.Visible = false;
            this.SoLuongSV.Width = 125;
            // 
            // SoLuongSVmax
            // 
            this.SoLuongSVmax.DataPropertyName = "SoLuongSVmax";
            this.SoLuongSVmax.HeaderText = "Số SV tối đa";
            this.SoLuongSVmax.MinimumWidth = 6;
            this.SoLuongSVmax.Name = "SoLuongSVmax";
            this.SoLuongSVmax.Visible = false;
            this.SoLuongSVmax.Width = 90;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(104)))));
            this.label11.Location = new System.Drawing.Point(15, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 26);
            this.label11.TabIndex = 2;
            this.label11.Text = "Mã LHP:";
            // 
            // txtMaLHP
            // 
            this.txtMaLHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaLHP.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLHP.Location = new System.Drawing.Point(20, 71);
            this.txtMaLHP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaLHP.Name = "txtMaLHP";
            this.txtMaLHP.ReadOnly = true;
            this.txtMaLHP.Size = new System.Drawing.Size(269, 32);
            this.txtMaLHP.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(104)))));
            this.label10.Location = new System.Drawing.Point(15, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 26);
            this.label10.TabIndex = 4;
            this.label10.Text = "Tên LHP:";
            // 
            // txtTenLHP
            // 
            this.txtTenLHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenLHP.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLHP.Location = new System.Drawing.Point(20, 151);
            this.txtTenLHP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenLHP.Name = "txtTenLHP";
            this.txtTenLHP.ReadOnly = true;
            this.txtTenLHP.Size = new System.Drawing.Size(613, 32);
            this.txtTenLHP.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(104)))));
            this.label9.Location = new System.Drawing.Point(15, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 26);
            this.label9.TabIndex = 6;
            this.label9.Text = "Số SV hiện tại:";
            // 
            // txtSoSV
            // 
            this.txtSoSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoSV.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoSV.Location = new System.Drawing.Point(20, 229);
            this.txtSoSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoSV.Name = "txtSoSV";
            this.txtSoSV.ReadOnly = true;
            this.txtSoSV.Size = new System.Drawing.Size(155, 32);
            this.txtSoSV.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(104)))));
            this.label8.Location = new System.Drawing.Point(237, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 26);
            this.label8.TabIndex = 8;
            this.label8.Text = "Số SV tối đa:";
            // 
            // txtSoSVMax
            // 
            this.txtSoSVMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoSVMax.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoSVMax.Location = new System.Drawing.Point(243, 229);
            this.txtSoSVMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoSVMax.Name = "txtSoSVMax";
            this.txtSoSVMax.ReadOnly = true;
            this.txtSoSVMax.Size = new System.Drawing.Size(154, 32);
            this.txtSoSVMax.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(104)))));
            this.label5.Location = new System.Drawing.Point(16, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 26);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ngày bắt đầu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(104)))));
            this.label6.Location = new System.Drawing.Point(340, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 26);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ngày kết thúc:";
            // 
            // dtNgayBD
            // 
            this.dtNgayBD.CalendarFont = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayBD.CalendarForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtNgayBD.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(104)))));
            this.dtNgayBD.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtNgayBD.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayBD.Location = new System.Drawing.Point(20, 320);
            this.dtNgayBD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtNgayBD.Name = "dtNgayBD";
            this.dtNgayBD.Size = new System.Drawing.Size(268, 32);
            this.dtNgayBD.TabIndex = 19;
            // 
            // dtNgayKT
            // 
            this.dtNgayKT.CalendarForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtNgayKT.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(104)))));
            this.dtNgayKT.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayKT.Location = new System.Drawing.Point(349, 319);
            this.dtNgayKT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtNgayKT.Name = "dtNgayKT";
            this.dtNgayKT.Size = new System.Drawing.Size(283, 32);
            this.dtNgayKT.TabIndex = 20;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSoTC);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtLoaiHP);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dtNgayKT);
            this.groupBox3.Controls.Add(this.dtNgayBD);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtSoSVMax);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtSoSV);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtTenLHP);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtMaLHP);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.groupBox3.Location = new System.Drawing.Point(17, 262);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(653, 383);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin lớp học phần";
            // 
            // txtSoTC
            // 
            this.txtSoTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoTC.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTC.Location = new System.Drawing.Point(455, 229);
            this.txtSoTC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoTC.Name = "txtSoTC";
            this.txtSoTC.ReadOnly = true;
            this.txtSoTC.Size = new System.Drawing.Size(178, 32);
            this.txtSoTC.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(104)))));
            this.label4.Location = new System.Drawing.Point(449, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 26);
            this.label4.TabIndex = 23;
            this.label4.Text = "Số tín chỉ:";
            // 
            // txtLoaiHP
            // 
            this.txtLoaiHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoaiHP.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiHP.Location = new System.Drawing.Point(349, 70);
            this.txtLoaiHP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLoaiHP.Name = "txtLoaiHP";
            this.txtLoaiHP.ReadOnly = true;
            this.txtLoaiHP.Size = new System.Drawing.Size(283, 32);
            this.txtLoaiHP.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(104)))));
            this.label3.Location = new System.Drawing.Point(344, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 26);
            this.label3.TabIndex = 21;
            this.label3.Text = "Loại HP:";
            // 
            // FrmTraCuuLopHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 661);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmTraCuuLopHocPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu lớp học phần";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridviewListLHP)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox CbGiaTri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbHinhThuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgridviewListLHP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMaLHP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTenLHP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoSV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoSVMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtNgayBD;
        private System.Windows.Forms.DateTimePicker dtNgayKT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSoTC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLoaiHP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongSVmax;
    }
}