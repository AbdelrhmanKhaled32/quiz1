using System.ComponentModel.DataAnnotations;
using WebApi_Abdelrhman_khaled_0522015_S4.Models;

namespace WebApi_Abdelrhman_khaled_0522015_S4.DTOS
{
    public class DirectorDT2
    {
        [Required]
        public string? Name { get; set; }
        [Phone]
        public string? Phone { get; set; }
        [EmailAddress(ErrorMessage = "invalid")]
        public string? EmailAddress { get; set; }
     
    }
}
