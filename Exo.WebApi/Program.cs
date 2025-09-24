using ExoApi.Contexts;
using ExoApi.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ExoApiContext, ExoApiContext>();
builder.Services.AddControllers();
builder.Services.AddTransient<ProjetoRepository, ProjetoRepository>();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
