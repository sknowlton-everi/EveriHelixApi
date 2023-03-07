using EveriHelixAPI.Extensions;
using Serilog;

Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateBootstrapLogger();
Log.Information("Starting up");

try
{
    WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
    builder.bindConfig();

    builder.Logging.ClearProviders();

    builder.Host.UseSerilog((x, y) => y.WriteTo.Console().ReadFrom.Configuration(x.Configuration));

    builder.Services.AddHttpClients();
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwagger();
    builder.Services.AddServices();

    WebApplication app = builder.Build();
    //if (app.Environment.IsDevelopment())
    //{
    app.UseSwagger();
    app.UseCustomSwagger();
    //}

    app.UseSerilogRequestLogging();
    app.UseHttpsRedirection();
    app.UseAuthentication();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Unhandled exception");
}
finally
{
    Log.Information("Shut down complete");
    Log.CloseAndFlush();
}