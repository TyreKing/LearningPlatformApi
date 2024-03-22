using LearningPlatform.API;
using LearningPlatform.Context;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
        .AddPresentation()
        .AddContext(builder.Configuration);
}

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.UseAuthentication();
    app.MapControllers();
    app.Run();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



