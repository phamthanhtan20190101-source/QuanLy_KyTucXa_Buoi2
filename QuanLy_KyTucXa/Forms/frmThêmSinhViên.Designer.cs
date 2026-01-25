namespace QuanLy_KyTucXa.Forms
{
    partial class frmThêmSinhViên
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
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenHangSanXuat = new DataGridViewTextBoxColumn();
            btnThoat = new Button();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label1 = new Label();
            txtTenHangSanXuat = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenHangSanXuat });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 27);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(1021, 424);
            dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            // 
            // TenHangSanXuat
            // 
            TenHangSanXuat.DataPropertyName = "TenHângSanXuat";
            TenHangSanXuat.HeaderText = "TenHangSanXuat";
            TenHangSanXuat.MinimumWidth = 8;
            TenHangSanXuat.Name = "TenHangSanXuat";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(884, 107);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(120, 41);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(36, 197);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1027, 454);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách hãng sản xuất";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTenHangSanXuat);
            groupBox1.Location = new Point(36, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1027, 178);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hãng sản xuất";
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(742, 107);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(120, 41);
            btnHuyBo.TabIndex = 3;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(601, 107);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(120, 41);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(460, 107);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(120, 41);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(317, 107);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(120, 41);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(169, 107);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(120, 41);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 40);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 1;
            label1.Text = "Tên hãng sản xuất :";
            // 
            // txtTenHangSanXuat
            // 
            txtTenHangSanXuat.Location = new Point(169, 37);
            txtTenHangSanXuat.Name = "txtTenHangSanXuat";
            txtTenHangSanXuat.Size = new Size(835, 31);
            txtTenHangSanXuat.TabIndex = 2;
            // 
            // frmThêmSinhViên
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 664);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmThêmSinhViên";
            Text = "frmThêmSinhViên";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenHangSanXuat;
        private Button btnThoat;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label label1;
        private TextBox txtTenHangSanXuat;
    }
}