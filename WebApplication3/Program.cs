using WebApplication3.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
//registering in DI container 
builder.Services.AddSingleton<IStudentRepository,MockStudentRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    // The default HSTS value is 30 da
    // ys. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseDefaultFiles(); //for use default file default.hmtl as 1st page to load
app.UseHttpsRedirection();
app.UseStaticFiles();


app.UseRouting();
//conventional routing
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Details}/{id?}"
        );
});
app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
});

app.UseAuthorization();

app.MapRazorPages();

app.Run();  