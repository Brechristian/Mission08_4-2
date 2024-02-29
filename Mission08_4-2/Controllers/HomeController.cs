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
        private ITasksRepository _repo;

        public HomeController(ITasksRepository temp)
        {
            _repo = temp;
        }


        [HttpGet]
        public IActionResult Index()
        {
            var blah = _repo.Tasks.FirstOrDefault(x => x.TaskID == 1);

            return View(new Tasks());
        }

        [HttpPost]
        public IActionResult Index(Task t)
        {
            if (ModelState.IsValid)
            {
                _repo.AddTask(t);

            }
            return View(new Tasks());
        }

        //[HttpGet]
        //public IActionResult ToDo(Task response)
        //{
        //    ViewBag.Tasks = _context.Tasks
        //        .OrderBy(x => x.TaskName)
        //        .ToList();
        //    return View("ToDo", new Tasks());
        //}



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
