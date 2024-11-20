using Microsoft.EntityFrameworkCore;
using WebApi_Abdelrhman_khaled_0522015_S4.Data;
using WebApi_Abdelrhman_khaled_0522015_S4.DTOS;
using WebApi_Abdelrhman_khaled_0522015_S4.Models;

namespace WebApi_Abdelrhman_khaled_0522015_S4.Caegorierepo
{
    public class Caegorierepo : Icategories
    {
        private readonly AppDbContext context;
        public Caegorierepo(AppDbContext db)
        {
            context = db;
        }
        public void Add(CategoryDTO dto)
        {
            Category x = new Category
            {
                Name=dto.Name,
            };
            context.categories.Add(x);
            context.SaveChanges();
        }

        public void Update(CategoryDTO1 dto, int id)
        {
            var  x =context.categories.Include(z=>z.movies).FirstOrDefault(c=>c.Id==id);
            if (x != null)
            {
                x.Name = dto.Name;
                x.movies=dto.Movie.Select(z=>new Movie { Title=z.Title,releaseyear=z.releaseyear}).ToList();
            }
            context.categories.Update(x);
            context.SaveChanges();
        }
    }
}
