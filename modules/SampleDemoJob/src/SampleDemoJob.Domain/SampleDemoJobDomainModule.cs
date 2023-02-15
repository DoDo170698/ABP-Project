using Volo.Abp.Caching;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace SampleDemoJob;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(AbpCachingModule),
    typeof(SampleDemoJobDomainSharedModule)
)]
public class SampleDemoJobDomainModule : AbpModule
{

}
