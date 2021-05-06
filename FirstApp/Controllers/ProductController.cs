using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp.Controllers
{
    public class ProductController : Controller
    {
        //public IActionResult Detail(int id)  //action
        //{
        //ViewBag
        //ViewData
        //TempData

        //TempData daha uzun ömürlü

        //ViewBag.ProductId = id;

        //ViewData["ProductId"] = id;

        //TempData["ProductNo"] = id;  

        //var values = new int[]
        //{
        //    1,3
        //};

        //return View(values);
        //}

        //public IActionResult Detail(string productName,int id)
        //{
        //    return Content($"{id} numaralı {productName} isimli ürün görüntülenecek");
        //}

        [Route("/products")]
        public string Detail(string productName, int id)
        {
            return $"{id} numaralı {productName} isimli ürün görüntülenecek";
        }
    }
}
