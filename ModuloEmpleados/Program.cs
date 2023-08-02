var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();
app.Use(async (context, next) =>
{
    context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
    await next.Invoke();
});

// The first thing in the chain of calls is to define the CORS
app.UseCors(builder =>
{
    builder
          .WithOrigins("http://localhost:7122", "https://localhost:7122")
          .SetIsOriginAllowedToAllowWildcardSubdomains()
          .AllowAnyHeader()
          .AllowCredentials()
          .WithMethods("GET", "PUT", "POST", "DELETE", "OPTIONS")
          .SetPreflightMaxAge(TimeSpan.FromSeconds(3600));
}
);

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
