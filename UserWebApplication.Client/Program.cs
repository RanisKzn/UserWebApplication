using UserWebApplication.Client.Components;
using UserWebApplication.Client.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddHttpClient("Api", client =>
{
    client.BaseAddress = new Uri("https://localhost:7218");
});

builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<RequestService>();
builder.Services.AddScoped<RequestCategoryService>();
builder.Services.AddSingleton<IUserProvider, UserProvider>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
