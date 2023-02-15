using Volo.Abp.Application.Dtos;
using System;

namespace SampleDemo.Categories
{
    public class CategoryExcelDownloadDto
    {
        public string DownloadToken { get; set; }

        public string FilterText { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public CategoryExcelDownloadDto()
        {

        }
    }
}