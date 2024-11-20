using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi_Abdelrhman_khaled_0522015_S4.Caegorierepo;
using WebApi_Abdelrhman_khaled_0522015_S4.DTOS;

namespace WebApi_Abdelrhman_khaled_0522015_S4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly Icategories context;
        public CategoriesController(Icategories db)
        {
            context = db;
        }
        [HttpPost]
        public IActionResult post(CategoryDTO dTO)
        {
            context.Add(dTO);
            return Ok();
        }
        [HttpPut]
        public IActionResult put(CategoryDTO1 dTO,int id)
        {
            context.Update(dTO, id);
            return Ok();
        }
    }
}
