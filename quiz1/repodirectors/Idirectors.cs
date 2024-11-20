using WebApi_Abdelrhman_khaled_0522015_S4.DTOS;

namespace WebApi_Abdelrhman_khaled_0522015_S4.repodirectors
{
    public interface Idirectors
    {
        public void Add(DirectorDTO dto);
        public void Update(DirectorDTO1 dto, int id);
        public void Delete(int id);
       
    }
}
