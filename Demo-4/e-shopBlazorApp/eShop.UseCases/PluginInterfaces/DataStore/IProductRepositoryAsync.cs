using eShop.CoreBusiness.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShop.UseCases.PluginInterfaces.DataStore
{
    public interface IProductRepositoryAsync
    {
        Task<Product> GetProductAsync(string id);
        Task<Product[]> GetProductsAsync();
        Task<IEnumerable<Product>> GetProductsAsync(string filter = null);
    }
}