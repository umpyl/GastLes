using UmbrellaAcademy.Roster.Api.Common;
using UmbrellaAcademy.Roster.Data;
using UmbrellaAcademy.Roster.Data.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<RosterContext>();
builder.Services.RegisterDataDependencies();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        builder =>
        {
            builder.AllowAnyOrigin();
            builder.AllowAnyHeader();
            builder.AllowAnyMethod();
        });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

var options = new DefaultFilesOptions();
options.DefaultFileNames.Clear();
options.DefaultFileNames.Add("index.html");
app.UseDefaultFiles(options);
app.UseHttpsRedirection();

app.UseStaticFiles(new StaticFileOptions
{
    ContentTypeProvider = ContentTypeProvider.Default()
});

app.UseAuthorization();

app.MapControllers();

app.Run();
