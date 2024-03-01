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
            // commented this out bc not sure if we need it - ryan
            // var blah = _repo.Tasks.FirstOrDefault(x => x.TaskID == 1);

            return View(new Tasks());
        }

        [HttpPost]

        // added s to Tasks - ryan 
        public IActionResult ToDo(Tasks t)
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
                .Where(task => task.QuadrantID == 1 && task.Completed == false)
                .ToList();
            ViewBag.quandrant2 = _repo.Tasks
                .Where(task => task.QuadrantID == 2 && task.Completed == false)
                .ToList();
            ViewBag.quandrant3 = _repo.Tasks
                .Where(task => task.QuadrantID == 3 && task.Completed == false)
                .ToList();
            ViewBag.quandrant4 = _repo.Tasks
                .Where(task => task.QuadrantID == 4 && task.Completed == false)
                .ToList();
            return View();
        }



        // setup route for alltasks
        //THIS WON'T WORK UNTIL THE VIEW IS CREATED

        
        [HttpGet]
        public IActionResult AllTasks()
        {
            var allTasks = _repo.Tasks
                .OrderBy(x => x.Completed)
                .ThenBy(x => x.QuadrantID)
                .ToList();
            return View();
        }
       


        // edit action
        //WILL NOT WORK UNTIL EDIT OPTION HAS BEEN ADDED

      
        [HttpGet]
        public IActionResult Edit(int id)
        {
            try
            {
                var taskToEdit = _repo.Tasks
                    .SingleOrDefault(x => x.TaskID == id);
                return View("AllTasks", taskToEdit);
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error editing task with ID {id}: {ex.Message}");
                throw;
            }
        }
        

        [HttpPost]
        public IActionResult Edit(Tasks updatedInfo)
        {
            _repo.EditTask(updatedInfo);
            return RedirectToAction("AllTasks");
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var taskToDelete = _repo.Tasks
                .Single(x => x.TaskID == id);
            return View(taskToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Tasks task)
        {
            _repo.DeleteTask(task);
            return RedirectToAction("AllTasks");
        }


    }



}