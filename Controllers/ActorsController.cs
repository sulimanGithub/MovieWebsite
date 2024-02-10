using Microsoft.AspNetCore.Mvc;
using MovieWebsite.Data;
using MovieWebsite.Data.Services;
using MovieWebsite.Models;

namespace MovieWebsite.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }
        //GET
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int Id)
        {
            var actor = await  _service.GetByIdAsync(Id);

            if (actor == null)
                return View("Empty");
            else
                return View(actor);

        }

        public async Task<IActionResult> Edit(int Id)
        {
            var actor = await _service.GetByIdAsync(Id);

            if (actor == null)
                return View("Empty");
            else
                return View(actor);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(int Id, Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.UpdateAsync(Id,actor);
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Delete(int Id)
        {
            var actor = await _service.GetByIdAsync(Id);

            if (actor == null)
                return View("Empty");
            else
                return View(actor);

        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int Id)
        {
            var actor = await _service.GetByIdAsync(Id);

            if (actor == null) return View("Empty");
            
            await _service.DeleteAsync(Id);

            return RedirectToAction(nameof(Index));

        }
    }
}
