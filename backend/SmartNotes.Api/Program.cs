using SmartNotes.Api;

var builder = WebApplication.CreateBuilder(args);

// Create instance of Startup
var startup = new Startup(builder.Configuration);

// Call Startup.ConfigureServices()
startup.ConfigureServices(builder.Services);

var app = builder.Build();

// Call Startup.Configure()
startup.Configure(app, app.Environment);

app.Run();
