using IS413_FInal_App.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IS413_FInal_App.Controllers
{
    public class HomeController : Controller
    {
        private IEntertainmentRepository _repo;

        public HomeController(IEntertainmentRepository temp)
        {
            _repo = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EntertainersDetails(int id)
        {
            var Record = _repo.Entertainers
                .Single(x => x.EntertainerId == id);
            return View(Record);
        }

        [HttpGet]
        public IActionResult EntertainersForm()
        {

            return View(new Entertainer());
        }

        [HttpPost]
        public IActionResult EntertainersForm(Entertainer response)
        {

            if (ModelState.IsValid)
            {
                _repo.AddEntertainer(response);//add record to the database
                return View("AddingConfirmation", response);

            }
            else //empty form submitted 
            {
                return View(response);
            }

        }

        [HttpGet]
        public IActionResult EntertainersList()
        {
            var form = _repo.Entertainers
                .OrderBy(x => x.EntertainerId).ToList();

            return View(form);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var updateRecord = _repo.Entertainers
                .Single(x => x.EntertainerId == id);

            //ViewBag.Categories = _repo.Categories
            //    .OrderBy(x => x.CategoryId)
            //    .ToList();
            return View("EntertainersForm", updateRecord);
        }

        [HttpPost]
        public IActionResult Edit(Entertainer updatedEntertainer)
        {
            if (ModelState.IsValid)
            {
                _repo.UpdateEntertainer(updatedEntertainer);
                return RedirectToAction("EntertainersList");
            }
            else
            //invalid - return the form with the data the user entered

            {
                return View("EntertainersForm", updatedEntertainer);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var entertainerToDelete = _repo.Entertainers
                .Single(x => x.EntertainerId == id);
            return View("DeleteConfirmation", entertainerToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Entertainer entertainerToDelete)
        {
            _repo.RemoveEntertainer(entertainerToDelete);

            return RedirectToAction("EntertainersList");
        }

    }
}