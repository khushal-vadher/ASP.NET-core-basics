using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class InfoController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        //DI with use of constructor injection
        public InfoController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        //attribute routing 
        [Route("")]
        [Route("/home")]
        [Route("/home/index")]
        public String Index()
        {
          return _studentRepository.GetStudent(1).Name;
        }
        [Route("home/details")]

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
