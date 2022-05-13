using AlphaService.Models;
using AlphaService.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaService.Helpers
{
    public static class TemplateGenerator
    {
        public static string GetHTMLString(int userId,OrderViewModel lastOrder)
        {
            

            var sb = new StringBuilder();

            sb.Append(@"<div class='column' style='border:1px solid lightgray; border-radius:10px; padding:10px 15px 10px 15px;'>
                    <h1 style='margin-bottom:50px;'>Thank you for your order!</h1>
                    <h4><strong>Order summary</strong></h4>");
            sb.AppendFormat(@"
                    <p style='margin-bottom:20px;' id='orderDate'>{0}</p>
                    <div style='margin-bottom:5px;'>
                        <label class='price-label'>Chain change</label>
                        <div class='price' style='float:right;' id='chain-change-price'>{1}</div>
                    </div>
                    <div style='margin-bottom:5px;'>
                        <label class='price-label'>Oil and oil filter change</label>
                        <div class='price' style='float:right;' id='oil-filter-change-price'>{2}</div>
                    </div>
                    <div style='margin-bottom:5px;'>
                        <label class='price-label'>Air filter change</label>
                        <div class='price'style='float:right;'  id='air-filter-change-price'>{3}</div>
                    </div>
                    <div style='margin-bottom:5px;'>
                        <label class='price-label'>Brake fluid change</label>
                        <div class='price' style='float:right;' id='brake-fluid-change-price'>{4}</div>
                    </div>

                    <hr />
                    <div style='margin-bottom:5px;'>
                        <label class='price-label'>Full price:</label>
                        <div class='price' style='float:right;'  id='fullPrice'>{5}</div>
                    </div>
                    <div style='margin-bottom:5px;'>
                        <label class='price-label'>Discount:</label>
                        <div class='price' style='float:right;'  id='discount'>{6}</div>
                    </div>
                    <div>
                        <label class='price-label'><strong>Price:</strong></label>
                        <div class='price' style='float:right;' id='totalPrice'>{7}</div>
                    </div>", lastOrder.ServiceDate, lastOrder.ChainPrice, lastOrder.OilPrice, lastOrder.AirFilterPrice, lastOrder.BrakeFluidPrice, lastOrder.FullPrice, lastOrder.Discount, lastOrder.FinalPrice);
            sb.Append(@"
                </div>");
            return sb.ToString();
        }
    }
}
