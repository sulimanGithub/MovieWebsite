using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieWebsite.Data;
using MovieWebsite.Data.Services;
using MovieWebsite.Models;

namespace MovieWebsite.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducersService _service;

        public ProducersController(IProducersService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var Producer = await _service.GetAllAsync();
            return View(Producer);
        }
        public async Task<IActionResult> Details(int Id)
        {
            var producer = await _service.GetByIdAsync(Id);

            if (producer == null)
                return View("Empty");
            else
                return View(producer);

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL,FullName,Bio")] Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }
            await _service.AddAsync(producer);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int Id)
        {
            var producer = await _service.GetByIdAsync(Id);

            if (producer == null)
                return View("Empty");
            else
                return View(producer);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(int Id, Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }
            if(Id == producer.Id)
            {
                await _service.UpdateAsync(Id, producer);
                return RedirectToAction($"{nameof(Index)}");
            }
            return View(producer);


        }

        public async Task<IActionResult> Delete(int Id)
        {
            var producer = await _service.GetByIdAsync(Id);

            if (producer == null)
                return View("Empty");
            else
                return View(producer);

        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int Id)
        {
            var producer = await _service.GetByIdAsync(Id);

            if (producer == null) return View("Empty");

            await _service.DeleteAsync(Id);

            return RedirectToAction(nameof(Index));

        }
        
    }
}
