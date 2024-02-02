using CarDealership.BL.Interfaces;
using CarDealership.BL.Services;
using CarDealership.DL.Interfaces;
using CarDealership.DL.Repositories;
using FluentValidation;
using FluentValidation.AspNetCore;


namespace CarDealership
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddSingleton<ICarRepository, CarRepository>();
            builder.Services.AddSingleton<ICarService, CarService>();
            builder.Services.AddSingleton<IManufacturerRepository, ManufacturerRepository>();
            builder.Services.AddSingleton<IManufacturerService, ManufacturerService>();
            builder.Services.AddSingleton<ICarStoreService, CarStoreService>();
            
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddFluentValidationAutoValidation();
            builder.Services.AddValidatorsFromAssemblyContaining(typeof(Program));
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();

        }
    }
}