using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Nodes;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        //DI with use of constructor injection
        public HomeController(IStudentRepository studentRepository) {
            _studentRepository = studentRepository;
        }
        //public String Index()
        //{
          //  var model = _studentRepository.GetAllStudents();

            //return
        //}
        public ViewResult Details()
        {
            Students model = _studentRepository.GetStudent(1);
            // ViewData["title"] = "Student Details";
            // ViewData["student"] = model;
            ViewBag.title = "Student details";
            //ViewBag.student = model;
            return View(model); //as we pass model here its stongly typed view 
        }

        
    }
}
