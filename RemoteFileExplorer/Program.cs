using RemoteFileExplorer.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ExplorerDb>(option =>
{
    option.UseSqlite(builder.Configuration.GetConnectionString("Sqlite"));
});

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    using var scope = app.Services.CreateScope();
    var db = scope.ServiceProvider.GetRequiredService<ExplorerDb>();
    db.Database.EnsureCreated();
}

app.Run();
