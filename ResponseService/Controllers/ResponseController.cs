using Microsoft.AspNetCore.Mvc;

namespace ResponseService.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ResponseController : ControllerBase
    {
        // /api/response/100
        [Route("{id:int}")]
        [HttpGet]
        public ActionResult GetAPIResponse(int id) 
        {
            return Ok();
        }
    }
}