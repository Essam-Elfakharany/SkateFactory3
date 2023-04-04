using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SkateFactory3.Data;
using SkateFactory3.Models;
using SkateFactory3.WebUI.Models;

namespace SkateFactory3.WebUI.Controllers
{
    [Authorize]
    public class ManageSkateboardsController : Controller
    {
        private readonly SkateFactoryContext _context;

        public ManageSkateboardsController(SkateFactoryContext context)
        {
            _context = context;
        }

        [HttpGet] //Optional
        public IActionResult Index()
        {
            var listOfSkateboards = new List<Skateboard>();
            try
            {
                listOfSkateboards = _context.Skateboards.ToList();
            }
            catch (Exception ex)
            {
                ViewBag.Message = new MessageViewModel(EMessageType.Danger, ex.Message);
            }
            return View(listOfSkateboards);
        }

        [HttpGet] //Optional
        public IActionResult AddOrUpdate(int? id)
        {
            if (id == null)
                return View();

            Skateboard? skateboard = null;

            try
            {
                skateboard = _context.Skateboards.Find(id);
                if (skateboard == null)
                {
                    return View("NotFound");
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = new MessageViewModel(EMessageType.Danger, ex.Message);
            }

            return View(skateboard);
        }

        [HttpPost]
        public IActionResult AddOrUpdate(Skateboard skateboard)
        {
            if (!ModelState.IsValid)
                return (skateboard.Id == 0) ? View() : View(skateboard);

            try
            {
                if (skateboard.Id == 0)
                    _context.Add(skateboard);
                else
                    _context.Update(skateboard);
                 _context.SaveChanges();
            }
            catch (Exception ex)
            {
                ViewBag.Message = new MessageViewModel(EMessageType.Danger, ex.Message);
                return (skateboard.Id == 0) ? View() : View(skateboard);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Remove(int id)
        {
            try
            {
                var skateboard = _context.Skateboards.Find(id);
                if (skateboard != null)
                {
                    _context.Skateboards.Remove(skateboard);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = new MessageViewModel(EMessageType.Danger, ex.Message);
            }
            return RedirectToAction("Index");
        }
    }

}
