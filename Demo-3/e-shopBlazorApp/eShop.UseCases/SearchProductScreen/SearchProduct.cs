using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.UseCases.SearchProductScreen
{
    public class SearchProduct : ISearchProduct
    {
        private readonly IProductRepository productRepository;

        public SearchProduct(IProductRepository productRepository)
        {
            this.productRepository = productRepository;

        }

        public IEnumerable<Product> Execute(string filter = null)
        {
            return productRepository.GetProducts(filter);
        }
    }
}
