using System.ComponentModel.DataAnnotations.Schema;

namespace ChamCongNhanDienKhuonMat.Model
{
    [Table("Time")]
    public class TimeEntity
    {
        public int Id { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get;set; }
        public TimeOnly LunchBreak { get; set; }
    }
}
