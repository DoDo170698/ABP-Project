using Shouldly;
using System;
using System.Linq;
using System.Threading.Tasks;
using SampleDemo.Categories;
using SampleDemo.MongoDB;
using Xunit;

namespace SampleDemo.Categories
{
    [Collection(SampleDemoTestConsts.CollectionDefinitionName)]
    public class CategoryRepositoryTests : SampleDemoMongoDbTestBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryRepositoryTests()
        {
            _categoryRepository = GetRequiredService<ICategoryRepository>();
        }

        [Fact]
        public async Task GetListAsync()
        {
            // Arrange
            await WithUnitOfWorkAsync(async () =>
            {
                // Act
                var result = await _categoryRepository.GetListAsync(
                    name: "618c275dd68347449530df91891a384b84c0045d28b5472aa6b8c3b3c95f4ed716c988d6a08f4ff6ac30",
                    description: "e674dce3e8b948bea0a502a4e1b7ce951f98378311a"
                );

                // Assert
                result.Count.ShouldBe(1);
                result.FirstOrDefault().ShouldNotBe(null);
                result.First().Id.ShouldBe(Guid.Parse("85bbc19f-d5e7-47d0-94b5-a8602d91da67"));
            });
        }

        [Fact]
        public async Task GetCountAsync()
        {
            // Arrange
            await WithUnitOfWorkAsync(async () =>
            {
                // Act
                var result = await _categoryRepository.GetCountAsync(
                    name: "3f08d6f4b59b4e949f35988136660b8f510bc89f8e3",
                    description: "c78700e"
                );

                // Assert
                result.ShouldBe(1);
            });
        }
    }
}