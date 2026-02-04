namespace QuanLy_KyTucXa.Forms
{
    partial class frmToaNha
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
            groupBox1 = new GroupBox();
            dataGridViewToaA = new DataGridView();
            MaPhong = new DataGridViewTextBoxColumn();
            TienDienNuoc = new DataGridViewTextBoxColumn();
            SoLuongDangO = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            dataGridViewToaD = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            dataGridViewToaB = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            groupBox4 = new GroupBox();
            dataGridViewToaC = new DataGridView();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox5 = new GroupBox();
            button1 = new Button();
            txtMaPhong = new TextBox();
            btnQuayLai = new Button();
            txtGiaPhong = new TextBox();
            label2 = new Label();
            cobLoaiPhong = new ComboBox();
            cobToaNha = new ComboBox();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            btnTimKiem = new Button();
            btnHuyBo = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewToaA).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewToaD).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewToaB).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewToaC).BeginInit();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewToaA);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(462, 327);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tòa nhà A";
            // 
            // dataGridViewToaA
            // 
            dataGridViewToaA.AllowUserToAddRows = false;
            dataGridViewToaA.AllowUserToDeleteRows = false;
            dataGridViewToaA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewToaA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewToaA.Columns.AddRange(new DataGridViewColumn[] { MaPhong, TienDienNuoc, SoLuongDangO });
            dataGridViewToaA.Dock = DockStyle.Fill;
            dataGridViewToaA.Location = new Point(3, 27);
            dataGridViewToaA.MultiSelect = false;
            dataGridViewToaA.Name = "dataGridViewToaA";
            dataGridViewToaA.RowHeadersWidth = 62;
            dataGridViewToaA.Size = new Size(456, 297);
            dataGridViewToaA.TabIndex = 0;
            dataGridViewToaA.CellClick += dataGridViewToaA_CellClick;
            // 
            // MaPhong
            // 
            MaPhong.DataPropertyName = "MaPhong";
            MaPhong.HeaderText = "Mã Phòng";
            MaPhong.MinimumWidth = 8;
            MaPhong.Name = "MaPhong";
            // 
            // TienDienNuoc
            // 
            TienDienNuoc.DataPropertyName = "TienDienNuoc";
            TienDienNuoc.HeaderText = "Tiền Điện Nước";
            TienDienNuoc.MinimumWidth = 8;
            TienDienNuoc.Name = "TienDienNuoc";
            // 
            // SoLuongDangO
            // 
            SoLuongDangO.DataPropertyName = "SoLuongDangO";
            SoLuongDangO.HeaderText = "Số Lượng";
            SoLuongDangO.MinimumWidth = 8;
            SoLuongDangO.Name = "SoLuongDangO";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewToaD);
            groupBox2.Location = new Point(1052, 382);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(462, 332);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tòa nhà D";
            // 
            // dataGridViewToaD
            // 
            dataGridViewToaD.AllowUserToAddRows = false;
            dataGridViewToaD.AllowUserToDeleteRows = false;
            dataGridViewToaD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewToaD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewToaD.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9 });
            dataGridViewToaD.Dock = DockStyle.Fill;
            dataGridViewToaD.Location = new Point(3, 27);
            dataGridViewToaD.MultiSelect = false;
            dataGridViewToaD.Name = "dataGridViewToaD";
            dataGridViewToaD.RowHeadersWidth = 62;
            dataGridViewToaD.Size = new Size(456, 302);
            dataGridViewToaD.TabIndex = 1;
            dataGridViewToaD.CellClick += dataGridViewToaD_CellClick;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "MaPhong";
            dataGridViewTextBoxColumn7.HeaderText = "Mã Phòng";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "TienDienNuoc";
            dataGridViewTextBoxColumn8.HeaderText = "Tiền Điện Nước";
            dataGridViewTextBoxColumn8.MinimumWidth = 8;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "SoLuongDangO";
            dataGridViewTextBoxColumn9.HeaderText = "Số Lượng";
            dataGridViewTextBoxColumn9.MinimumWidth = 8;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridViewToaB);
            groupBox3.Location = new Point(12, 368);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(462, 346);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tòa nhà B";
            // 
            // dataGridViewToaB
            // 
            dataGridViewToaB.AllowUserToAddRows = false;
            dataGridViewToaB.AllowUserToDeleteRows = false;
            dataGridViewToaB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewToaB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewToaB.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridViewToaB.Dock = DockStyle.Fill;
            dataGridViewToaB.Location = new Point(3, 27);
            dataGridViewToaB.MultiSelect = false;
            dataGridViewToaB.Name = "dataGridViewToaB";
            dataGridViewToaB.RowHeadersWidth = 62;
            dataGridViewToaB.Size = new Size(456, 316);
            dataGridViewToaB.TabIndex = 1;
            dataGridViewToaB.CellClick += dataGridViewToaB_CellClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "MaPhong";
            dataGridViewTextBoxColumn1.HeaderText = "Mã Phòng";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "TienDienNuoc";
            dataGridViewTextBoxColumn2.HeaderText = "Tiền Điện Nước";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "SoLuongDangO";
            dataGridViewTextBoxColumn3.HeaderText = "Số Lượng";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridViewToaC);
            groupBox4.Location = new Point(527, 368);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(462, 346);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tòa nhà C";
            // 
            // dataGridViewToaC
            // 
            dataGridViewToaC.AllowUserToAddRows = false;
            dataGridViewToaC.AllowUserToDeleteRows = false;
            dataGridViewToaC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewToaC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewToaC.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridViewToaC.Dock = DockStyle.Fill;
            dataGridViewToaC.Location = new Point(3, 27);
            dataGridViewToaC.MultiSelect = false;
            dataGridViewToaC.Name = "dataGridViewToaC";
            dataGridViewToaC.RowHeadersWidth = 62;
            dataGridViewToaC.Size = new Size(456, 316);
            dataGridViewToaC.TabIndex = 1;
            dataGridViewToaC.CellClick += dataGridViewToaC_CellClick;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "MaPhong";
            dataGridViewTextBoxColumn4.HeaderText = "Mã Phòng";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "TienDienNuoc";
            dataGridViewTextBoxColumn5.HeaderText = "Tiền Điện Nước";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "SoLuongDangO";
            dataGridViewTextBoxColumn6.HeaderText = "Số Lượng";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 42);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 1;
            label1.Text = "Tòa Nhà :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 187);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 5;
            label3.Text = "Loại phòng :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 113);
            label4.Name = "label4";
            label4.Size = new Size(104, 25);
            label4.TabIndex = 7;
            label4.Text = "Mã phòng :";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button1);
            groupBox5.Controls.Add(txtMaPhong);
            groupBox5.Controls.Add(btnQuayLai);
            groupBox5.Controls.Add(txtGiaPhong);
            groupBox5.Controls.Add(label2);
            groupBox5.Controls.Add(cobLoaiPhong);
            groupBox5.Controls.Add(cobToaNha);
            groupBox5.Controls.Add(btnLuu);
            groupBox5.Controls.Add(btnSua);
            groupBox5.Controls.Add(btnXoa);
            groupBox5.Controls.Add(btnThem);
            groupBox5.Controls.Add(btnTimKiem);
            groupBox5.Controls.Add(btnHuyBo);
            groupBox5.Controls.Add(label1);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(label3);
            groupBox5.Location = new Point(527, 12);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(987, 327);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "Chức năng";
            // 
            // button1
            // 
            button1.Location = new Point(823, -97);
            button1.Name = "button1";
            button1.Size = new Size(10, 49);
            button1.TabIndex = 17;
            button1.Text = "Quay lại";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtMaPhong
            // 
            txtMaPhong.Location = new Point(143, 113);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(182, 31);
            txtMaPhong.TabIndex = 16;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(823, 42);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(144, 49);
            btnQuayLai.TabIndex = 15;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            // 
            // txtGiaPhong
            // 
            txtGiaPhong.Location = new Point(143, 252);
            txtGiaPhong.Name = "txtGiaPhong";
            txtGiaPhong.Size = new Size(182, 31);
            txtGiaPhong.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 255);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 13;
            label2.Text = "Giá phòng :";
            // 
            // cobLoaiPhong
            // 
            cobLoaiPhong.Enabled = false;
            cobLoaiPhong.FormattingEnabled = true;
            cobLoaiPhong.Items.AddRange(new object[] { "4 Người ", "6 Người" });
            cobLoaiPhong.Location = new Point(143, 184);
            cobLoaiPhong.Name = "cobLoaiPhong";
            cobLoaiPhong.Size = new Size(182, 33);
            cobLoaiPhong.TabIndex = 12;
            cobLoaiPhong.Text = "Chọn loại phòng";
            // 
            // cobToaNha
            // 
            cobToaNha.Enabled = false;
            cobToaNha.FormattingEnabled = true;
            cobToaNha.Items.AddRange(new object[] { "Tòa A (Nam)", "Tòa B (Nữ)", "Tòa C (Nam)", "Tòa D (Nữ)" });
            cobToaNha.Location = new Point(143, 42);
            cobToaNha.Name = "cobToaNha";
            cobToaNha.Size = new Size(182, 33);
            cobToaNha.TabIndex = 10;
            cobToaNha.Text = "Chọn Tòa nhà";
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(615, 113);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(144, 49);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(395, 113);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(144, 49);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(395, 187);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(144, 49);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(395, 42);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(144, 49);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(615, 187);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(144, 49);
            btnTimKiem.TabIndex = 9;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(615, 42);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(144, 49);
            btnHuyBo.TabIndex = 9;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // frmToaNha
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1526, 723);
            Controls.Add(groupBox5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "frmToaNha";
            Text = "frmToaNha";
            Load += frmToaNha_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewToaA).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewToaD).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewToaB).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewToaC).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label1;
        private Label label3;
        private Label label4;
        private GroupBox groupBox5;
        private ComboBox cobToaNha;
        private Button btnSua;
        private Button btnThem;
        private Button btnTimKiem;
        private Button btnHuyBo;
        private ComboBox cobLoaiPhong;
        private Label label2;
        private Button btnLuu;
        private Button btnXoa;
        private TextBox txtGiaPhong;
        private DataGridView dataGridViewToaA;
        private Button btnQuayLai;
        private DataGridViewTextBoxColumn MaPhong;
        private DataGridViewTextBoxColumn TienDienNuoc;
        private DataGridViewTextBoxColumn SoLuongDangO;
        private DataGridView dataGridViewToaD;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridView dataGridViewToaB;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridView dataGridViewToaC;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Button button1;
        private TextBox txtMaPhong;
    }
}