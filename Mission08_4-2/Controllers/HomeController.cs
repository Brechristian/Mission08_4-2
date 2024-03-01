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







    }



}
