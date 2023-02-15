using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SampleDemo.Categories
{
    public class CategoryCreateDto
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}