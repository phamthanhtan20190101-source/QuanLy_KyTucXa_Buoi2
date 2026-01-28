using QuanLy_KyTucXa.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_KyTucXa.Forms
{
    public partial class frmThemSinhVien : Form
    {
        QLKTXDbContext context = new QLKTXDbContext();

        // 2. Các biến trạng thái
        bool xuLyThem = false; // Cờ kiểm tra: True = Đang thêm, False = Đang sửa
        string currentMSSV = ""; // Lưu MSSV đang chọn để xử lý
        public frmThemSinhVien()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            // Nhóm 1: Các nút thao tác dữ liệu (Lưu/Hủy) và ô nhập liệu -> Bật khi đang Thêm/Sửa
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            // Các ô nhập liệu
            txtmssv.Enabled = giaTri;
            txthoten.Enabled = giaTri;
            txtlop.Enabled = giaTri;
            txtsdt.Enabled = giaTri;
            txtquequan.Enabled = giaTri;
            cobgioitinh.Enabled = giaTri;
            cobmaphong.Enabled = giaTri;
            datengaysinh.Enabled = giaTri;
            datengayvao.Enabled = giaTri;

            // Nhóm 2: Các nút chức năng chính (Thêm/Sửa/Xóa) -> Ẩn khi đang nhập liệu
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmThemSinhVien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false); // Khóa các ô nhập liệu
            LoadComboboxPhong();   // Tải danh sách phòng vào ComboBox
            LoadData();            // Tải danh sách sinh viên lên lưới
        }

        private void LoadData()
        {
            try
            {
                // Lấy danh sách SV và sắp xếp theo tên
                List<SinhVien> listSV = context.SinhViens.OrderBy(sv => sv.HoTen).ToList();
                dataGridView.DataSource = listSV;

                // Ẩn cột quan hệ (Phòng) nếu nó hiện ra gây rối mắt
                if (dataGridView.Columns["Phong"] != null)
                    dataGridView.Columns["Phong"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        // Hàm tải danh sách Phòng vào ComboBox để chọn
        private void LoadComboboxPhong()
        {
            var listPhong = context.Phongs
         .Select(p => new
         {
             p.MaPhong,

             TenToaNha = p.ToaNha.TenToaNha
         })
         .ToList();

            cobmaphong.DataSource = listPhong;
            cobmaphong.DisplayMember = "MaPhong";
            cobmaphong.ValueMember = "MaPhong";
            cobmaphong.SelectedIndex = -1;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                // Lấy dữ liệu từ dòng click vào gán lên các ô
                txtmssv.Text = row.Cells["MSSV"].Value.ToString();
                currentMSSV = txtmssv.Text; // Lưu lại MSSV để dùng cho chức năng Sửa/Xóa

                txthoten.Text = row.Cells["HoTen"].Value.ToString();
                txtlop.Text = row.Cells["Lop"].Value?.ToString();
                txtsdt.Text = row.Cells["SDT"].Value?.ToString();
                txtquequan.Text = row.Cells["QueQuan"].Value?.ToString();
                cobgioitinh.Text = row.Cells["GioiTinh"].Value?.ToString();

                // Xử lý ngày tháng (tránh lỗi nếu null)
                if (row.Cells["NgaySinh"].Value != null)
                    datengaysinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);

                if (row.Cells["NgayVao"].Value != null)
                    datengayvao.Value = Convert.ToDateTime(row.Cells["NgayVao"].Value);

                // Chọn phòng tương ứng trong ComboBox
                cobmaphong.SelectedValue = row.Cells["MaPhong"].Value?.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;     // Đặt cờ là Đang Thêm
            BatTatChucNang(true); // Mở khóa nhập liệu

            // Xóa trắng các ô

            txtmssv.Clear();
            txthoten.Clear();
            txtlop.Clear();
            txtsdt.Clear();
            txtquequan.Clear();
            cobgioitinh.SelectedIndex = -1;
            cobmaphong.SelectedIndex = -1;
            datengaysinh.Value = DateTime.Now;
            datengayvao.Value = DateTime.Now;
            txtmssv.Focus(); // Đặt con trỏ vào ô MSSV
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmssv.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!", "Thông báo");
                return;
            }

            xuLyThem = false;    // Đặt cờ là Đang Sửa
            BatTatChucNang(true);

            // Khi sửa, KHÔNG cho phép sửa Mã Sinh Viên (Khóa chính)
            txtmssv.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentMSSV))
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa!", "Cảnh báo");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên " + txthoten.Text + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // Tìm sinh viên theo MSSV
                    var sv = context.SinhViens.Find(currentMSSV);
                    if (sv != null)
                    {
                        context.SinhViens.Remove(sv); // Xóa
                        context.SaveChanges();        // Lưu vào CSDL

                        MessageBox.Show("Xóa thành công!");
                        frmThemSinhVien_Load(sender, e); // Tải lại bảng
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa (Có thể SV này đang có hóa đơn): " + ex.Message);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmssv.Text) || string.IsNullOrWhiteSpace(txthoten.Text))
            {
                MessageBox.Show("Vui lòng nhập MSSV và Họ Tên!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (xuLyThem)
                {
                    // --- LOGIC THÊM MỚI ---

                    // Kiểm tra trùng mã
                    var checkID = context.SinhViens.Find(txtmssv.Text);
                    if (checkID != null)
                    {
                        MessageBox.Show("Mã số sinh viên này đã tồn tại!", "Trùng mã");
                        return;
                    }

                    // Tạo đối tượng mới
                    SinhVien sv = new SinhVien();
                    sv.MSSV = txtmssv.Text; // Gán dữ liệu từ form vào đối tượng
                    sv.HoTen = txthoten.Text;
                    sv.Lop = txtlop.Text;
                    sv.SDT = txtsdt.Text;
                    sv.QueQuan = txtquequan.Text;
                    sv.GioiTinh = cobgioitinh.Text;
                    sv.NgaySinh = datengaysinh.Value;
                    sv.NgayVao = datengayvao.Value;
                    sv.MaPhong = cobmaphong.SelectedValue?.ToString();

                    context.SinhViens.Add(sv); // Thêm vào context
                    context.SaveChanges();     // Lưu xuống SQL
                    MessageBox.Show("Thêm mới thành công!");
                }
                else
                {
                    // --- LOGIC CẬP NHẬT (SỬA) ---
                    var sv = context.SinhViens.Find(currentMSSV); // Tìm sinh viên cũ
                    if (sv != null)
                    {
                        sv.HoTen = txthoten.Text; // Cập nhật thông tin mới (trừ MSSV)
                        sv.Lop = txtlop.Text;
                        sv.SDT = txtsdt.Text;
                        sv.QueQuan = txtquequan.Text;
                        sv.GioiTinh = cobgioitinh.Text;
                        sv.NgaySinh = datengaysinh.Value;
                        sv.NgayVao = datengayvao.Value;
                        sv.MaPhong = cobmaphong.SelectedValue?.ToString();

                        context.SinhViens.Update(sv);
                        context.SaveChanges();
                        MessageBox.Show("Cập nhật thông tin thành công!");
                    }
                }

                // Tải lại dữ liệu và reset form
                frmThemSinhVien_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmThemSinhVien_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
