using System.ComponentModel.DataAnnotations.Schema;

namespace ChamCong_NhanDienKhuonMat.Server.Models
{
    [Table("Unknown")]
    public class Unknown
    {
        public int Id { get; set; }
        public string Img {  get; set; }    
        public DateTime CaptureTime { get; set; }  
    }
}
