using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ZipLink.Domain.Entities.Identity;
using ZipLink.Infrastructure.Identity.Services;
using ZipLink.Infrastructure.Persistence.DbContexts;

namespace ZipLink.Infrastructure.Identity;

public static class Startup
{
	/// <summary>
	///     Add custom identity user, roles, etc.
	/// </summary>
	public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
	{
		services.AddIdentity<ApplicationUser, ApplicationRole>()
			.AddEntityFrameworkStores<ApplicationDbContext>()
			.AddClaimsPrincipalFactory<ApplicationClaimsPrincipalFactory>()
			.AddDefaultTokenProviders();
	}

	public static void Configure(IApplicationBuilder app, IConfiguration configuration)
	{
	}
}

