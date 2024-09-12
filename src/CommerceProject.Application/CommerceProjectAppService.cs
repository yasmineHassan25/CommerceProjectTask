using System;
using System.Collections.Generic;
using System.Text;
using CommerceProject.Localization;
using Volo.Abp.Application.Services;

namespace CommerceProject;

/* Inherit your application services from this class.
 */
public abstract class CommerceProjectAppService : ApplicationService
{
    protected CommerceProjectAppService()
    {
        LocalizationResource = typeof(CommerceProjectResource);
    }
}
