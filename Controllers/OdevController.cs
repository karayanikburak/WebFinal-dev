using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebFinal.Models;
using WebFinal.ViewModels;

namespace WebFinal.Controllers
{
    public class OdevController : Controller
    {
        private readonly AppDbContext _context;

        public OdevController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        [Authorize]
        public IActionResult Index()
        {
            List<Odev> objOdevTuruList = _context.Odevler.ToList();
            return View(objOdevTuruList);
        }


  
 
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(OdevModel model)
        {

            
                var Odev = new Odev();
                Odev.Id = model.Id;
                Odev.Name = model.Name;
                Odev.Description = model.Description;
                Odev.CategoryName = model.CategoryName;
                Odev.CategoryId = model.CategoryId;


                _context.Odevler.Add(Odev);
                _context.SaveChanges();
                return RedirectToAction("Index");

            
        }
        public IActionResult Edit(int id)
        {
            var odevsModel = _context.Odevler.Select(x => new OdevModel()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                CategoryName = x.CategoryName,
                CategoryId = x.CategoryId
               

            }).SingleOrDefault(x => x.Id == id);
            return View(odevsModel);
        }

        [HttpPost]
        public IActionResult Edit(OdevModel model)
        {
            var odev = _context.Odevler.SingleOrDefault(x => x.Id == model.Id);
            odev.Name = model.Name;
            odev.Description = model.Description;
            odev.CategoryName= model.CategoryName;
            odev.CategoryId = model.CategoryId;


            _context.Odevler.Update(odev);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var odevsModel = _context.Odevler.Select(x => new OdevModel()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
             

            }).SingleOrDefault(x => x.Id == id);
            return View(odevsModel);
        }

        [HttpPost]
        public IActionResult Delete(OdevModel model)
        {
            var odev = _context.Odevler.SingleOrDefault(x => x.Id == model.Id);
            _context.Odevler.Remove(odev);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult ChangeStatus(int id, bool st)
        {
            var odev = _context.Odevler.SingleOrDefault(x => x.Id == id);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}