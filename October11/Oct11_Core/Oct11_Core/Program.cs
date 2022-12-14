using Microsoft.CodeAnalysis.MSBuild;
using Oct11_Core.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<ITransientService, OperationServices>(); 
builder.Services.AddScoped<IScopedService, OperationServices>();
builder.Services.AddSingleton<ISingletonService,OperationServices>();
builder.Services.AddSession(options => options.IdleTimeout = TimeSpan.FromMinutes(1));

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
app.UseSession();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
