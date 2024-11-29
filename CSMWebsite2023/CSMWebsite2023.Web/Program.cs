using CSMWebsite2023.EntityFramework;
using CSMWebsite2023.Services.Common;
using CSMWebsite2023.MySql.Infrastructure;
using Microsoft.EntityFrameworkCore;
using CSMWebsite2023.Contracts;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContextFactory<DefaultDbContext>(
            dbContextOptions => dbContextOptions
               .UseMySql(builder.Configuration.GetConnectionString("DefaultConnectionString"),
                   ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnectionString")),
                      mySqlOptions =>
                      {
                          mySqlOptions.EnableRetryOnFailure(
                            maxRetryCount: 10,
                            maxRetryDelay: TimeSpan.FromSeconds(30),
                            errorNumbersToAdd: null);
                          mySqlOptions.MigrationsAssembly(typeof(Program).Namespace);
                      })
               .LogTo(Console.WriteLine, LogLevel.Information)
               .EnableSensitiveDataLogging()
               .EnableDetailedErrors()
);
    
builder.Services.AddDataRepositories();
builder.Services.AddServices();
builder.Services.AddAutoMapper(typeof(Program), typeof(IService));

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.Cookie.Name = ".CSMWebsite2023.session";
    options.IdleTimeout = TimeSpan.FromSeconds(100);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});


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
app.UseSession();

app.MapRazorPages();

app.Run();
