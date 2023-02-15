using SampleDemo.Localization;
using Volo.Abp.Application.Services;

namespace SampleDemo;

/* Inherit your application services from this class.
 */
public abstract class SampleDemoAppService : ApplicationService
{
    protected SampleDemoAppService()
    {
        LocalizationResource = typeof(SampleDemoResource);
    }
}
