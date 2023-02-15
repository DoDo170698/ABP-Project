using SampleDemo.MongoDB;
using Volo.Abp.Modularity;

namespace SampleDemo;

[DependsOn(
    typeof(SampleDemoMongoDbTestModule)
    )]
public class SampleDemoDomainTestModule : AbpModule
{

}
