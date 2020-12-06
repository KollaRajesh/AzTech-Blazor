using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.UseCases.SearchProductScreen
{
    public class SearchProductAsync : ISearchProductAsync
    {
        private readonly IProductRepositoryAsync productRepository;

        public SearchProductAsync(IProductRepositoryAsync productRepository)
        {
            this.productRepository = productRepository;

        }

        public Task<IEnumerable<Product>> Execute(string filter = null)
        {
            return productRepository.GetProductsAsync(filter);
        }
    }
}
