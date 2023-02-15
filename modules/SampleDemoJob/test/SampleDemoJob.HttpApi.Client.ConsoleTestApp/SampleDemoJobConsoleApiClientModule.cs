using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace SampleDemoJob;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SampleDemoJobHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class SampleDemoJobConsoleApiClientModule : AbpModule
{

}
