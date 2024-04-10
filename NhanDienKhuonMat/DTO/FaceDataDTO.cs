using ChamCongNhanDienKhuonMat.Model;

namespace NhanDienKhuonMat.DTO
{
    public class FaceDataDTO
    {
        public int Id { get; set; }
        public string Img { get; set; }
        public int? EmployeeId { get; set; }
        public EmployeeDTO employee { get; set; }
    }
}
