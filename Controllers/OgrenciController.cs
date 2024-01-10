using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebFinal.Models;
using WebFinal.ViewModels;

namespace WebFinal.Controllers
{
    public class OgrenciController : Controller
    {
        private readonly AppDbContext _context;

        public OgrenciController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }


        [Authorize]
        public IActionResult Index()
        {
            List<Students> objStudentList = _context.Students.ToList();
            return View(objStudentList);
        }

        public IActionResult Insert_Ogrenci() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insert_Ogrenci(OgrenciModel model)
        {


            var Student = new Students();
            Student.Id = model.Id;
            Student.FirstName = model.FirstName;
            Student.LastName = model.LastName;

            Student.Grade = model.Grade;
            Student.Assignments = model.Assignments;


            _context.Students.Add(Student);
            _context.SaveChanges();
            return RedirectToAction("Index");


        }
        public IActionResult Update(int id)
        {
            var OgrenciModel = _context.Students.Select(x => new OgrenciModel()
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Grade = x.Grade,
                Assignments = x.Assignments


            }).SingleOrDefault(x => x.Id == id);
            return View(OgrenciModel);
        }

        [HttpPost]
        public IActionResult Update(OgrenciModel model)
        {
            var student = _context.Students.SingleOrDefault(x => x.Id == model.Id);
            student.Id = model.Id;
            student.FirstName = model.FirstName;
            student.LastName = model.LastName;
            student.Grade = model.Grade;
            student.Assignments = model.Assignments;


            _context.Students.Update(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var OgrenciModel = _context.Students.Select(x => new OgrenciModel()
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,


            }).SingleOrDefault(x => x.Id == id);
            return View(OgrenciModel);
        }

        [HttpPost]
        public IActionResult Delete(OgrenciModel model)
        {
            var student = _context.Students.SingleOrDefault(x => x.Id == model.Id);
            _context.Students.Remove(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Detail(int id)
        {

            var OgrenciModel = _context.Students.Select(x => new OgrenciModel()
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Grade = x.Grade,
                Assignments = x.Assignments


            }).SingleOrDefault(x => x.Id == id);
            return View(OgrenciModel);
        }

    }

}
