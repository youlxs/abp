﻿using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Volo.Abp.Identity.EntityFrameworkCore
{
    [DependsOn(typeof(AbpIdentityModule), typeof(AbpEntityFrameworkCoreModule))]
    public class AbpIdentityEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddAbpDbContext<IdentityDbContext>();
            services.AddDefaultEfCoreRepositories<IdentityDbContext>(); //TODO: Move this into AddAbpDbContext as optional which will have it's own options
            services.AddAssemblyOf<AbpIdentityEntityFrameworkCoreModule>();
        }
    }
}
