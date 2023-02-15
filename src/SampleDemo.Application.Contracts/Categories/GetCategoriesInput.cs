using Volo.Abp.Application.Dtos;
using System;

namespace SampleDemo.Categories
{
    public class GetCategoriesInput : PagedAndSortedResultRequestDto
    {
        public string FilterText { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public GetCategoriesInput()
        {

        }
    }
}