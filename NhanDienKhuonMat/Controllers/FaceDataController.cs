
using ChamCongNhanDienKhuonMat.DB;
using ChamCongNhanDienKhuonMat.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NhanDienKhuonMat.DTO;

namespace ChamCong_NhanDienKhuonMat.Server.Controllers
{
    [Route("api/facedata")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class FaceDataController : ControllerBase
    {
        private readonly NhanDienDBContext NhanDienDBContext;
        public FaceDataController(NhanDienDBContext nhanDienDBContext)
        {
            NhanDienDBContext = nhanDienDBContext;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FaceDataDTO>>> getAllFaceData()
        {
            var faceDataWithEmployee = await NhanDienDBContext.FaceDatas
                .Include(f => f.Employee)
                .ToListAsync();

            var faceData = faceDataWithEmployee.Select(f => new FaceDataDTO
            {
                Id = f.Id,
                Img = f.Img,
                EmployeeId = f.EmployeeId,
                employee = new EmployeeDTO { 
                    Id = f.Employee.Id,
                    Name = f.Employee.Name,
                    GioiTinh = f.Employee.GioiTinh,
                    Email = f.Employee.Email,
                    Sdt = f.Employee.Sdt,
                    Department = f.Employee.Department,
                    Position = f.Employee.Position,
                    BaseImg = f.Img,
                },
            });

            return Ok(faceData);
        }
    }
}
