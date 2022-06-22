//using RazorPageKurs.Configurations;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddRazorPages();

////1.) Wir binden eine weitere Konfigurationsquelle hinzu
//builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
//{
//    config.AddJsonFile("GameSettings.json", optional: true, reloadOnChange: true);
//});

////GameSettings wird als Configurations-Klasse im IOC Container hinterlegt 
//builder.Services.Configure<GameSettings>(builder.Configuration.GetSection("GameSettings"));


//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapRazorPages();

//app.Run();
