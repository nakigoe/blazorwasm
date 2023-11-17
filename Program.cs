using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using nakigoe;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

ConfigureServices(builder.Services, builder.HostEnvironment.BaseAddress);

await builder.Build().RunAsync();

//Pre-rendiring with NuGet package mod: extract the service-registration process to the static local function
static void ConfigureServices(IServiceCollection Services, string baseAddress)
{
  Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(baseAddress) });
}

