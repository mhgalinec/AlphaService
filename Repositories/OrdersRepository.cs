using AlphaService.Models;
using AlphaService.Models.ViewModels;
using AlphaService.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaService.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly AlphaServiceContext _context;
        public OrdersRepository(AlphaServiceContext context)
        {
            _context = context;
        }
        public async Task<double> GetAirPriceAsync(string brand, string model)
        {
            var price = _context.Bikes.Where(b => b.Brand == brand).Where(m => m.Model == model).Select(a => a.AirFilterPrice).FirstOrDefaultAsync();
            return await price;
        }

        public async Task<IEnumerable<BikeBrand>> GetBikeBrandsAsync()
        {
            var brand = _context.BikeBrands.Select(b => new BikeBrand
            {
                BikeBrandId = b.BikeBrandId,
                Name = b.Name
            });
            return await brand.ToListAsync();
        }

        public async  Task<IEnumerable<BikeModel>> GetBikeModelsAsync()
        {
            var model = _context.BikeModels.Select(m => new BikeModel
            {
                BikeModelId = m.BikeModelId,
                Name = m.Name,
                LastSupportedYear = m.LastSupportedYear,
                BikeBrandId = m.BikeBrandId
            });

            return await model.ToListAsync();
        }

        public async Task<double> GetBrakePriceAsync(string brand, string model)
        {
            var price = _context.Bikes.Where(b => b.Brand == brand).Where(m => m.Model == model).Select(b => b.BrakeFluidPrice).FirstOrDefaultAsync();
            return await price;
        }

        public async Task<double> GetChainPriceAsync(string brand, string model)
        {
            var price =  _context.Bikes.Where(b => b.Brand == brand).Where(m => m.Model == model).Select(c => c.ChainPrice).FirstOrDefaultAsync();
            return await price;
        }

        public async Task<double> GetOilPriceAsync(string brand, string model)
        {
            var price = _context.Bikes.Where(b => b.Brand == brand).Where(m => m.Model == model).Select(o => o.OilPrice).FirstOrDefaultAsync();

            return await price;
        }

        public OrderViewModel GetOrderDetails(int? userid)
        {
            
            var lastOrder = (from o in _context.Orders
                             join uor in _context.UserOrderRelationships on o.OrderId equals uor.OrderId
                             join u in _context.Users on uor.UserId equals u.UserId
                             where u.UserId == userid
                             select new Order
                             {
                                 OrderId = o.OrderId,
                                 ServiceDate = o.ServiceDate,
                                 Model = o.Model,
                                 ChainChange = o.ChainChange,
                                 OilChange = o.OilChange,
                                 BrakeFluidChange = o.BrakeFluidChange,
                                 AirFilterChange = o.AirFilterChange,
                                 Progress = o.Progress
                             }
                ).OrderByDescending(x => x.OrderId).Take(1).FirstOrDefault();

            var oilPrice = (from m in _context.Bikes
                              where lastOrder.Model == m.Model
                              where lastOrder.OilChange == true
                              select m.OilPrice).FirstOrDefault();

            var chainPrice = (from m in _context.Bikes
                              where lastOrder.Model == m.Model
                              where lastOrder.ChainChange == true
                              select m.ChainPrice).FirstOrDefault();

            var airFilterPrice = (from m in _context.Bikes
                              where lastOrder.Model == m.Model
                              where lastOrder.AirFilterChange == true
                              select m.AirFilterPrice).FirstOrDefault();

            var brakeFluidPrice = (from m in _context.Bikes
                              where lastOrder.Model == m.Model
                              where lastOrder.BrakeFluidChange == true
                              select m.BrakeFluidPrice).FirstOrDefault();
            double fullPrice = 0;
            double totalPrice = 0;
            var discount = "";

            string fullPriceString = "";
            string totalPriceString = "";
            if (chainPrice != 0 && brakeFluidPrice != 0 && airFilterPrice == 0 && oilPrice == 0)
            {
                fullPrice = chainPrice + brakeFluidPrice;
                discount = "15%";
                totalPrice = (chainPrice + brakeFluidPrice) * 0.85;

                fullPriceString = fullPrice.ToString();
                totalPriceString = totalPrice.ToString();
                
            }
            else if (oilPrice != 0 && airFilterPrice != 0 && brakeFluidPrice == 0 && chainPrice == 0)
            {

                totalPrice = (oilPrice + airFilterPrice) - 20;
                fullPrice = oilPrice + airFilterPrice;
                discount = "20$";
                fullPriceString = fullPrice.ToString();
                totalPriceString = totalPrice.ToString();
            }
            else if (chainPrice != 0 && oilPrice != 0 && airFilterPrice != 0 && brakeFluidPrice == 0)
            {

                totalPrice = (chainPrice + oilPrice + airFilterPrice) * 0.80;
                fullPrice = chainPrice + oilPrice + airFilterPrice;
                discount = "20%";
                fullPriceString = fullPrice.ToString();
                totalPriceString = totalPrice.ToString();
            }
            else if (chainPrice != 0 && brakeFluidPrice != 0 && airFilterPrice != 0 && oilPrice != 0)
            {

                totalPrice = (brakeFluidPrice + oilPrice + airFilterPrice + chainPrice) - 40;
                fullPrice = brakeFluidPrice + oilPrice + airFilterPrice + chainPrice;
                discount = "40$";
                fullPriceString = fullPrice.ToString();
                totalPriceString = totalPrice.ToString();
            }
            else
            {
                
                List<double> list = new List<double>()
                {
                    chainPrice,oilPrice,airFilterPrice,brakeFluidPrice
                };

                foreach(var l in list)
                {
                    if(l != 0)
                    {
                        fullPrice += l;
                        totalPrice += l;
                    }
                }
                fullPriceString = fullPrice.ToString();
                totalPriceString = totalPrice.ToString();
            }


            var vm = new OrderViewModel
            {
                ServiceDate = lastOrder.ServiceDate,
                OilPrice = oilPrice.ToString() + "$",
                ChainPrice = chainPrice.ToString() + "$",
                AirFilterPrice = airFilterPrice.ToString() + "$",
                BrakeFluidPrice = brakeFluidPrice.ToString() + "$",
                Discount = discount,
                FinalPrice = totalPriceString + "$",
                FullPrice = fullPriceString + "$"
            };

            return vm;
        }

        public EditOrderViewModel GetOrderForEdit(int orderId)
        {
            
            var order = (from o in _context.Orders
                         where o.OrderId == orderId
                         select new EditOrderViewModel
                         {
                             OrderId = o.OrderId,
                             BikeModel = o.Model,
                             Mileage = o.Mileage,
                             ServiceDate = o.ServiceDate,
                             OilChange = o.OilChange,
                             ChainChange = o.ChainChange,
                             AirFilterChange = o.AirFilterChange,
                             BrakeFluidChange = o.BrakeFluidChange
                         }).FirstOrDefault();

            var bikeBrandId = (from o in _context.BikeModels
                             where o.Name == order.BikeModel
                             select o.BikeBrandId).FirstOrDefault();

            var bikeBrand = (from b in _context.BikeBrands
                             join m in _context.BikeModels on b.BikeBrandId equals m.BikeBrandId
                             where b.BikeBrandId == bikeBrandId
                             select b.Name).FirstOrDefault();

            var supportedYear = (from o in _context.BikeModels
                               where o.Name == order.BikeModel
                               select o.LastSupportedYear).FirstOrDefault();
            order.BikeBrand = bikeBrand;
            order.LastSupportedYear = supportedYear;

            Console.WriteLine(order.ServiceDate);
            return order;

        }

        public async Task<IEnumerable<Order>> GetUserOrdersAsync(string email)
        {
            var order = (from o in _context.Orders
                         join uor in _context.UserOrderRelationships on o.OrderId equals uor.OrderId
                         join u in _context.Users on uor.UserId equals u.UserId
                         where u.Email == email
                         select new Order
                         {
                             OrderId = o.OrderId,
                             ServiceDate = o.ServiceDate,
                             Mileage = o.Mileage,
                             Model = o.Model,
                             Progress = o.Progress
                         }
                );

            return await order.ToListAsync();
        }
    }
}
