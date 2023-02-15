using SampleDemo.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace SampleDemo.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SampleDemoMongoDbModule),
    typeof(SampleDemoApplicationContractsModule)
)]
public class SampleDemoDbMigratorModule : AbpModule
{

}
