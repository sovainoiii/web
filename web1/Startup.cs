using Microsoft.Extensions.Hosting;
internal class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {

    }
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseStaticFiles();
        app.UseRouting();
        app.UseEndpoints(async endpoints =>
        {
            endpoints.MapGet("/", async (context) =>
            {
                string html = "Trang chu";
                await context.Response.WriteAsync(html);
            });
            endpoints.MapGet("/about.html", async (context) =>
            {
                await context.Response.WriteAsync("Trang gioi thieu");
            });
            endpoints.MapGet("/contact", async (context) =>
            {
                await context.Response.WriteAsync("Trang lien he");
            });
        });
        app.UseStatusCodePages();
        //app.Map("/abc", app1 =>
        //{
        //    app1.Run(async (context) =>
        //    {
        //        await context.Response.WriteAsync("Day la trang tra ve ABC");
        //    });
        //});

        //app.Run(async (HttpContext context) =>
        //{
        //    await context.Response.WriteAsync("Day la Startup");
        //});
    }
}