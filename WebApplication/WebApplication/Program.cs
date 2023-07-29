using Microsoft.EntityFrameworkCore;
using RazorPagesApp.Models;// пространство имен класса ApplicationContext

var builder = WebApplication.CreateBuilder(args);

// получаем строку подключения из файла конфигурации
string connection = builder.Configuration.GetConnectionString("DefaultConnection");

// добавляем контекст ApplicationContext в качестве сервиса в приложение
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));

// добавляем в приложение сервисы Razor Pages
builder.Services.AddRazorPages();
var app = builder.Build();

// добавляем поддержку маршрутизации для Razor Pages
app.MapRazorPages();

app.Run();
