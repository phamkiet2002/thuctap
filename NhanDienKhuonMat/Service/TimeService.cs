using ChamCongNhanDienKhuonMat.DB;
using ChamCongNhanDienKhuonMat.Model;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using NhanDienKhuonMat.DTO;
using NhanDienKhuonMat.Repository;

namespace NhanDienKhuonMat.Service
{
    public class TimeService : TimeRepositoty
    {
        private readonly NhanDienDBContext NhanDienDBContext;
        public TimeService(NhanDienDBContext nhanDienDBContext)
        {
            NhanDienDBContext = nhanDienDBContext;
        }

        public TimeDTO Add(TimeDTO timeDTO)
        {
            var time = new TimeEntity
            {
                StartTime = timeDTO.StartTime,
                EndTime = timeDTO.EndTime,
                LunchBreak = timeDTO.LunchBreak,
            };

            NhanDienDBContext.Add(time);
            NhanDienDBContext.SaveChanges();
            return new TimeDTO {
                StartTime = time.StartTime,
                EndTime = time.EndTime,
                LunchBreak = time.LunchBreak,
            };
        }

        public void Delete(int id)
        {
            var time = NhanDienDBContext.Times.SingleOrDefault(t => t.Id == id);
            if (time != null)
            {
                NhanDienDBContext.Remove(time);
                NhanDienDBContext.SaveChanges();
            }

        }

        public List<TimeDTO> GetAll()
        {
            var time = NhanDienDBContext.Times.Select(t => new TimeDTO
            {
                Id = t.Id,
                StartTime = t.StartTime,
                EndTime = t.EndTime,
                LunchBreak = t.LunchBreak,
            });
            return time.ToList();
        }

        public TimeDTO GetById(int id)
        {
            var time = NhanDienDBContext.Times.SingleOrDefault(t => t.Id == id);
            if (time != null)
            {
                return new TimeDTO
                {
                    Id =time.Id,
                    StartTime = time.StartTime,
                    EndTime = time.EndTime,
                    LunchBreak = time.LunchBreak,   
                };
            }
            return null;
        }

        public void Update(TimeDTO timeDTO)
        {
            var time = NhanDienDBContext.Times.SingleOrDefault(t => t.Id == timeDTO.Id);
            time.StartTime = timeDTO.StartTime;
            time.EndTime = timeDTO.EndTime;
            time.LunchBreak = timeDTO.LunchBreak;
            NhanDienDBContext.SaveChanges();
        }
    }
}
