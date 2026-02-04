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
    public partial class frmToaNha : Form
    {
        QLKTXDbContext context = new QLKTXDbContext();
        bool xuLyThem = false;
        string currentMaPhong = "";
        public frmToaNha()
        {
            InitializeComponent();
        }

        private void frmToaNha_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false); // Khóa nhập liệu ban đầu
            LoadDataToAllGrids();  // Tải dữ liệu lên 4 bảng
        }

        private void BatTatChucNang(bool moKhoa)
        {
            // Nhóm nhập liệu
            txtMaPhong.Enabled = moKhoa;
            cobToaNha.Enabled = moKhoa;
            cobLoaiPhong.Enabled = moKhoa;

            // Nhóm nút Lưu/Hủy
            btnLuu.Enabled = moKhoa;
            btnHuyBo.Enabled = moKhoa;

            // Nhóm nút Chức năng chính
            btnThem.Enabled = !moKhoa;
            btnSua.Enabled = !moKhoa;
            btnXoa.Enabled = !moKhoa;
            btnTimKiem.Enabled = !moKhoa;
        }

        private void LoadDataToAllGrids()
        {
           // --- HÀM TẢI DỮ LIỆU CHIA VỀ 4 BẢNG ---

        
            try
            {
                // 1. Lấy tất cả phòng từ CSDL
                var listPhong = context.Phongs.ToList();

                // 2. Đổ dữ liệu vào từng lưới
                dataGridViewToaA.DataSource = listPhong.Where(p => p.MaToaNha == "A").ToList();
                dataGridViewToaB.DataSource = listPhong.Where(p => p.MaToaNha == "B").ToList();
                dataGridViewToaC.DataSource = listPhong.Where(p => p.MaToaNha == "C").ToList();
                dataGridViewToaD.DataSource = listPhong.Where(p => p.MaToaNha == "D").ToList();

                // 3. Gọi hàm ẩn cột thừa và đặt tên tiếng Việt cho 4 lưới
                CauHinhHienThiLuoi(dataGridViewToaA);
                CauHinhHienThiLuoi(dataGridViewToaB);
                CauHinhHienThiLuoi(dataGridViewToaC);
                CauHinhHienThiLuoi(dataGridViewToaD);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void CauHinhHienThiLuoi(DataGridView dgv)
        {
            // Nếu lưới chưa có dữ liệu thì không làm gì cả
            if (dgv.DataSource == null) return;

            // 1. Ẩn các cột không cần thiết (nhưng vẫn giữ dữ liệu ngầm để xử lý Logic)
            if (dgv.Columns["LoaiPhong"] != null) dgv.Columns["LoaiPhong"].Visible = false;
            if (dgv.Columns["Gia"] != null) dgv.Columns["Gia"].Visible = false;
            if (dgv.Columns["TrangThai"] != null) dgv.Columns["TrangThai"].Visible = false;
            if (dgv.Columns["MaToaNha"] != null) dgv.Columns["MaToaNha"].Visible = false;
            if (dgv.Columns["ToaNha"] != null) dgv.Columns["ToaNha"].Visible = false; // Cột quan hệ bảng

            // 2. Hiện và đặt tên tiếng Việt cho 3 cột cần thiết
            if (dgv.Columns["MaPhong"] != null)
            {
                dgv.Columns["MaPhong"].Visible = true;
                dgv.Columns["MaPhong"].HeaderText = "Mã Phòng";
                dgv.Columns["MaPhong"].Width = 100; // Chỉnh độ rộng nếu thích
            }

            if (dgv.Columns["TienDienNuoc"] != null)
            {
                dgv.Columns["TienDienNuoc"].Visible = true;
                dgv.Columns["TienDienNuoc"].HeaderText = "Tiền Điện Nước";
            }

            if (dgv.Columns["SoLuongDangO"] != null)
            {
                dgv.Columns["SoLuongDangO"].Visible = true;
                dgv.Columns["SoLuongDangO"].HeaderText = "Số Lượng";
            }
        }

        private void HienThiThongTinTuGrid(DataGridViewRow row)
        {
            if (row != null)
            {
                txtMaPhong.Text = row.Cells["MaPhong"].Value.ToString();
                currentMaPhong = txtMaPhong.Text; // Lưu lại để dùng cho Sửa/Xóa

                // Xử lý hiển thị ComboBox Tòa Nhà
                string maToa = row.Cells["MaToaNha"].Value.ToString();
                if (maToa == "A") cobToaNha.Text = "Tòa A (Nam)";
                else if (maToa == "B") cobToaNha.Text = "Tòa B (Nữ)";
                else if (maToa == "C") cobToaNha.Text = "Tòa C (Nam)";
                else if (maToa == "D") cobToaNha.Text = "Tòa D (Nữ)";

                // Xử lý hiển thị Loại Phòng
                int loai = Convert.ToInt32(row.Cells["LoaiPhong"].Value);
                if (loai == 4) cobLoaiPhong.Text = "4 Người";
                else if (loai == 6) cobLoaiPhong.Text = "6 Người";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;          // Bật cờ Thêm
            BatTatChucNang(true);     // Mở khóa nhập liệu

            // Reset dữ liệu cũ
            txtMaPhong.Clear();
            cobToaNha.SelectedIndex = -1;
            cobLoaiPhong.SelectedIndex = -1;

            txtMaPhong.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhong.Text))
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa từ danh sách!", "Thông báo");
                return;
            }

            xuLyThem = false;         // Bật cờ Sửa
            BatTatChucNang(true);     // Mở khóa nhập liệu
            txtMaPhong.Enabled = false; // Không cho sửa Mã Phòng (Khóa chính)
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentMaPhong))
            {
                MessageBox.Show("Vui lòng chọn phòng để xóa!", "Cảnh báo");
                return;
            }

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa phòng {currentMaPhong}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    var p = context.Phongs.Find(currentMaPhong);
                    if (p != null)
                    {
                        // Kiểm tra nếu phòng đang có người ở thì không cho xóa
                        if (p.SoLuongDangO > 0)
                        {
                            MessageBox.Show("Phòng này đang có sinh viên ở, không thể xóa!", "Lỗi");
                            return;
                        }

                        context.Phongs.Remove(p);
                        context.SaveChanges();
                        MessageBox.Show("Xóa thành công!");
                        LoadDataToAllGrids();

                        // Reset form
                        btnHuyBo_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa: " + ex.Message);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhong.Text) ||
                cobToaNha.SelectedIndex == -1 ||
                cobLoaiPhong.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đủ Mã phòng, Tòa nhà và Loại phòng!", "Thiếu thông tin");
                return;
            }

            try
            {
                Phong p;

                if (xuLyThem)
                {
                    // --- LOGIC THÊM MỚI ---

                    // Kiểm tra trùng mã
                    if (context.Phongs.Find(txtMaPhong.Text) != null)
                    {
                        MessageBox.Show("Mã phòng này đã tồn tại!", "Trùng lặp");
                        txtMaPhong.Focus();
                        return;
                    }

                    p = new Phong();
                    p.MaPhong = txtMaPhong.Text;

                    // Gán các giá trị mặc định cho phòng mới
                    p.TrangThai = "Trống";
                    p.TienDienNuoc = 0;
                    p.SoLuongDangO = 0;

                    // Thêm vào Context (chưa lưu)
                    context.Phongs.Add(p);
                }
                else
                {
                    // --- LOGIC CẬP NHẬT (SỬA) ---
                    p = context.Phongs.Find(currentMaPhong);
                    if (p == null) return;
                }

                // --- XỬ LÝ DỮ LIỆU CHUNG (Cho cả Thêm và Sửa) ---

                // 1. Xử lý Mã Tòa Nhà (Từ "Tòa A (Nam)" -> "A")
                string tenChon = cobToaNha.Text;
                string maToaNha = "";
                if (tenChon.Contains("Tòa A")) maToaNha = "A";
                else if (tenChon.Contains("Tòa B")) maToaNha = "B";
                else if (tenChon.Contains("Tòa C")) maToaNha = "C";
                else if (tenChon.Contains("Tòa D")) maToaNha = "D";
                p.MaToaNha = maToaNha;

                // 2. Xử lý Loại Phòng & Giá
                int sucChua = 0;
                decimal giaTien = 0;

                if (cobLoaiPhong.Text.Contains("4"))
                {
                    sucChua = 4;
                    giaTien = 1200000; // Giá phòng 4
                }
                else if (cobLoaiPhong.Text.Contains("6"))
                {
                    sucChua = 6;
                    giaTien = 800000;  // Giá phòng 6
                }

                p.LoaiPhong = sucChua;
                p.Gia = giaTien; // Cập nhật giá phòng

                // Lưu thay đổi xuống CSDL
                context.SaveChanges();

                MessageBox.Show(xuLyThem ? "Thêm mới thành công!" : "Cập nhật thành công!");

                // Tải lại dữ liệu và reset form
                LoadDataToAllGrids();
                btnHuyBo_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message + "\n" + ex.InnerException?.Message);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            txtMaPhong.Clear();
            cobToaNha.SelectedIndex = -1;
            cobLoaiPhong.SelectedIndex = -1;
        }

        private void dataGridViewToaA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) HienThiThongTinTuGrid(dataGridViewToaA.Rows[e.RowIndex]);
        }

        private void dataGridViewToaB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) HienThiThongTinTuGrid(dataGridViewToaB.Rows[e.RowIndex]);
        }

        private void dataGridViewToaC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) HienThiThongTinTuGrid(dataGridViewToaC.Rows[e.RowIndex]);
        }

        private void dataGridViewToaD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) HienThiThongTinTuGrid(dataGridViewToaD.Rows[e.RowIndex]);
        }
    }

}
