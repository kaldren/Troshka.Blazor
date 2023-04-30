using Blazored.Toast;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web;
using Microsoft.Identity.Web.UI;
using Radzen;
using Troshka.Blazor.Data;
using Troshka.Blazor.Infrastructure.Data;
using Troshka.Blazor.Services.Category;
using Troshka.Blazor.Services.Coupe;
using Troshka.Blazor.Services.Currency;
using Troshka.Blazor.Services.Engine;
using Troshka.Blazor.Services.EuroStandard;
using Troshka.Blazor.Services.FileStorage;
using Troshka.Blazor.Services.Material;
using Troshka.Blazor.Services.Offer;
using Troshka.Blazor.Services.Region;
using Troshka.Blazor.Services.Transmission;
using Troshka.Blazor.Services.User;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthentication(OpenIdConnectDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApp(builder.Configuration.GetSection("AzureAd"));
builder.Services.AddControllersWithViews()
    .AddMicrosoftIdentityUI();

builder.Services.AddAuthorization(options =>
{
    // By default, all incoming requests will be authorized according to the default policy
    options.FallbackPolicy = options.DefaultPolicy;
});

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor()
    .AddMicrosoftIdentityConsentHandler();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddDbContextFactory<TroshkaDbContext>(opt =>
        opt
        .UseLazyLoadingProxies()
        .UseSqlServer(builder.Configuration.GetValue<string>("Troshka:ConnectionString")));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<DialogService>();

builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICarBrandService, CarBrandService>();
builder.Services.AddScoped<ICarModelService, CarModelService>();
builder.Services.AddScoped<ICarCoupeService, CarCoupeService>();
builder.Services.AddScoped<IRegionService, RegionService>();
builder.Services.AddScoped<IEngineService, EngineService>();
builder.Services.AddScoped<ITransmissionService, TransmissionService>();
builder.Services.AddScoped<ICurrencyService, CurrencyService>();
builder.Services.AddScoped<IEuroStandardService, EuroStandardService>();
builder.Services.AddScoped<IMaterialService, MaterialService>();
builder.Services.AddScoped<IOfferService, CarOfferService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IFileStorage, FileStorage>();

#region Localization
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
#endregion

builder.Services.AddBlazoredToast();

var app = builder.Build();

//using (var serviceScope = app.Services.CreateScope())
//{
//    var context = serviceScope.ServiceProvider.GetRequiredService<TroshkaDbContext>();
//    context.Database.EnsureDeleted();
//    context.Database.EnsureCreated();
//}

var cultures = builder.Configuration.GetSection("Cultures")
    .GetChildren().ToDictionary(x => x.Key, x => x.Value);

var supportedCultures = cultures.Keys.ToArray();

var localizationOptions = new RequestLocalizationOptions()
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRequestLocalization(localizationOptions);

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
