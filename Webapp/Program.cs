using WebApp.BLL.Services;
using WebApp.DAL.Context;
using WebApp.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using WebApp.Web.Views.Home;
using WebApp.Web.Views.Home.Order;
using WebApp.Web.Views.Home.User;

var builder = WebApplication.CreateBuilder(args);

// Добавление сервисов
builder.Services.AddControllersWithViews();

// Настройка контекста БД
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Регистрация репозиториев и сервисов
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();