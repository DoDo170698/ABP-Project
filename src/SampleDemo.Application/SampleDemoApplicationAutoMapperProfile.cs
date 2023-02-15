using System;
using SampleDemo.Shared;
using Volo.Abp.AutoMapper;
using SampleDemo.Categories;
using AutoMapper;

namespace SampleDemo;

public class SampleDemoApplicationAutoMapperProfile : Profile
{
    public SampleDemoApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Category, CategoryDto>();
        CreateMap<Category, CategoryExcelDto>();
    }
}