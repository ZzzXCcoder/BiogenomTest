using Biogenom.Data;
using Biogenom.Repository;
using Biogenom.Service;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IAssessmentResultRepository, AssessmentResultRepository>();
builder.Services.AddScoped<IAssessmentService, AssessmentService>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Biogenom API V1");
    c.RoutePrefix = "";
});


app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();
app.Run();
