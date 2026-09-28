
using Microsoft.EntityFrameworkCore;
using SFSU_VeteranServices_Tracker.Api.Data;

namespace SFSU_VeteranServices_Tracker.Api
{
    public class Program
    {
        // The main entry point for the application
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add controllers to the API
            builder.Services.AddControllers();

            // Allows Swagger to discover API endpoints
            builder.Services.AddEndpointsApiExplorer();

            // Creates the Swagger documentation
            builder.Services.AddSwaggerGen();

            // Register EF Core and the database
            builder.Services.AddDbContext<VeteranServicesContext>(
                options =>
                    options.UseSqlServer(
                        builder.Configuration.GetConnectionString(
                            "VeteranServicesDatabase")));

            var app = builder.Build();


            // Only use Swagger while developing the application
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }


            app.UseHttpsRedirection();

            app.MapControllers();

            app.Run();
        }
    }
}
