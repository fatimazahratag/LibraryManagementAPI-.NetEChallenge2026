var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<LibraryManagementAPI.Services.BookService>();

var app = builder.Build();

app.MapControllers();

app.Run();
