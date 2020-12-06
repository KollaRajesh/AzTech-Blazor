using eShop.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using eShop.UseCases.PluginInterfaces.DataStore;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Net.Http;

namespace eShop.DataStore.HardCoded
{

    //https://github.com/dotnet-presentations/ContosoCrafts/blob/master/src/wwwroot/data/products.json
    public class ProductRepositoryAsync : IProductRepositoryAsync
    {
        HttpClient httpclient;
        public ProductRepositoryAsync(HttpClient client)
        {
            httpclient = client;
        }
        public async Task<Product> GetProductAsync(string id)
        {
            return (await GetProductsAsync()).FirstOrDefault(x => x.Id == id);

        }
        public async Task<IEnumerable<Product>> GetProductsAsync(string filter = null)
        {
            if (string.IsNullOrWhiteSpace(filter)) return await GetProductsAsync();
            return (await GetProductsAsync()).Where(x => x.Title.ToLower().Contains(filter.ToLower()));
        }

        public async Task<Product[]> GetProductsAsync()
        {
            //using (System.Net.Http.HttpClient client = new System.Net.Http.HttpClient())
            //{
                //var httpResponseMessage = client.GetAsync("https://raw.githubusercontent.com/dotnet-presentations/ContosoCrafts/master/src/wwwroot/data/products.json").Result;
                return await httpclient.GetFromJsonAsync<Product[]>("https://raw.githubusercontent.com/dotnet-presentations/ContosoCrafts/master/src/wwwroot/data/products.json");
            //}

        }


    }
}
