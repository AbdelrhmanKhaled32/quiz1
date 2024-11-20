﻿using System.ComponentModel.DataAnnotations;
using WebApi_Abdelrhman_khaled_0522015_S4.Models;

namespace WebApi_Abdelrhman_khaled_0522015_S4.DTOS
{
    public class MovieDTO
    {
        [Required]
        public string? Title { get; set; }
        [Required]
        public DateTime releaseyear { get; set; }
        public List<DirectorDTO>? directors { get; set; }
        public CategoryDTO? Category { get; set; }
    }
}
