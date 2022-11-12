using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using CongNhaBookStore.Models.ViewModels;
using CongNhaBooks.DataAccess.Repository.IRepository;
using CongNhaBooks.Models;

namespace CongNhaBookStore.Area.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)
        {
            Category category = new Category();
            if (id == null)
            {
                return View(category);
            }
            category = _unitOfWork.Category.Get(id.GetValueOrDefault());
            if(category == null)
            {
                return NotFound();
            }
            return View(); // Add category view
        }

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            var allObj = _unitOfWork.Category.GetAll();
            return Json(new { data = allObj });
        }
        

        // use Http POST to define the post-action method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Category category)
        {
            if(ModelState.IsValid) // checks all validations in the model (e.g Name required) to increase security
            {
                if(category.Id == 0)
                {
                    _unitOfWork.Category.Add(category);
                    _unitOfWork.save();
                }
                else
                {
                    _unitOfWork.Category.Update(category);
                }
                _unitOfWork.save();
                return RedirectToAction(nameof(Index)); // to see all the category
            }
            return View(category);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Category.Get(id);
            if(objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.Category.Remove(objFromDb);
            _unitOfWork.save();
            return Json(new { success = true, message = "Delete successful" });
        }
        #endregion
    }
}