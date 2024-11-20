using System.ComponentModel.DataAnnotations;

namespace WebApi_Abdelrhman_khaled_0522015_S4.DTOS
{
    public class CategoryDTO
    {
        [Required]
        public string? Name { get; set; }
        
    }
}
