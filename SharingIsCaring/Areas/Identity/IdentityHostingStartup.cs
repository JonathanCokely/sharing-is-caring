using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SharingIsCaring.Areas.Identity.Data;
using SharingIsCaring.Data;

[assembly: HostingStartup(typeof(SharingIsCaring.Areas.Identity.IdentityHostingStartup))]
namespace SharingIsCaring.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SharingDbContext>(options =>
                    options.UseMySql(
                        context.Configuration.GetConnectionString("DefaultConnection")));
                //1/23 - Commented out this service because it was duplicated in Startup.cs
                //services.AddDefaultIdentity<SharingIsCaringUser>(options => options.SignIn.RequireConfirmedAccount = true)
                //    .AddEntityFrameworkStores<SharingDbContext>();
            });
        }
    }
}