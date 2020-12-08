using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Debugging;

namespace WebAppWasm
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

                Log.Debug("Hello, browser!");
                Log.Warning("Received strange response {@Response} from server", new { Username = "example", Cats = 7 });
                var builder = WebAssemblyHostBuilder.CreateDefault(args);
                builder.RootComponents.Add<App>("app");

                builder.Services.AddScoped(sp => new HttpClient
                {
                    BaseAddress =
                     new Uri(builder.HostEnvironment.BaseAddress)
                });

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
