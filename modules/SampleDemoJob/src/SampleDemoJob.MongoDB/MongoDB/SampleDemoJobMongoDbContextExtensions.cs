using Volo.Abp;
using Volo.Abp.MongoDB;

namespace SampleDemoJob.MongoDB;

public static class SampleDemoJobMongoDbContextExtensions
{
    public static void ConfigureSampleDemoJob(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
