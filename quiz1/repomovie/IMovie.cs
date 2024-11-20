using WebApi_Abdelrhman_khaled_0522015_S4.DTOS;

namespace WebApi_Abdelrhman_khaled_0522015_S4.repomovie
{
    public interface IMovie
    {
        public void Add(MovieDTO dto);
        public void Update(MovieDTO dto,int id);
        public void Delete(int id);
        public MovieDTO Get(int id);
        public List<MovieDTO> GetAll();
    }
}
