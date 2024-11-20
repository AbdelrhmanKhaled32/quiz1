using System.ComponentModel.DataAnnotations;

namespace WebApi_Abdelrhman_khaled_0522015_S4.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ?Title { get; set; }
        [Required]
        public DateTime releaseyear { get; set; }   
        public List<Director> ?directors { get; set;}
        public Category ?Category { get; set; }
    }
}
