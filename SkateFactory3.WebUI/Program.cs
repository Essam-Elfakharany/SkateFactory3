using Microsoft.EntityFrameworkCore;
using SkateFactory3.Data;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

string connectionString = builder.Configuration.GetConnectionString("SkateboardCN")!;
connectionString = connectionString.Replace("{APP_DATA_PATH}", builder.Environment.ContentRootPath + "App_Data");

builder.Services.AddDbContext<SkateFactoryContext>(options => { 
    options.UseSqlServer(connectionString);
});

builder.Services.AddDefaultIdentity<IdentityUser>(options =>
{ //*** Just for learning purposes (WEAKENING YOUR SECURITY IS NOT RECOMMENDED) ***
    options.Password.RequireDigit = false; //default: true
    options.Password.RequireLowercase = false; //default: true
    options.Password.RequireUppercase = false; //default: true
    options.Password.RequireNonAlphanumeric = false; //default: true
}).AddEntityFrameworkStores<SkateFactoryContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapRazorPages();
});

app.Run();
