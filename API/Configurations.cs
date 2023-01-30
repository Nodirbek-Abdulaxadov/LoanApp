using Data;
using Data.Interfaces;
using Data.Repositories;
using Messager;
using Microsoft.EntityFrameworkCore;

namespace API
{
    public static class Configurations
    {
        public static void AddServices( this IServiceCollection services, 
                                        ConfigurationManager configuration)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            // Add Db context with PostgreSql
            services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("LocalDB")));

            // Add DI services
            services.AddTransient<ILoanInterface, LoanRepository>();
            services.AddTransient<IPaymentInterface, PaymentRepository>();
            services.AddTransient<IUserInterface, UserRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddTransient<IMessageService, Message>();
        }

        public static void AddApplicationPipeline(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
