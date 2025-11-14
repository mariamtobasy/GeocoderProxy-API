using GeocoderProxy.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.Configure<GeocoderSettings>(builder.Configuration.GetSection("GeocoderSettings"));
builder.Services.AddHttpClient<GeocoderClient>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
