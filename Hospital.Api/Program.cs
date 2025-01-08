using FluentValidation;
using FluentValidation.AspNetCore;
using Hospital.Bl.Profiles.InsuranceProfiles;

using Hospital.Bl.Profiles.PatientProfiles;
using Hospital.Bl.Services.Abstraction;
using Hospital.Bl.Services.Implementation;
using Hospital.Bl.Validations.InsuranceValidations;
using Hospital.Bl.Validations.PatientValidations;
using Hospital.Data.Contexts;
using Hospital.Data.Repositories.Abstraction;
using Hospital.Data.Repositories.Implementation;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddDbContext<HospitalApiDbContext>(opt =>
        {
            opt.UseSqlServer(builder.Configuration.GetConnectionString("Hp"));
        });
        builder.Services.AddAutoMapper(typeof(PatientProfile));
        builder.Services.AddAutoMapper(typeof(InsuranceProfile));
     
        builder.Services.AddScoped<IPatientRepository, PatientRepository>();
        builder.Services.AddScoped<IPatienceService, PatienceService>();
        builder.Services.AddScoped<IInsuranceRepository, InsuranceRepository>();
        builder.Services.AddScoped<IInsuranceService, InsuranceService>();
        builder.Services.AddValidatorsFromAssembly(typeof(CreatePatientValidator).Assembly);
        builder.Services.AddValidatorsFromAssembly(typeof(UpdatePatientValidator).Assembly);
        builder.Services.AddValidatorsFromAssembly(typeof(CreateInsuranceValidator).Assembly);
        builder.Services.AddValidatorsFromAssembly(typeof(UpdateInsuranceValidator).Assembly);
        builder.Services.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters();
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