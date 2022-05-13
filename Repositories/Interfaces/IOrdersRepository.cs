using AlphaService.Models;
using AlphaService.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaService.Repositories.Interfaces
{
    public interface IOrdersRepository
    {
        public Task<IEnumerable<Order>> GetUserOrdersAsync(string email);
        public Task<IEnumerable<BikeModel>> GetBikeModelsAsync();
        public Task<IEnumerable<BikeBrand>> GetBikeBrandsAsync();
        public Task<double> GetOilPriceAsync(string brand,string model);
        public Task<double> GetChainPriceAsync(string brand, string model);
        public Task<double> GetAirPriceAsync(string brand, string model);
        public Task<double> GetBrakePriceAsync(string brand, string model);
        public OrderViewModel GetOrderDetails(int? userid);
        public EditOrderViewModel GetOrderForEdit(int orderId);
    }
}
