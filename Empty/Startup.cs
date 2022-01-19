namespace Empty
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();  // с помощью вызова services.AddMvc() добавляются все сервисы MVC. После этого мы можем использовать фреймворк.
        }
        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting(); // В методе Configure() через вызовы app.UseRouting() и app.UseEndpoints() встраивается система маршрутизации, которая позволяет связать приходящие от пользователей запросы с контроллерами.

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
