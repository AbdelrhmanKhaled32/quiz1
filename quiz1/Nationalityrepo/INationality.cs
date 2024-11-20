using WebApi_Abdelrhman_khaled_0522015_S4.DTOS;

namespace WebApi_Abdelrhman_khaled_0522015_S4.Nationalityrepo
{
    public interface INationality
    {
        public void add(NationalityDTO2 dTO);
        public void remove(int id);
    }
}
