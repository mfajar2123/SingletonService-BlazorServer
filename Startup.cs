using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BlazorCommentsApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Menambahkan layanan Blazor Server
            services.AddRazorPages();
            services.AddServerSideBlazor();

            // Menambahkan CommentService sebagai Singleton
            services.AddSingleton<CommentService>();

            // Menambahkan HttpClient
            services.AddHttpClient();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
