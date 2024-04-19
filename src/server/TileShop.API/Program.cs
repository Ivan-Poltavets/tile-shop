using System.Security.Claims;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using TileShop.API;
using TileShop.Domain.Entities;
using TileShop.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddServices(builder.Configuration);
builder.Services.AddRepositories();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwagger();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddJwtAuthentication(builder.Configuration);
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("RequireAdmin",
        policy => policy.RequireClaim(ClaimTypes.Role, UserRole.Admin.ToString()));
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options => 
    { 
        options.SwaggerEndpoint("/swagger/V1/swagger.json", "ClientApp");
    });
}

using(var scope = app.Services.CreateScope())
{
    var appContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    if (!appContext.Database.GetService<IRelationalDatabaseCreator>().Exists())
    {
        try
        {
            appContext.Database.EnsureCreated();
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Migration has failes: {ex.Message}");
        }
    }

    var admin = appContext.Users.FirstOrDefault(x => x.Id == 1);
    if(admin is null)
    {
        appContext.Users.Add(new User
        {
            LastName = "Admin",
            FirstName = "Admin",
            Email = "admin@gmail.com",
            Role = UserRole.Admin,
            PasswordHash = "EcsZlEhb0tq+4U3afErNTP44ruxqK0j+D1g/gd0zlGw=",
            PasswordSalt = "72998128-d8ad-4688-b06f-63d329330f71",
            PhoneNumber = "11119999"
        });
    }
    appContext.SaveChanges();
}

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();