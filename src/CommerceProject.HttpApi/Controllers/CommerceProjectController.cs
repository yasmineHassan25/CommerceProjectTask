using CommerceProject.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CommerceProject.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CommerceProjectController : AbpControllerBase
{
    protected CommerceProjectController()
    {
        LocalizationResource = typeof(CommerceProjectResource);
    }
}
