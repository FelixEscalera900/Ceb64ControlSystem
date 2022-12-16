
using CEB64ControlSystem.Commands.Alumnos;
using CEB64ControlSystem.Commands.Grupos;
using CEB64ControlSystem.Data;
using CEB64ControlSystem.MappingProfiles;
using CEB64ControlSystem.Queries.Alumnos;
using CEB64ControlSystem.Queries.Grupos;
using CEB64ControlSystem.Queries.Periodos;
using CEB64ControlSystem.Queries.Semestres;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

builder.Services.AddAutoMapper(typeof(AlumnosMP),typeof(GruposMP));

builder.Services.AddScoped<ISemestreQueries, SemestreQueries>();
builder.Services.AddScoped<IPeriodoQueries, PeriodoQueries>();
builder.Services.AddScoped<IGruposQueries, GruposQueries>(); 
builder.Services.AddScoped<IGruposCommands, GruposCommands>();
builder.Services.AddScoped<IAlumnosQueries, AlumnosQueries>();
builder.Services.AddScoped<IAlumnosCommands, AlumnosCommands>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
