using CSEhelp.Utilities;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.GetSection("SocialLinks").Bind(AppSocialLinks.Values);
builder.Configuration.GetSection("Settings").Bind(AppSettings.Settings);

builder.Services.RegisterServices();

builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var adminSeeder = scope.ServiceProvider.GetRequiredService<ServiceRegistry.IAdminSeeder>();
    await adminSeeder.SeedAdminUserAsync();
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
        name: "areas",
        pattern: "{area:exists}/{controller=UserController}/{action=Login}/{id?}"
    ).WithStaticAssets();

app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
