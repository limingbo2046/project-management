using lcn.project_management.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace lcn.project_management.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class project_managementController : AbpController
    {
        protected project_managementController()
        {
            LocalizationResource = typeof(project_managementResource);
        }
    }
}