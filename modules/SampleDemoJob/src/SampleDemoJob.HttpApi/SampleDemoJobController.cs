using SampleDemoJob.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SampleDemoJob;

public abstract class SampleDemoJobController : AbpControllerBase
{
    protected SampleDemoJobController()
    {
        LocalizationResource = typeof(SampleDemoJobResource);
    }
}
