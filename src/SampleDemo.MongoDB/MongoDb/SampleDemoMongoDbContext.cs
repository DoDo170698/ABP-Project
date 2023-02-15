using SampleDemo.Categories;
using MongoDB.Driver;
using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace SampleDemo.MongoDB;

[ConnectionStringName("Default")]
public class SampleDemoMongoDbContext : AbpMongoDbContext
{
    public IMongoCollection<Category> Categories => Collection<Category>();

    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        //builder.Entity<YourEntity>(b =>
        //{
        //    //...
        //});

        modelBuilder.Entity<Category>(b => { b.CollectionName = SampleDemoConsts.DbTablePrefix + "Categories"; });
    }
}