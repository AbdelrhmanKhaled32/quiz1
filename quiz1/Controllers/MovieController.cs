using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi_Abdelrhman_khaled_0522015_S4.DTOS;
using WebApi_Abdelrhman_khaled_0522015_S4.repomovie;

namespace WebApi_Abdelrhman_khaled_0522015_S4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovie context;
        public MovieController(IMovie movie)
        {
            context = movie;
        }
        [HttpGet("id")]
        
        public IActionResult get(int id)
        {
            var x= context.Get(id);
            if(x!=null)
            {
                return Ok(x);
            }
            return NotFound();
        }
        [HttpGet("all")]
        public IActionResult getall()
        {
            return Ok(context.GetAll());
        }
        [HttpDelete]
        public IActionResult delete(int id)
        {
            context.Delete(id);
            return Ok();
        }
        [HttpPost]
        public IActionResult post([FromForm]MovieDTO dTO)
        {
            context.Add(dTO);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(MovieDTO dTO, int id)
        {
            context.Update(dTO, id);
            return Ok();
        }
    }
}
