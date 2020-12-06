using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.UseCases.SearchProductScreen
{
    public class ViewProduct : IViewProduct
    {
        private readonly IProductRepository productRepository;

        public ViewProduct(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public Product Execute(string id)
        {
            return productRepository.GetProduct(id);
        }
    }
}
