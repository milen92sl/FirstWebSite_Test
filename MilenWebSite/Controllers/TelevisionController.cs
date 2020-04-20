using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MilenWebSite.Models;

namespace MilenWebSite.Controllers
{
    public class TelevisionController : Controller
    {
        public IActionResult Index()
        {
            var allTVs = TVData.GetAll();
            return View(allTVs);
        }
        public IActionResult Details(int id)
        {
            
            return View(TVData.TVs.Find(tv => tv.id == id));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TV tv)
        {
            TVData.Add(tv);

            return RedirectToAction("Index");
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            TVData.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}