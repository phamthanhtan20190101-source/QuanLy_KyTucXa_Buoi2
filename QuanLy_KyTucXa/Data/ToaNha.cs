using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;

namespace QuanLy_KyTucXa.Data
{
    public class ToaNha
    {
        
        [Key]
        public string MaToaNha { get; set; }

        // Tên tòa nhà
        public string TenToaNha { get; set; }

        // Số lượng phòng
        public int SoLuongPhong { get; set; }

        
        public virtual ObservableCollectionListSource<Phong> Phongs { get; set; } = new();
    }
}