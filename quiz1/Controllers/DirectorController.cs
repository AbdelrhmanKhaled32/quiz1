using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi_Abdelrhman_khaled_0522015_S4.DTOS;
using WebApi_Abdelrhman_khaled_0522015_S4.repodirectors;

namespace WebApi_Abdelrhman_khaled_0522015_S4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorController : ControllerBase
    {
        private readonly Idirectors context;
        public DirectorController(Idirectors db)
        {
            context = db;
        }
        [HttpPost]
        public IActionResult Post(DirectorDTO dTO)
        {
            context.Add(dTO);
            return Ok();
        }
        [HttpPut]
        public IActionResult Put(DirectorDTO1 dTO,int id)
        {
            context.Update(dTO,id);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            context.Delete(id);
            return Ok();
        }
    }
}
