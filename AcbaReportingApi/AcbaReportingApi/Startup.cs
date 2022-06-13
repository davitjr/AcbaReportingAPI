using AcbaReportsApi.Extensions;
using AcbaReportsApi.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace AcbaReportsApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private readonly IConfiguration Configuration;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpContextAccessor();

            services.AddLocalization(options => options.ResourcesPath = "Resources");

            services.AddHttpClients(Configuration);

            services.AddDependencieInjections(Configuration);

            services.AddControllerConfigurations();

            services.AddSwaggerConfigurations();

            services.AddAutoMapperConfigurations();

            services.AddMemoryCache();

            services.AddHealthChecks();

            services.AddCors(options =>
            {
                options.AddPolicy(name: "MyCors",
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                               .AllowAnyHeader()
                               .AllowAnyMethod();
                    });
            });

            services.AddResponseCompression(options =>
            {
                options.EnableForHttps = true;
                options.MimeTypes = new[] { "text/plain", "application/json" };
                options.Providers.Add<GzipCompressionProvider>();
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwaggerConfigurations();
            }
            else
            {
                app.UseSwaggerConfigurations();
                app.UseHsts();
            }

            app.UseResponseCompression();

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseCors("MyCors");

            app.UseAuthentication();

            app.UseAuthorization();

            if (Convert.ToBoolean(Configuration["EnableLoggingMiddleware"]))
            {
                app.UseMiddleware<RequestResponseLoggingMiddleware>();
            }
       
            app.UseAutoWrapperWithConfigurations();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHealthChecks("/health");
            });
        }
    }
}
