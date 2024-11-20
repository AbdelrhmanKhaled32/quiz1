using System.ComponentModel.DataAnnotations;

namespace WebApi_Abdelrhman_khaled_0522015_S4.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ?Name { get; set; }
        public List<Movie> ?movies { get; set; }
    } 
}
