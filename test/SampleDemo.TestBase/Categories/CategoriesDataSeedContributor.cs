using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Uow;
using SampleDemo.Categories;

namespace SampleDemo.Categories
{
    public class CategoriesDataSeedContributor : IDataSeedContributor, ISingletonDependency
    {
        private bool IsSeeded = false;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWorkManager _unitOfWorkManager;

        public CategoriesDataSeedContributor(ICategoryRepository categoryRepository, IUnitOfWorkManager unitOfWorkManager)
        {
            _categoryRepository = categoryRepository;
            _unitOfWorkManager = unitOfWorkManager;

        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (IsSeeded)
            {
                return;
            }

            await _categoryRepository.InsertAsync(new Category
            (
                id: Guid.Parse("85bbc19f-d5e7-47d0-94b5-a8602d91da67"),
                name: "618c275dd68347449530df91891a384b84c0045d28b5472aa6b8c3b3c95f4ed716c988d6a08f4ff6ac30",
                description: "e674dce3e8b948bea0a502a4e1b7ce951f98378311a"
            ));

            await _categoryRepository.InsertAsync(new Category
            (
                id: Guid.Parse("098dd5ce-4a92-405c-995e-4c6db6af0006"),
                name: "3f08d6f4b59b4e949f35988136660b8f510bc89f8e3",
                description: "c78700e"
            ));

            await _unitOfWorkManager.Current.SaveChangesAsync();

            IsSeeded = true;
        }
    }
}