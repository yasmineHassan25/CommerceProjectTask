using Microsoft.Extensions.Localization;
using CommerceProject.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace CommerceProject;

[Dependency(ReplaceServices = true)]
public class CommerceProjectBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<CommerceProjectResource> _localizer;

    public CommerceProjectBrandingProvider(IStringLocalizer<CommerceProjectResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
