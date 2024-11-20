using Microsoft.EntityFrameworkCore;
using WebApi_Abdelrhman_khaled_0522015_S4.Data;
using WebApi_Abdelrhman_khaled_0522015_S4.DTOS;
using WebApi_Abdelrhman_khaled_0522015_S4.Models;

namespace WebApi_Abdelrhman_khaled_0522015_S4.repodirectors
{
    public class Directorrepo : Idirectors
    {
        private readonly AppDbContext context;
        public Directorrepo(AppDbContext context_)
        {
            context = context_;
        }
        public void Add(DirectorDTO dto)
        {
            var x = new Director
            {
               Name = dto.Name,
               EmailAddress = dto.EmailAddress,
               nationality=new Nationality { Name=dto.Name},
               Phone=dto.Phone
            };
            context.Directors.Add(x);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var x = context.Directors.Include(x => x.Movies).ThenInclude(s => s.Category).Include(x => x.nationality).FirstOrDefault(x=>x.Id==id);
            if(x!=null)
            {
                context.Directors.Remove(x);
                context.SaveChanges();
            }
        }

        public void Update(DirectorDTO1 dto, int id)
        {
            var x = context.Directors.Include(x => x.Movies).ThenInclude(s => s.Category).Include(x => x.nationality).FirstOrDefault(x => x.Id == id);
            if (x != null)
            {
                x.nationality = new Nationality { Name = dto.nationality.Name };
                x.Name=dto.Name;
                x.Phone = dto.Phone;
                x.EmailAddress = dto.EmailAddress;
                x.Movies = dto.Movie.Select(x => new Movie { Title = x.Title, releaseyear = x.releaseyear, Category = new Category { Name = x.Category.Name } }).ToList();
                
                context.Directors.Update(x);
                context.SaveChanges();
            }
        }
    }
}
