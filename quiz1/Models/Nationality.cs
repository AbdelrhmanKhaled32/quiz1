using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi_Abdelrhman_khaled_0522015_S4.Models
{
    public class Nationality
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ?Name { get; set; }
        public int id_director { get; set; }
        [ForeignKey("id_director")]
        public Director ?director { get; set; }
    }
}
