using Serilog;

var builder = WebApplication.CreateBuilder(args); //appsetting.json verfügbar

//Serilog meldet sich als Logger in unserer ASP.NET Core Anwendung an
Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .CreateLogger();

// Add services to the container.
builder.Services.AddRazorPages();

//Serilog ist jetzt auch unserem IOC Container bekannt 
builder.Host.UseSerilog(); //UseSerilog ist eine Erweiterungs-Methode -> Wie genau Serilog registriert wird -> Die Varianten  -> AddTransient / AddScoped / AddSingleton -> AddMiddleware



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();


try
{
    Log.Information("Starting webapp");
    app.Run();
    return 0;
}
catch (Exception ex)
{
    Log.Fatal(ex, "Host terminated unexcpectedly");
    return 1;
}
finally
{
    Log.CloseAndFlush();
}


