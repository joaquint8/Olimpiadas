using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Olimpiadas2023.Models;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConexion");
builder.Services.AddDbContextFactory<CodigoAzulContext>(options =>
    options.UseSqlServer(connectionString)
);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddAntDesign();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
//Creacion de API
// Agregamos servicios al contenedor
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // El middleware HSTS predeterminado agrega la cabecera Strict-Transport-Security.
    app.UseHsts();
}


// Agrega servicios al contenedor.
builder.Services.AddRazorPages();
//builder.Services.AddServerSideBlazor();

// Habilita CORS
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AllowSpecificOrigin",
//        builder =>
//        {
//            builder.WithOrigins("http://localhost:5000/VistaMovil") // Reemplaza con la URL de tu ProyectoB
//                   .AllowAnyHeader()
//                   .AllowAnyMethod();
//        });
//});


app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
