using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITManagement.Models;

using Microsoft.AspNetCore.Mvc;

namespace ITManagement.Controllers
{
    public class ManageCategoryController : Controller
    {
        private readonly ITManagementContext ITM;

        public ManageCategoryController(ITManagementContext _ITM)
        {
            ITM = _ITM;
        }


        public IActionResult getCategory()
        {
            if (TempData["ErrorMessage"] != null)
            {
                ViewBag.ErrorMessage = TempData["ErrorMessage"].ToString();
            }

            List<Categories> obj = ITM.Categories.ToList();
            ViewBag.categories = obj;
            return View();
        }

        public IActionResult CreateCategory(string category)
        {
            try
            {
                var existingCategory = ITM.Categories.FirstOrDefault(c => c.CategoryName == category);
                if (existingCategory != null)
                {
                    throw new Exception("Category with the same name already exists.");
                }
                if (string.IsNullOrEmpty(category))
                {
                    throw new Exception("CategoryName field cannot be empty.");
                }

                var CategoryEntity = new Categories
                {
                    CategoryName = category,
                };

                ITM.Categories.Add(CategoryEntity);
                ITM.SaveChanges();
                return Json(new { errorMessage = "" }); // No error message
            }
            catch (Exception ex)
            {
                return Json(new { errorMessage = "An error occurred: " + ex.Message });
            }
        }



        [HttpPost]
        public IActionResult DeleteCategory(int deleteCategoryId)
        {
            var Cat = ITM.Categories.FirstOrDefault(ca => ca.CategoryId == deleteCategoryId);

            var device = ITM.Devices.ToList().Where(d => d.CategoryId == deleteCategoryId);

           
            if (device.Count() > 0)
            {
                TempData["DisplayAlert"] = true;
                return RedirectToAction("getCategory");
            }

            ITM.Categories.Remove(Cat);
            ITM.SaveChanges();
            return RedirectToAction("getCategory");
        }


        public IActionResult UpdateCategory(int id)
        {
            var data = ITM.Categories.Where(x => x.CategoryId == id).FirstOrDefault();
            return View(data);

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var data = ITM.Categories.Where(x => x.CategoryId == id).FirstOrDefault();
            return View(data);
        
        }

        [HttpPost]
        public IActionResult Edit(Categories model)
        {
            try
            {
                var existingCategory = ITM.Categories.FirstOrDefault(c => c.CategoryName == model.CategoryName);
                if (existingCategory != null)
                {
                    throw new Exception("Category with the same name already exists.");
                }
                var data = ITM.Categories.FirstOrDefault(x => x.CategoryId == model.CategoryId);
                if (data != null)
                {
                    if (string.IsNullOrEmpty(model.CategoryName))
                    {
                        throw new Exception("Category Name field cannot be empty.");
                    }

                    data.CategoryName = model.CategoryName;
                    ITM.SaveChanges();
                    return Json(new { errorMessage1 = "" }); // No error message
                }
                else
                {
                    throw new Exception("Category not found.");
                }
            }
            catch (Exception ex)
            {
                return Json(new { errorMessage1 = "An error occurred: " + ex.Message });
            }
        }

    }
}