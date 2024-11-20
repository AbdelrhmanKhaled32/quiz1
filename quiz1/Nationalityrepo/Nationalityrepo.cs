using Microsoft.EntityFrameworkCore;
using WebApi_Abdelrhman_khaled_0522015_S4.Data;
using WebApi_Abdelrhman_khaled_0522015_S4.DTOS;
using WebApi_Abdelrhman_khaled_0522015_S4.Models;

namespace WebApi_Abdelrhman_khaled_0522015_S4.Nationalityrepo
{
    public class Nationalityrepo : INationality
    {
        private readonly AppDbContext context;
        public Nationalityrepo(AppDbContext db)
        {
            context = db;
        }
        public void add(NationalityDTO2 dTO)
        {
            Nationality x = new Nationality
            {
                Name = dTO.Name,
                director=new Director { Name=dTO.Name,EmailAddress=dTO.director.EmailAddress,Phone=dTO.director.Phone}
            };
            context.nationalities.Add(x);
            context.SaveChanges();
        }

        public void remove(int id)
        {
           var x = context.nationalities.Include(x=>x.director).ThenInclude(o=>o.Movies).ThenInclude(x=>x.Category).FirstOrDefault(x=>x.Id== id);
            if (x != null)
            {
                context.nationalities.Remove(x);
                context.SaveChanges();
            }
        }
    }
}
