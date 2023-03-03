using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using SquatPal.Data.DatabaseContext;
using SquatPal.Services.Services;
using SquatPal.Services.Services.IServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
// builder.Services.AddSingleton<ClientService>();

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddServerSideBlazor().AddCircuitOptions(x => x.DetailedErrors = true);
}
else
{
builder.Services.AddServerSideBlazor();
}

// AutoMapper

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();