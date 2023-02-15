using Volo.Abp.Application;
using Volo.Abp.Authorization;
using Volo.Abp.Modularity;

namespace SampleDemoJob;

[DependsOn(
    typeof(SampleDemoJobDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationAbstractionsModule)
    )]
public class SampleDemoJobApplicationContractsModule : AbpModule
{

}
