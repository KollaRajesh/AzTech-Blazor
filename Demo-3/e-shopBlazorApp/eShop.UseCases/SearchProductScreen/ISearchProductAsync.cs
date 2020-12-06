using eShop.CoreBusiness.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShop.UseCases.SearchProductScreen
{
    public interface ISearchProductAsync
    {
        Task<IEnumerable<Product>> Execute(string filter = null);
    }
}