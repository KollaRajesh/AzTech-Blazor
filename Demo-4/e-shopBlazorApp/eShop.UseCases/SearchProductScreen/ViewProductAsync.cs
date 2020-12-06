using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.UseCases.SearchProductScreen
{
    public class ViewProductASync : IViewProductAsync
    {
        private readonly IProductRepositoryAsync productRepository;

        public ViewProductASync(IProductRepositoryAsync productRepository)
        {
            this.productRepository = productRepository;
        }
        public async Task<Product> Execute(string id)
        {
            return await productRepository.GetProductAsync(id);
        }

        public Task<Product> Execute(int id)
        {
            throw new NotImplementedException();
        }
    }
}
