using BookingService.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register in-memory repository
builder.Services.AddSingleton<IRoomRepository, InMemoryRoomRepository>();

// Allow Angular dev server + GitHub Pages origin; for local keep open
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllDev", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAllDev");
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
