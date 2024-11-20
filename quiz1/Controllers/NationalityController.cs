using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi_Abdelrhman_khaled_0522015_S4.DTOS;
using WebApi_Abdelrhman_khaled_0522015_S4.Nationalityrepo;

namespace WebApi_Abdelrhman_khaled_0522015_S4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NationalityController : ControllerBase
    {
        private readonly INationality context;
        public NationalityController(INationality db)
        {
            context = db;
        }
        [HttpPost]
        public IActionResult post(NationalityDTO2 dTO)
        {
            context.add(dTO);
            return Ok();
        }
        [HttpDelete]
        public IActionResult delete(int id)
        {
            context.remove(id);
            return Ok();
        }
    }
}
