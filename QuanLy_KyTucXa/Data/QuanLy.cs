using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLy_KyTucXa.Data
{
    public class QuanLy
    {
        // 1. Mã Quản Lý (Khóa chính)
        [Key]
        [StringLength(20)]
        public string MaQuanLy { get; set; }

        // 2. Họ Tên Quản Lý
        [Required] 
        [StringLength(100)]
        public string HoTenQuanLy { get; set; }

        // 3. Mã Tòa Quản Lý (Khóa ngoại)
        
        public string MaToaQuanLy { get; set; }

        // Thiết lập liên kết với bảng ToaNha
        
        [ForeignKey("MaToaQuanLy")]
        public virtual ToaNha ToaNha { get; set; }
    }
}