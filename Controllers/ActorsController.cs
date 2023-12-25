using eTicketApp.Data;
using eTicketApp.Data.Services;
using eTicketApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Web.Mvc;
using ActionNameAttribute = Microsoft.AspNetCore.Mvc.ActionNameAttribute;
using BindAttribute = Microsoft.AspNetCore.Mvc.BindAttribute;
using Controller = Microsoft.AspNetCore.Mvc.Controller;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;

namespace eTicketApp.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorService _service;
        public ActorsController(IActorService
            service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
           
            
            var data =await _service.GetAllAsync();
            return View(data);
        }
        public IActionResult Create2()
        {
           
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create2(Actor actor)
        {
            await _service.AddAsync(actor);
            return RedirectToAction("Index");
        }

        //get actors/Edit/1
        public async Task<IActionResult> Details(int id)
        {
            var actorDetay = await _service.GetByIdAsync(id);
            if (actorDetay == null) return View("NotFound");
            return View(actorDetay);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var actorDetay = await _service.GetByIdAsync(id);
            if (actorDetay == null) return View("NotFound");
            return View(actorDetay);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id,Actor actor)
        {
            await _service.UpdateAsync(id,actor);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var actorDetay = await _service.GetByIdAsync(id);
            if (actorDetay == null) return View("NotFound");
            return View(actorDetay);
        }
        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetay = await _service.GetByIdAsync(id);
            if (actorDetay == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction("Index");
        }






        //[HttpPost]
        //public async Task<IActionResult> Create(Actor actor)/*[Bind("ProfilePictureURL,FullName,Bio")]*/
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(actor);
        //    }
        //    _service.Add(actor);
        //    return RedirectToAction(nameof(Index));
        //}
    }
}
