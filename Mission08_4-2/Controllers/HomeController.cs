using Microsoft.AspNetCore.Mvc;
using Mission08_4_2.Models;
using SQLitePCL;
using System.Diagnostics;
//test1

namespace Mission08_4_2.Controllers
{
    public class HomeController : Controller
    {
        private IToDoListRepository _repo;
        public HomeController(IToDoListRepository temp)
        {
            _repo = temp;
        }    
        
        // Go to landing page
        public IActionResult Index()
        {
        return View();
        }





/*
        // Get/Post for Adding a ToDo List item

        [HttpGet]
        public IActionResult ToDo()
        {
            // ViewBag.Completed = _context.Completed
            //      .OrderBy(x => x.Completed)
            //      .ToList();
            // return View ("ToDo", new ToDoList());



        }

        [HttpPost]

        public IActionResult ToDo(ToDoList response)
        {
            if (ModelState.IsValid)
            {
                _context.???.Add(response); //add new record to database
                _context.SaveChanges();

                return View("Confirmation", response);
            }
            else //invalid data
            {
                ViewBag.Completed = _context.Completed
                    .OrderBy(x => x.Completed)
                    .ToList();
                return View(response);
            }
        }
*/
    }



}

        
