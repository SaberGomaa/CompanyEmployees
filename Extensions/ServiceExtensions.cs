namespace CompanyEmployees.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
        services.AddCors(
            options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            });

        public static void ConfiguerIISIntergration(this IServiceCollection services) =>
            services.Configure<IISOptions>(
                options =>
                {
                    // some options 

                    //options.AutomaticAuthentication = true;
                    //options.AuthenticationDisplayName =null;
                    //options.ForwardClientCertificate = true;

                });
    }
}
