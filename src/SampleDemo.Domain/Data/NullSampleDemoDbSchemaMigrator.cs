using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SampleDemo.Data;

/* This is used if database provider does't define
 * ISampleDemoDbSchemaMigrator implementation.
 */
public class NullSampleDemoDbSchemaMigrator : ISampleDemoDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
