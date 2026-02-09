using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductMVC.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ProductMVCContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProductMVCContext") ?? throw new InvalidOperationException("Connection string 'ProductMVCContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
