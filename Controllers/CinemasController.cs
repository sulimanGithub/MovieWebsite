using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieWebsite.Data;
using MovieWebsite.Data.Services;
using MovieWebsite.Models;

namespace MovieWebsite.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinemasService _service;

        public CinemasController(ICinemasService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Details(int Id)
        {
            var cinema = await _service.GetByIdAsync(Id);

            if (cinema == null)
                return View("Empty");
            else
                return View(cinema);

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo,Name,Description")] Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }
            await _service.AddAsync(cinema);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int Id)
        {
            var cineam = await _service.GetByIdAsync(Id);

            if (cineam == null)
                return View("Empty");
            else
                return View(cineam);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(int Id, Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }
            await _service.UpdateAsync(Id, cinema);
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Delete(int Id)
        {
            var cinema = await _service.GetByIdAsync(Id);

            if (cinema == null)
                return View("Empty");
            else
                return View(cinema);

        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int Id)
        {
            var cinema = await _service.GetByIdAsync(Id);

            if (cinema == null) return View("Empty");

            await _service.DeleteAsync(Id);

            return RedirectToAction(nameof(Index));

        }
        public async Task<IActionResult> Index()
        {
            var Cinemas = await _service.GetAllAsync();
            return View(Cinemas);
        }
    }
}
