using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstPractice.Models;
using System.Data.Entity;

namespace FirstPractice.Controllers
{
    public class CategoriesController : Controller
    {
        CategoriesEntities db = new CategoriesEntities();
        // GET: Categories
        public ActionResult Index()
        {
            return View(db.Categories);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CategoryForm categoryForm)
        {
            Category category = new Category();
            category.CategoryName = categoryForm.CategoryName;
            category.Description = categoryForm.Description;
            db.Categories.Add(category);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult Delete(int id=0)
        {
            Category category = db.Categories.Find(id);
            db.Categories.Remove(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int id=0)
        {
            Category category = db.Categories.Find(id);
            return View(category);
        }

        [HttpPost]
        public ActionResult Update(CategoryForm categoryForm)
        {
            Category category = new Category();
            category.CategoryID = categoryForm.CategoryID;
            category.CategoryName = categoryForm.CategoryName;
            category.Description = categoryForm.Description;
            db.Entry(category).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}