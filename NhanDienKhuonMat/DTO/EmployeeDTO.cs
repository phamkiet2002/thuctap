using ChamCongNhanDienKhuonMat.Model;

namespace NhanDienKhuonMat.DTO
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool GioiTinh { get; set; }
        public int Sdt { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public string BaseImg { get; set; }
        public List<FaceDataDTO> FaceDataModel { get; internal set; }
        public List<TimeKeepingDTO> TimeKeepingModel { get; internal set; }
    }
}
