using Microsoft.AspNetCore.Identity;
using OnlineAccountingAppServer.Domain.AppEntities.Identity;
using OnlineAccountingAppServer.WebAPI.Configurations;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .InstallServices(builder.Configuration, typeof(IServiceInstaller).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
    if(!userManager.Users.Any())
    {
        userManager.CreateAsync(new AppUser
        {
            UserName = "admin",
            Email = "test@test.com",
            Id = Guid.NewGuid().ToString(),
            FullName = "admin"
        }, password: "Password12*").Wait();
    }
}

app.Run();
