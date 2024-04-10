using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ChamCongNhanDienKhuonMat.Model
{
    [Table("TimeKeeping")]
    public class TimeKeeping
    {
        public int Id { get; set; }
        public DateTime CheckIin { get; set; }
        public DateTime CheckOut { get; set; }
        public string Status { get; set; }
        public int? EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
