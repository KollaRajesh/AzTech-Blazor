using eShop.CoreBusiness.Models;
using System.Threading.Tasks;

namespace eShop.UseCases.SearchProductScreen
{
    public interface IViewProductAsync
    {
        Task<Product> Execute(string id);
        Task<Product> Execute(int id);
    }
}