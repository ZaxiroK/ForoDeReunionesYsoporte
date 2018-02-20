using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcForo.Controllers
{
    public class ForoController : Controller
    {
        // 
        // GET: /Foro/

        public IActionResult Index()
        {
        return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}