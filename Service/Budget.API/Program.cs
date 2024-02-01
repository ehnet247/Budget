using Microsoft.EntityFrameworkCore;
using Budget.Api.Models;
using System.Configuration;

namespace Budget.API;

    public class Program
    {
        public static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
        .AddInMemoryCollection(new Dictionary<string, string?>()).Build();
        var builder = WebApplication.CreateBuilder(args);
        var connectionString = builder.Configuration["Budget.API:ConnectionString"];
        bool connectionStringNull = string.IsNullOrEmpty(connectionString);
        if (!connectionStringNull)
        {
            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddDbContext<BudgetContext>(opt =>
            opt.UseMySQL(connectionString!));

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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
