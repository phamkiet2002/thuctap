using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ChamCongNhanDienKhuonMat.Model
{
    [Table("FaceData")]
    public class FaceData
    {
        public int Id { get; set; }
        public string Img { get; set; }
        public int? EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
