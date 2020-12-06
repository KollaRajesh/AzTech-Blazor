using eShop.DataStore.HardCoded;
using eShop.UseCases.PluginInterfaces.DataStore;
using eShop.UseCases.SearchProductScreen;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace eShop.BlazorWasm.UI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddTransient<IProductRepositoryAsync, ProductRepositoryAsync>();
            builder.Services.AddTransient<ISearchProductAsync, SearchProductAsync>();
            builder.Services.AddTransient<IViewProductAsync, ViewProductASync>();
            builder.Services.AddTransient<IProductRepository, ProductRepository>();
            builder.Services.AddTransient<ISearchProduct, SearchProduct>();
            builder.Services.AddTransient<IViewProduct, ViewProduct>();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            
            await builder.Build().RunAsync();
        }
    }
}
