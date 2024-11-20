using Microsoft.EntityFrameworkCore;
using WebApi_Abdelrhman_khaled_0522015_S4.Data;
using WebApi_Abdelrhman_khaled_0522015_S4.DTOS;
using WebApi_Abdelrhman_khaled_0522015_S4.Models;

namespace WebApi_Abdelrhman_khaled_0522015_S4.repomovie
{
    public class Movierepo : IMovie
    {
        private readonly AppDbContext context;
        public Movierepo(AppDbContext db)
        {
            context = db;
        }
        public void Add(MovieDTO dto)
        {
            var x = new Movie
            {
                Title = dto.Title,
                releaseyear=dto.releaseyear,
                directors=dto.directors.
                Select(z=>new Director 
                { Name = z.Name, 
                    EmailAddress = z.EmailAddress,
                    Phone = z.Phone, 
                    nationality = new Nationality
                    { Name = z.nationality.Name } }).ToList(),
                Category=new Category { Name=dto.Category.Name}
            };
            context.Movies.Add(x);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var x = context.Movies.Include(z => z.Category).Include(a => a.directors).FirstOrDefault(x => x.Id == id);
            if(x != null)
            {
                context.Movies.Remove(x);
                context.SaveChanges();
            }
        }

        public MovieDTO Get(int id)
        {
            var x = context.Movies.Include(z => z.Category).Include(a => a.directors).
                ThenInclude(q=>q.nationality).FirstOrDefault(x => x.Id == id);
            if(x != null)
            {
                return new MovieDTO
                {
                    Title = x.Title,
                    releaseyear = x.releaseyear,
                    Category = new CategoryDTO { Name = x.Category.Name },
                    directors = x.directors.
                                Select(z => new DirectorDTO
                                {
                                    Name = z.Name,
                                    EmailAddress = z.EmailAddress,
                                    Phone = z.Phone,
                                    nationality = new NationalityDTO { Name = z.nationality.Name }
                                }).ToList()
                };
            }
            return null;
            
        }
            public List<MovieDTO> GetAll()
            {
               var x = context.Movies.Include(z => z.Category).Include(a => a.directors).
                Select(x=>new MovieDTO 
                { Title=x.Title,
                    releaseyear=x.releaseyear,
                    Category=new CategoryDTO { Name=x.Category.Name},
                    directors=x.directors.Select(z=>new DirectorDTO { Name = z.Name, EmailAddress = z.EmailAddress, Phone = z.Phone, 
                        nationality = new NationalityDTO { Name = z.nationality.Name } }).ToList()
                }).ToList();
                return x;

            }

            public void Update(MovieDTO dto, int id)
            {
                var x = context.Movies.Include(z => z.Category).
                Include(a => a.directors).ThenInclude(a=>a.nationality).
                FirstOrDefault(x => x.Id == id);
            if (x != null)
            {
                throw new Exception("Avalible");
            }
            x.Title = dto.Title;
            x.releaseyear = dto.releaseyear;
            x.Category = new Category { Name = dto.Category.Name };
            x.directors = x.directors.
                Select(z => new Director { Name = z.Name
                , EmailAddress = z.EmailAddress
                , Phone = z.Phone, 
                    nationality = new Nationality { Name = z.nationality.Name }
                }).ToList();
            context.Movies.Update(x);
            context.SaveChanges();

            }
    }
}
