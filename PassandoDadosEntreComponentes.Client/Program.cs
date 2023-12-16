using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PassandoDadosEntreComponentes.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

RegisterServices.Configure(builder.Services);

await builder.Build().RunAsync();
