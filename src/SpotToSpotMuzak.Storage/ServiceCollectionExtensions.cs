using System;
using System.Reflection;
using SpotToSpotMuzak.Server.Models;
using SpotToSpotMuzak.Shared;
using SpotToSpotMuzak.Shared.DataInterfaces;
using SpotToSpotMuzak.Shared.DataModels;
using SpotToSpotMuzak.Storage.Stores;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SpotToSpotMuzak.Storage
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterStorage(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<ApplicationDbContext>(builder => GetDbContextOptions(builder, Configuration)); // Look into the way we initialise the PB ways. Look at the old way they did this, with side effects on the builder. 
            services.AddScoped<IApplicationDbContext>(s => s.GetRequiredService<ApplicationDbContext>() as IApplicationDbContext);

            services.AddTransient<IMessageStore, MessageStore>();
            services.AddTransient<IUserProfileStore, UserProfileStore>();
            services.AddTransient<IToDoStore, ToDoStore>();
            //services.AddTransient<ITenantStore, TenantStore>();
            services.AddTransient<IApiLogStore, ApiLogStore>();
                       
            services.AddTransient<IDatabaseInitializer, DatabaseInitializer>();
            
            return services;
        }

        public static void GetDbContextOptions(DbContextOptionsBuilder builder, IConfiguration configuration)
        {
            var migrationsAssembly = "SpotToSpotMuzak.Storage";
            var useSqlServer = Convert.ToBoolean(configuration["SpotToSpotMuzak:UseSqlServer"] ?? "false");
            var dbConnString = useSqlServer
                ? configuration.GetConnectionString("DefaultConnection")
                : $"Filename={configuration.GetConnectionString("SqlLiteConnectionFileName")}";

            if (useSqlServer)
            {
                builder.UseSqlServer(dbConnString, sql => sql.MigrationsAssembly(migrationsAssembly));
            }
            else if (Convert.ToBoolean(configuration["SpotToSpotMuzak:UsePostgresServer"] ?? "false"))
            {
                builder.UseNpgsql(configuration.GetConnectionString("PostgresConnection"), sql => sql.MigrationsAssembly(migrationsAssembly));
            }
            else
            {
                builder.UseSqlite(dbConnString, sql => sql.MigrationsAssembly(migrationsAssembly));
            }
        }
        
        public static IIdentityServerBuilder AddIdentityServerStores(this IIdentityServerBuilder builder, IConfiguration configuration)
        => builder.AddConfigurationStore(options =>
            {
                options.ConfigureDbContext = x =>
                    ServiceCollectionExtensions.GetDbContextOptions(x, configuration);
            })
            .AddOperationalStore(options =>
            {
                options.ConfigureDbContext = x => ServiceCollectionExtensions.GetDbContextOptions(x, configuration);

                // this enables automatic token cleanup. this is optional.
                options.EnableTokenCleanup = true;
                
                options.TokenCleanupInterval = 3600; //In Seconds 1 hour
            });
        
    }
}