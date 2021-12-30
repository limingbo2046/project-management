using System;
using System.Collections.Generic;
using System.Text;
using lcn.project_management.Localization;
using Volo.Abp.Application.Services;

namespace lcn.project_management
{
    /* Inherit your application services from this class.
     */
    public abstract class project_managementAppService : ApplicationService
    {
        protected project_managementAppService()
        {
            LocalizationResource = typeof(project_managementResource);
        }
    }
}
