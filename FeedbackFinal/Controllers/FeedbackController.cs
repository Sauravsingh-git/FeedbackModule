using Microsoft.AspNetCore.Mvc;

namespace FeedbackFinal.Controllers
{
    public class FeedbackController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(String SubjectId, String SubjectName)
        {
            return View();
        }
    }
}
