using System;
using System.Linq;
using Shouldly;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace SampleDemo.Categories
{
    [Collection(SampleDemoTestConsts.CollectionDefinitionName)]
    public class CategoriesAppServiceTests : SampleDemoApplicationTestBase
    {
        private readonly ICategoriesAppService _categoriesAppService;
        private readonly IRepository<Category, Guid> _categoryRepository;

        public CategoriesAppServiceTests()
        {
            _categoriesAppService = GetRequiredService<ICategoriesAppService>();
            _categoryRepository = GetRequiredService<IRepository<Category, Guid>>();
        }

        [Fact]
        public async Task GetListAsync()
        {
            // Act
            var result = await _categoriesAppService.GetListAsync(new GetCategoriesInput());

            // Assert
            result.TotalCount.ShouldBe(2);
            result.Items.Count.ShouldBe(2);
            result.Items.Any(x => x.Id == Guid.Parse("85bbc19f-d5e7-47d0-94b5-a8602d91da67")).ShouldBe(true);
            result.Items.Any(x => x.Id == Guid.Parse("098dd5ce-4a92-405c-995e-4c6db6af0006")).ShouldBe(true);
        }

        [Fact]
        public async Task GetAsync()
        {
            // Act
            var result = await _categoriesAppService.GetAsync(Guid.Parse("85bbc19f-d5e7-47d0-94b5-a8602d91da67"));

            // Assert
            result.ShouldNotBeNull();
            result.Id.ShouldBe(Guid.Parse("85bbc19f-d5e7-47d0-94b5-a8602d91da67"));
        }

        [Fact]
        public async Task CreateAsync()
        {
            // Arrange
            var input = new CategoryCreateDto
            {
                Name = "1921db50e375",
                Description = "83406b72c2"
            };

            // Act
            var serviceResult = await _categoriesAppService.CreateAsync(input);

            // Assert
            var result = await _categoryRepository.FindAsync(c => c.Id == serviceResult.Id);

            result.ShouldNotBe(null);
            result.Name.ShouldBe("1921db50e375");
            result.Description.ShouldBe("83406b72c2");
        }

        [Fact]
        public async Task UpdateAsync()
        {
            // Arrange
            var input = new CategoryUpdateDto()
            {
                Name = "e815f17722d94ddf8c39d5e9929f4",
                Description = "3b260f7849e24c17b3a78fa9657"
            };

            // Act
            var serviceResult = await _categoriesAppService.UpdateAsync(Guid.Parse("85bbc19f-d5e7-47d0-94b5-a8602d91da67"), input);

            // Assert
            var result = await _categoryRepository.FindAsync(c => c.Id == serviceResult.Id);

            result.ShouldNotBe(null);
            result.Name.ShouldBe("e815f17722d94ddf8c39d5e9929f4");
            result.Description.ShouldBe("3b260f7849e24c17b3a78fa9657");
        }

        [Fact]
        public async Task DeleteAsync()
        {
            // Act
            await _categoriesAppService.DeleteAsync(Guid.Parse("85bbc19f-d5e7-47d0-94b5-a8602d91da67"));

            // Assert
            var result = await _categoryRepository.FindAsync(c => c.Id == Guid.Parse("85bbc19f-d5e7-47d0-94b5-a8602d91da67"));

            result.ShouldBeNull();
        }
    }
}