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


        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult ToDo()
        {
            var blah = _repo.Tasks.FirstOrDefault(x => x.TaskID == 1);

            return View(new Tasks());
        }

        [HttpPost]
        public IActionResult ToDo(Task t)
        {
            if (ModelState.IsValid)
            {
                _repo.AddTask(t);

            }
            return View(new Tasks());
        }

        // setup route for quadrant, view by quadrantid
        [HttpGet]
        public IActionResult Quadrant()
        {
            ViewBag.quandrant1 = _repo.Tasks
                .Where(task => task.QuadrantID == 1)
                .ToList();
            ViewBag.quandrant2 = _repo.Tasks
                .Where(task => task.QuadrantID == 2)
                .ToList();
            ViewBag.quandrant3 = _repo.Tasks
                .Where(task => task.QuadrantID == 3)
                .ToList();
            ViewBag.quandrant4 = _repo.Tasks
                .Where(task => task.QuadrantID == 4)
                .ToList();
            return View();
        }



        // setup route for alltasks
        //THIS WON'T WORK UNTIL THE VIEW IS CREATED

        /*
        [HttpGet]
        public IActionResult AllTasks()
        {
            var allTasks = _repo.Tasks
                .OrderBy(x => x.QuadrantID)
                .ToList();
        }
        */



    }



}
