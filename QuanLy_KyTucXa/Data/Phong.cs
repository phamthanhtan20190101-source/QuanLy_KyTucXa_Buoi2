using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLy_KyTucXa.Data
{
    public class Phong
    {
        // 1. Mã Phòng (Khóa chính)
        [Key]
        [StringLength(10)] // Tùy chọn: giới hạn độ dài mã
        public string MaPhong { get; set; }

        // 2. Loại Phòng: Bạn yêu cầu có "4 người" và "6 người". 
        
        public int LoaiPhong { get; set; }

        // 3. Giá: Dùng decimal cho tiền tệ để tránh sai số
        public decimal Gia { get; set; }

        // 4. Trạng Thái: (Số lượng người ở / Loại phòng) -> Ví dụ: "2/4", "5/6"
       
        public string TrangThai { get; set; }

        // 5. Mã Tòa Nhà (Khóa ngoại)
        public string MaToaNha { get; set; }

        // Thiết lập liên kết với bảng ToaNha (đã tạo ở bước trước)
        [ForeignKey("MaToaNha")]
        public virtual ToaNha ToaNha { get; set; }

        // 6. Tiền Điện Nước
        public decimal TienDienNuoc { get; set; }

        // 7. Số Lượng Đang Ở
        public int SoLuongDangO { get; set; } = 0;
    }
}