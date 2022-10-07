using ASP_NET_Core_Comment_Section.Models;
using ASP_NET_Core_Comment_Section.Service;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_Core_Comment_Section.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult<List<Pizza>> GetAll() =>
            PizzaService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<Pizza> Get(int id)
        {
            var pizza = PizzaService.Get(id);

            if(pizza == null)
                return NotFound();

            return pizza;
        }

        // POST action

        // PUT action

        // DELETE action
    }
}
