using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using JournalingApp.Data;
using JournalingApp.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("JournalingAppContextConnection") ?? throw new InvalidOperationException("Connection string 'JournalingAppContextConnection' not found.");

builder.Services.AddDbContext<JournalingAppContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<JournalingAppUser>(options => { options.SignIn.RequireConfirmedAccount = false;/*options.User.AllowedUserNameCharacters = "01";*/ })
    .AddEntityFrameworkStores<JournalingAppContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
