using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NhanDienKhuonMat.Controllers
{
    [Route("api/timekeeping")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class TimeKeepingController : ControllerBase
    {

    }
}
