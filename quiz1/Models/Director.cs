using System.ComponentModel.DataAnnotations;

namespace WebApi_Abdelrhman_khaled_0522015_S4.Models
{
    public class Director
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ?Name { get; set; }
        [Phone]
        public string ?Phone { get; set; }
        [EmailAddress]
        public string ?EmailAddress { get; set; }
        public List<Movie> ?Movies { get; set; }
        public Nationality ?nationality { get; set; }
    }
}
