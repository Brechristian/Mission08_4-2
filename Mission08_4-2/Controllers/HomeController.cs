using Microsoft.AspNetCore.Mvc;
using Mission08_4_2.Models;
using System.Diagnostics;

namespace Mission08_4_2.Controllers
{
    public class HomeController : Controller
    {
        private IToDoListRepository _repo;
        public HomeController(IToDoListRepository temp)
        {
            _repo = temp;
        }
    }

}

        
