using Microsoft.AspNetCore.Mvc;
namespace Empty.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View(); // Контроллер должен быть унаследован от класса Controller и в данном случае он имеет один метод Index, который с помощью метода View обращается к представлению.
        }
    }
}
