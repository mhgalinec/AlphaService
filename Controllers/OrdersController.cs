using AlphaService.Models;
using AlphaService.Models.ViewModels;
using AlphaService.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaService.Controllers
{
    public class OrdersController : Controller
    {
        private readonly AlphaServiceContext _context;
        private readonly IOrdersRepository _ordersRepository;

        public OrdersController(AlphaServiceContext context,IOrdersRepository ordersRepository)
        {
            _context = context;
            _ordersRepository = ordersRepository;
        }
        // GET: OrdersController
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var bikebrand = await _ordersRepository.GetBikeBrandsAsync();
            var bikemodel = await _ordersRepository.GetBikeModelsAsync();
            var bookedDates = _context.Orders.Select(d => d.ServiceDate).ToArray();
            ViewData["BookedDates"] = bookedDates;

            var model = new AddOrderViewModel
            {
                BikeBrands = bikebrand,
                BikeModels = bikemodel
            };
            return View(model);
        }


        [HttpPost]
        public IActionResult Add(Order orderModel)
        {
            var user = HttpContext.Session.GetInt32("_UserId");

            if (ModelState.IsValid)
            {
                var bikeModel = _context.BikeModels.Where(b => b.BikeModelId == Int32.Parse(orderModel.Model)).Select(m => m.Name).FirstOrDefault();
                if(user != null)
                {
                    var order = new Order
                    {
                        OrderId = orderModel.OrderId,
                        ServiceDate = orderModel.ServiceDate,
                        Model = bikeModel,
                        Mileage = orderModel.Mileage,
                        ChainChange = orderModel.ChainChange,
                        BrakeFluidChange = orderModel.BrakeFluidChange,
                        OilChange = orderModel.OilChange,
                        AirFilterChange = orderModel.AirFilterChange,
                        Progress = "Active"
                    };

                    _context.Orders.Add(order);
                    _context.SaveChanges();

                    UserOrderRelationship userOrderRelationship = new UserOrderRelationship { UserId = (int)user, OrderId = order.OrderId };
                    _context.UserOrderRelationships.Add(userOrderRelationship);
                    _context.SaveChanges();

                    TempData["OrderMessage"] = "Thank you for your order: #" + order.OrderId; 
                    return RedirectToAction("Dashboard", "Home");
                }

            }

            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var viewModel = _ordersRepository.GetOrderForEdit(id);
            var bookedDates = _context.Orders.Select(d => d.ServiceDate).ToArray();
            ViewData["BookedDates"] = bookedDates;
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(EditOrderViewModel orderModel,string submit)
        {
            if (ModelState.IsValid)
            {
                var order = _context.Orders.Where(o => o.OrderId == orderModel.OrderId).Select(o => new Order
                {
                    OrderId = o.OrderId,
                    Model = o.Model,
                    ServiceDate = o.ServiceDate,
                    Mileage = o.Mileage,
                    ChainChange = o.ChainChange,
                    BrakeFluidChange = o.BrakeFluidChange,
                    OilChange = o.OilChange,
                    AirFilterChange = o.AirFilterChange,
                    Progress = o.Progress

                }).FirstOrDefault();

                if(submit == "save")
                {
                    order.Mileage = orderModel.Mileage;
                    order.ChainChange = orderModel.ChainChange;
                    order.BrakeFluidChange = orderModel.BrakeFluidChange;
                    order.OilChange = orderModel.OilChange;
                    order.AirFilterChange = orderModel.AirFilterChange;
                    order.ServiceDate = orderModel.ServiceDate;
                    order.Progress = "Active";

                    _context.Orders.Update(order);
                    _context.SaveChanges();
                    return RedirectToAction("Dashboard", "Home");
                }
                if(submit == "cancel")
                {
                    order.Progress = "Canceled";
                    _context.Orders.Update(order);
                    _context.SaveChanges();
                    return RedirectToAction("Dashboard", "Home");
                }
                

            }

            return View();
        }



        public async Task<IActionResult> Prices(string brand, string model)
        {
            var oilprice = await _ordersRepository.GetOilPriceAsync(brand,model);
            var chainprice = await _ordersRepository.GetChainPriceAsync(brand, model);
            var airprice = await _ordersRepository.GetAirPriceAsync(brand, model);
            var brakeprice = await _ordersRepository.GetBrakePriceAsync(brand, model);

            return new JsonResult(new { brand = brand, model = model, oilprice = oilprice, chainprice = chainprice, airprice = airprice, brakeprice = brakeprice });
        }
        public async Task<IActionResult> OilPrice(string brand, string model)
        {
            var price = await _ordersRepository.GetOilPriceAsync(brand, model);
            return new JsonResult(new { brand = brand, model = model , price = price});
        }

        public async Task<IActionResult> ChainPrice(string brand,string model)
        {
            var price = await _ordersRepository.GetChainPriceAsync(brand, model);
            return new JsonResult(new { brand = brand, model = model, price = price });
        }

        public async Task<IActionResult> AirFilterPrice(string brand, string model)
        {
            var price = await _ordersRepository.GetAirPriceAsync(brand, model);
            return new JsonResult(new { brand = brand, model = model, price = price });
        }

        public async Task<IActionResult> BrakeFluidPrice(string brand, string model)
        {
            var price = await _ordersRepository.GetBrakePriceAsync(brand, model);
            return new JsonResult(new { brand = brand, model = model, price = price });
        }

    }
}
