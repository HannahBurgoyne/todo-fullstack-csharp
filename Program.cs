// This code is the entry point of the ASP.NET Core application 

// Creates a new instance of a web application, using the provided CLI args 
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Adds support for controllers with views, to make it compatible with an MVC architecture  
builder.Services.AddControllersWithViews();

// Builds the app with the specified configuration 
var app = builder.Build();

// Configure the HTTP request pipeline.
// If the app is not in a development env, use a specific error page when errors occur, and require an HTTPS connection
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

// Sets up routing for the application, so that it knows which controller and action to execute based on the URL req
app.UseRouting();

// Protect parts of app based on your defined policies 
app.UseAuthorization();

// Configures the default route for your app - root URL defaults to Index in the Home controller 
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
