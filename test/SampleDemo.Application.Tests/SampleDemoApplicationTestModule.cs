using Volo.Abp.Modularity;

namespace SampleDemo;

[DependsOn(
    typeof(SampleDemoApplicationModule),
    typeof(SampleDemoDomainTestModule)
    )]
public class SampleDemoApplicationTestModule : AbpModule
{

}
