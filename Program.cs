using BlazorAPIClient;
using BlazorAPIClient.DataServices;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

Console.WriteLine("BlazorAPIClient has started... ");
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["base_url"]) });

// register interface & concreate implementation, along with base url
builder.Services.AddHttpClient<ISpaceXDataService, GraphQLSpaceXDataService>(spx => spx.BaseAddress = new Uri(builder.Configuration["base_url"]));

await builder.Build().RunAsync();
