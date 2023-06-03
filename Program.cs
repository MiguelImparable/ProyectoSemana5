using Microsoft.EntityFrameworkCore;
using ProyectoSemana5.Context;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<FachadaContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("OPAConexion")));
var app = builder.Build();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();