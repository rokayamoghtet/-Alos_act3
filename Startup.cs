using Microsoft.OpenApi.Models;

namespace DelaiLivraisonAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DelaiLivraisonAPI", Version = "v1" });
            });

            // Updating the middlewear to use versioning.
            services.AddApiVersioning(opt => {
                opt.AssumeDefaultVersionWhenUnspecified = true;
                opt.DefaultApiVersion = ApiVersion.Default;

                // this is going to return all available api versions
                opt.ReportApiVersions = true;

                // Add Media type versioning
                opt.ApiVersionReader = ApiVersionReader.Combine(
                    new HeaderApiVersionReader("x-api-version"),
                    new MediaTypeApiVersionReader("x-api-version")
                );
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DelaiLivraisonAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}