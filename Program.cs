using Microsoft.EntityFrameworkCore;
using SiteBlazorServer.Components;
using SiteBlazorServer.Data;

var builder = WebApplication.CreateBuilder(args);
BuilderConfigure(builder);

var app = builder.Build();
AppConfigure(app);

app.Run();

void AppConfigure(WebApplication app)
{
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Error", createScopeForErrors: true);
        app.UseHsts();
    }
    
    app.UseHttpsRedirection();


    app.UseAntiforgery();

    app.MapStaticAssets();
    app.MapRazorComponents<App>()
        .AddInteractiveServerRenderMode();
}

void BuilderConfigure(WebApplicationBuilder builder)
{
    builder.Services.AddRazorComponents()
        .AddInteractiveServerComponents();

    builder.Services.AddDbContext<AppDataContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"))
    );
}