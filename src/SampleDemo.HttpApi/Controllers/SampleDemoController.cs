using SampleDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SampleDemo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SampleDemoController : AbpControllerBase
{
    protected SampleDemoController()
    {
        LocalizationResource = typeof(SampleDemoResource);
    }
}
