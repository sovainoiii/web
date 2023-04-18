internal class Program
{
    private static void Main(string[] args)
    {
        //var builder = WebApplication.CreateBuilder(args);
        //var app = builder.Build();

        //app.MapGet("/", () => "Hello World ver2.0!");

        //app.Run();
        //IHostBuilder builder = Host.CreateDefaultBuilder(args);
        //builder.ConfigureWebHostDefaults((IWebHostBuilder webBuilder) =>
        //{
        //    webBuilder.UseWebRoot("public");
        //    webBuilder.UseStartup<Startup>();
        //});
        //IHost host = builder.Build();
        //host.Run();
        CreateHostBuilder(args).Build().Run();
    }
    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
    
}