using BLOGAPI.src.Base.Db;
using BLOGAPI.src.Contracts.Repository;
using BLOGAPI.src.Contracts.Service;
using BLOGAPI.src.Repository;
using BLOGAPI.src.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetValue<string>("ConnectionStrings:postgre");

builder.Services.AddDbContext<DataContext>(x => x.UseNpgsql(connectionString));
builder.Services.AddScoped<IUsuariosService, UsuarioService>();
builder.Services.AddScoped<IUsuariosRepository, UsuariosRepository>();
builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddScoped<IPostsRepository, PostRepository>();
builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddScoped<ICategoriaService, CategoriaService>();

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
