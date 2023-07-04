var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//routes cartographiée via des conventions
//configure un itineraire conventionnel par defaut vers les controlleurs
app.MapControllerRoute(
    name: "default",
    //nom du controlleur, action/methode du controlleur, id optionnel
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
