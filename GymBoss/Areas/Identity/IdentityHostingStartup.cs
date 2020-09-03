using System;
using GymBoss.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(GymBoss.Areas.Identity.IdentityHostingStartup))]
namespace GymBoss.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            /*
            builder.ConfigureServices((context, services) => {
                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<GymBossContext>();
            }); */
            builder.ConfigureServices((context, services) => {
            services.AddDbContext<GymBossContext>(options =>
                options.UseSqlite(
                    context.Configuration.GetConnectionString("DefaultConnection")));
            });
            /*
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<GymBossContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("GymBossContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<GymBossContext>();
            }); */
        }
    }
}