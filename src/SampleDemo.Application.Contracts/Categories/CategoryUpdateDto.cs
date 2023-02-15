using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace SampleDemo.Categories
{
    public class CategoryUpdateDto : IHasConcurrencyStamp
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        public string ConcurrencyStamp { get; set; }
    }
}