using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace SampleDemoJob.MongoDB;

[ConnectionStringName(SampleDemoJobDbProperties.ConnectionStringName)]
public interface ISampleDemoJobMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
