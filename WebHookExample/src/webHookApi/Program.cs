using Microsoft.EntityFrameworkCore;
using webHookApi.Infrastructure;
using webHookApi.Infrastructure.Respositories.Implementation;
using webHookApi.Presentation;
using webHookApi.Presentation.Payload;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebHookConnection"));
});

builder.Services.AddScoped<IPayLoadRepository, PayLoadRepository>();

var app = builder.Build();

EntryPointPayload.Post(app);

app.Run();
