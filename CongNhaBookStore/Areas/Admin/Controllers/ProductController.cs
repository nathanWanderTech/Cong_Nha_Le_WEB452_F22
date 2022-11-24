using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

using CongNhaBooks.DataAccess.Repository.IRepository;
using CongNhaBooks.Models;
using CongNhaBooks.Models.ViewModels;

namespace CongNhaBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment; // to upload images on the server inside wwwroot

        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult Upsert(int? id) // get action method for Upsert
        //{
        //    ProductVM productVM = new ProductVM()
        //    {
        //        Product = new Product(),
        //        CategoryList = _unitOfWork.Category.GetAll().Select(i => new SelectListItem
        //        {
        //            Text = i.Name,
        //            Value = i.Id.ToString()
        //        }),
        //        CoverTypeList = _unitOfWork.CoverType.GetAll().Select(i => new SelectListItem
        //        {
        //            Text = i.Name,
        //            Value = i.Id.ToString()
        //        })
        //    }; // using CongNhaBooks.Models

        //    if(id == null)
        //    {
        //        return View(productVM); // this is for create
        //    }

        //    // Below is for the edit
        //    productVM.Product = _unitOfWork.Product.Get(id.GetValueOrDefault());
        //    if(productVM.Product == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(productVM);
        //}


    }
}

