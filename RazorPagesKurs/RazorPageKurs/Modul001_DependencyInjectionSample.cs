//using RazorPageKurs.Services;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddRazorPages();

////Wir legen unseren Service hier ab
//builder.Services.AddSingleton<IRequestCounter, RequestCounter>();

//builder.Services.AddSingleton(typeof(RequestCounter2));
//var app = builder.Build(); //serviceCollection.BuildServiceProvider wird in builder.Build aufgerufen 



//IRequestCounter requestCounter1 = app.Services.GetRequiredService<IRequestCounter>();
//RequestCounter2 requestCounterObj1 = app.Services.GetRequiredService<RequestCounter2>();


//using (IServiceScope scope = app.Services.CreateScope())
//{
//    IRequestCounter requestCounter2 = scope.ServiceProvider.GetRequiredService<IRequestCounter>();
//    RequestCounter2 requestCounterObj2 = scope.ServiceProvider.GetRequiredService<RequestCounter2>();
//}

//    // Configure the HTTP request pipeline.
//    if (!app.Environment.IsDevelopment())
//    {
//        app.UseExceptionHandler("/Error");
//        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//        app.UseHsts();
//    }

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapRazorPages();

//app.Run();
