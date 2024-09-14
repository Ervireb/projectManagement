using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using teamManagment.Data;
using teamManagment.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<teamManagmentContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("teamManagmentContext")
    ?? throw new InvalidOperationException("Connection string 'teamManagmentContext' not found.")));

builder.Services.AddDefaultIdentity<IdentityUser>(options =>
    options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<teamManagmentContext>();

// Fix missing parenthesis
builder.Services.AddDbContext<IssueDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SQLServer"))); // Fixed line

builder.Services.AddControllersWithViews(); // Add MVC services

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    SeedData.Initialize(services); // Seed data only once
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

// Add controller route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

#if (DEBUG)
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<teamManagmentContext>();
    dbContext.Database.EnsureCreated();

    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

    SeedData.Initialize(scope.ServiceProvider); // This can be removed if you only want to seed once
}
#endif

app.Run();
