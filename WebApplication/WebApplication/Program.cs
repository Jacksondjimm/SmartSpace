using Microsoft.EntityFrameworkCore;
using RazorPagesApp.Models;// ������������ ���� ������ ApplicationContext

var builder = WebApplication.CreateBuilder(args);

// �������� ������ ����������� �� ����� ������������
string connection = builder.Configuration.GetConnectionString("DefaultConnection");

// ��������� �������� ApplicationContext � �������� ������� � ����������
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));

// ��������� � ���������� ������� Razor Pages
builder.Services.AddRazorPages();
var app = builder.Build();

// ��������� ��������� ������������� ��� Razor Pages
app.MapRazorPages();

app.Run();
