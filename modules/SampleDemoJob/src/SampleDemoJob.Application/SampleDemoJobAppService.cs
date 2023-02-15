using SampleDemoJob.Localization;
using Volo.Abp.Application.Services;

namespace SampleDemoJob;

public abstract class SampleDemoJobAppService : ApplicationService
{
    protected SampleDemoJobAppService()
    {
        LocalizationResource = typeof(SampleDemoJobResource);
        ObjectMapperContext = typeof(SampleDemoJobApplicationModule);
    }
}
