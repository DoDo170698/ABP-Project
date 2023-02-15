using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace SampleDemoJob.MongoDB;

[ConnectionStringName(SampleDemoJobDbProperties.ConnectionStringName)]
public class SampleDemoJobMongoDbContext : AbpMongoDbContext, ISampleDemoJobMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureSampleDemoJob();
    }
}
