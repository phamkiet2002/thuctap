
using ChamCongNhanDienKhuonMat.DB;
using ChamCongNhanDienKhuonMat.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NhanDienKhuonMat.DTO;
using NhanDienKhuonMat.Service;

namespace ChamCong_NhanDienKhuonMat.Server.Controllers  
{
    [Route("api/time")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class TimeController : ControllerBase
    {
        private readonly TimeService TimeService;
        public TimeController(TimeService timeService)
        {
            TimeService = timeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTime()
        {
            try
            {
                return Ok(TimeService.GetAll());
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddTime(TimeDTO timeDTO)
        {
            try
            {
                return Ok(TimeService.Add(timeDTO));
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTimeById(int id)
        {
            try
            {
                var time = TimeService.GetById(id);
                if (time != null)
                {
                    return Ok(TimeService.GetById(id));
                }
                else
                {
                    return NotFound();
                }
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTimeById(int id)
        {
            try
            {
                var time = TimeService.GetById(id);
                if (time != null)
                {
                    TimeService.Delete(id);
                    return Ok();
                }
                else
                {
                    return NotFound();
                }
            }
            catch
            {
                return BadRequest();
            }


        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTimeById(int id, TimeDTO timeDTO)
        {
            if (id != timeDTO.Id)
            {
                return BadRequest();
            }
            try
            {
                TimeService.Update(timeDTO);
                return Content("cap nhat thanh cong " + timeDTO.LunchBreak + " " + timeDTO.StartTime + " " + timeDTO.EndTime);
            }
            catch 
            {
                return BadRequest();
            }
        }

        
    }
}
