using System.Threading.Tasks;

namespace SampleDemo.Data;

public interface ISampleDemoDbSchemaMigrator
{
    Task MigrateAsync();
}
