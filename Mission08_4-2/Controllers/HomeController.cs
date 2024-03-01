using Microsoft.AspNetCore.Mvc;
using Mission08_4_2.Models;
using SQLitePCL;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
//test.

namespace Mission08_4_2.Controllers
{
    public class HomeController : Controller
    {
        private TasksContext _context;
        public HomeController(TasksContext temp)
        {
            _context = temp;
        }    
        
        // Go to landing page
        public IActionResult Index()
        {
        return View();
        }

        [HttpGet]
        public IActionResult ToDo(Task response)
        {
        ViewBag.Tasks = _context.Tasks
            .OrderBy(x => x.TaskName)
            .ToList();
            return View(new Tasks());
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

        
