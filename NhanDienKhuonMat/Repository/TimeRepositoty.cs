using ChamCongNhanDienKhuonMat.Model;
using NhanDienKhuonMat.DTO;

namespace NhanDienKhuonMat.Repository
{
    public interface TimeRepositoty
    {
        List<TimeDTO> GetAll(); 
        TimeDTO GetById(int id);
        TimeDTO Add(TimeDTO timeDTO);
        void Update(TimeDTO timeDTO);
        void Delete(int id);
    }
}
