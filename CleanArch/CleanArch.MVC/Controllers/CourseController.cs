using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Mvc.Controllers
{
    public class CourseController : Controller
    {
        private ICourseService _courseSevice;

        public CourseController(ICourseService courseService)
        {
            _courseSevice = courseService;
        }

        public IActionResult Index()
        {
            CourseViewModel model = _courseSevice.GetCourses();
            return View(model);
        }

        public IActionResult ShowCourse(int id)
        {
            SingleCourseViewModel model = _courseSevice.GetCourseById(id);

            if (model == null)
                return NotFound();

            return View(model);
        }
    }
}
