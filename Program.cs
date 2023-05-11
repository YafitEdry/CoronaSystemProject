using BLL;
using DAL;
using Entity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddPolicy("policy", builder =>
    {
        builder.WithOrigins("http://localhost:3000")
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});
builder.Services.AddDbContext<CoronaSystemDbContext>(option => option.UseSqlServer("Data Source=desktop-6d4h651\\sqlexpress;Initial Catalog=CoronaSystem1;Integrated Security=True"));
builder.Services.AddScoped(typeof(IVaccineDetailsBLL), typeof(VaccineDetailsBLL));
builder.Services.AddScoped(typeof(ICoronaDetailsBLL), typeof(CoronaDetailsBLL));
builder.Services.AddScoped(typeof(IMembersBLL), typeof(MemberBLL));

builder.Services.AddScoped(typeof(IVaccineDetailsDal), typeof(VaccineDetailsDal));
builder.Services.AddScoped(typeof(ICoronaDetailsDal), typeof(CoronaDetailsDal));
builder.Services.AddScoped(typeof(IMembersDal), typeof(MemberDal));

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthorization();


var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();

}
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Dojo App"));

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();
app.UseHttpsRedirection();

app.UseCors("policy");
app.UseAuthorization();

app.Run();
