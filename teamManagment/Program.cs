using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using teamManagment.Data;
using teamManagment.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddRazorPages();
builder.Services.AddControllers().AddNewtonsoftJson();

// Configure DbContexts
builder.Services.AddDbContext<teamManagmentContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("teamManagmentContext")
    ?? throw new InvalidOperationException("Connection string 'teamManagmentContext' not found.")));

builder.Services.AddDbContext<IssueDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SQLServer")));

builder.Services.AddDbContext<TodoContext>(opt =>
    opt.UseInMemoryDatabase("TodoList")); // Configure TodoContext with In-Memory Database

// Add Identity and scoped services
builder.Services.AddDefaultIdentity<IdentityUser>(options =>
    options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<teamManagmentContext>();

// Add Controllers with Views
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Seed initial data
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    SeedData.Initialize(services); // Seed data only once
}

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Register routes at top-level
app.MapRazorPages();    // Map Razor Pages
app.MapControllers();   // Map Controllers

// Add default controller route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

#if (DEBUG)
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<teamManagmentContext>();
    dbContext.Database.EnsureCreated();

    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

    SeedData.Initialize(scope.ServiceProvider); // Seed data for development
}
#endif

app.Run();