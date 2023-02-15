using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Volo.Abp;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp.Data;

namespace SampleDemo.Categories
{
    public class CategoryManager : DomainService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<Category> CreateAsync(
        string name, string description)
        {
            Check.NotNullOrWhiteSpace(name, nameof(name));

            var category = new Category(
             GuidGenerator.Create(),
             name, description
             );

            return await _categoryRepository.InsertAsync(category);
        }

        public async Task<Category> UpdateAsync(
            Guid id,
            string name, string description, [CanBeNull] string concurrencyStamp = null
        )
        {
            Check.NotNullOrWhiteSpace(name, nameof(name));

            var category = await _categoryRepository.GetAsync(id);

            category.Name = name;
            category.Description = description;

            category.SetConcurrencyStampIfNotNull(concurrencyStamp);
            return await _categoryRepository.UpdateAsync(category);
        }

    }
}