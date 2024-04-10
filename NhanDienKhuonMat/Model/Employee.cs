using NhanDienKhuonMat.DTO;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ChamCongNhanDienKhuonMat.Model
{
    [Table("Employee")]
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool GioiTinh { get; set; }
        public int Sdt { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public string BaseImg { get; set; }
        public ICollection<FaceData> Facedatas { get; set; }
        public ICollection<TimeKeeping> Timekeepings { get; set; }
    }
}
