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
    public class ProductRepository: IProductRepository
    {
        private readonly List<Product> products;
        public ProductRepository(HttpClient client)
        {
            products = new List<Product>();
            string jsonList;

            //using (System.Net.Http.HttpClient client = new System.Net.Http.HttpClient())
            //{

                var httpResponseMessage = client.GetAsync("https://raw.githubusercontent.com/dotnet-presentations/ContosoCrafts/master/src/wwwroot/data/products.json").Result;
                jsonList = httpResponseMessage.Content.ReadAsStringAsync().Result;
            //}
            products = JsonConvert.DeserializeObject<List<Product>>(jsonList);

        }
        public Product GetProduct(string id)
        {
            return products.FirstOrDefault(x => x.Id== id);
        
        }
        public IEnumerable<Product> GetProducts(string filter = null)
        {
            if (string.IsNullOrWhiteSpace(filter)) return products;
            
            return products.Where(x => x.Title.ToLower().Contains(filter.ToLower()));
        }

       


    }
}
