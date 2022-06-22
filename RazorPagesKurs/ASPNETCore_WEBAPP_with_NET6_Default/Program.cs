WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages(); //Wir sagen dem IOC Container, dass wir RazorPages verwenden und viele weitere Dienste 

/*
builder.Services.AddControllersWithViews(); // MVC Framework
builder.Services.AddControllers(); //WebAPI 
builder.Services.AddMvc(); //AddRazorPages + AddControllersWithViews
*/


WebApplication app = builder.Build(); //Nach Build, können keine weiteren Dienste / Objekten dem IOC Container hinzufügen 


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

app.Run();
