using eShop.DataStore.HardCoded;
using eShop.UseCases.PluginInterfaces.DataStore;
using eShop.UseCases.SearchProductScreen;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Serilog;
using Microsoft.Extensions.Configuration;
using Serilog.Debugging;

namespace eShop.BlazorWasm.UI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {

            //https://github.com/serilog/serilog-sinks-browserconsole
            //https://www.nuget.org/packages/Serilog.Sinks.BrowserConsole
            SelfLog.Enable(m => Console.Error.WriteLine(m));
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.BrowserConsole()
                .CreateLogger();

            try
            {
                var builder = WebAssemblyHostBuilder.CreateDefault(args);
                builder.RootComponents.Add<App>("#app");
                builder.Services.AddTransient<IProductRepositoryAsync, ProductRepositoryAsync>();
                builder.Services.AddTransient<ISearchProductAsync, SearchProductAsync>();
                builder.Services.AddTransient<IViewProductAsync, ViewProductASync>();


                builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
                await builder.Build().RunAsync();

            }
            catch (Exception ex)
            {
               Log.Fatal(ex, "An exception occurred while creating the WASM host");
                throw;
            }
        }
    }
}
