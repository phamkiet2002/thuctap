using ChamCongNhanDienKhuonMat.DB;
using ChamCongNhanDienKhuonMat.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NhanDienKhuonMat.DTO;

namespace ChamCong_NhanDienKhuonMat.Server.Controllers
{
    [Route("api/employee")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class EmployeeController : ControllerBase
    {
        private NhanDienDBContext NhanDienDBContext;
        public EmployeeController(NhanDienDBContext nhanDienDBContext)
        {
            NhanDienDBContext = nhanDienDBContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeDTO>>> GetAllEmployees()
        {
            var employeesWithFaceData = await NhanDienDBContext.Employees
                .Include(e => e.Facedatas)
                .Include(e => e.Timekeepings)
                .ToListAsync();
            var employeeDtos = employeesWithFaceData.Select(e => new EmployeeDTO
            {
                Id = e.Id,
                Name = e.Name,
                GioiTinh = e.GioiTinh,
                Email = e.Email,
                Department = e.Department,
                Position = e.Position,
                Sdt = e.Sdt,
                BaseImg = e.BaseImg,

                FaceDataModel = e.Facedatas.Select(fd => new FaceDataDTO
                {
                    Id = fd.Id,
                    Img = fd.Img,
                    EmployeeId = fd.Id,
                }).ToList(),

                TimeKeepingModel = e.Timekeepings.Select(t => new TimeKeepingDTO
                {
                    Id = t.Id,
                    CheckIin = t.CheckIin,
                    CheckOut = t.CheckOut,
                    Status = t.Status,
                    EmployeeId = t.Id,
                }).ToList(),

            });
            return Ok(employeeDtos);
        }
    }
}

