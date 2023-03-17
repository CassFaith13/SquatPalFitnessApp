using Microsoft.EntityFrameworkCore;
using SquatPal.Data.DatabaseContext;
using SquatPal.Services.Services.IServices;
using SquatPal.Services.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options => 
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Dependency Injections
builder.Services.AddScoped<IAdminUserService,AdminUserService>();
builder.Services.AddScoped<IClientService,ClientService>();
builder.Services.AddScoped<IExercisePlanService,ExercisePlanService>();
builder.Services.AddScoped<IMembershipTierService,MembershipTierService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
