using SampleDemoJob.MongoDB;
using Volo.Abp.Modularity;

namespace SampleDemoJob;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(SampleDemoJobMongoDbTestModule)
    )]
public class SampleDemoJobDomainTestModule : AbpModule
{

}
