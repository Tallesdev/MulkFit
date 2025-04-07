using Microsoft.AspNetCore.Mvc;
using MulkFit.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MulkFit.Controllers
{
    public class AlunoController : Controller
    {
        public Context context;
        public AlunoController(Context ctx)
        {
            context = ctx;
        }
         
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            ViewBag.PersonalID = new SelectList(context.personal.OrderBy(p => p.NomePersonal), "PersonalID", "NomePersonal");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Aluno aluno)
        {
            context.Add(aluno);
            context.SaveChanges();
            return View(aluno);
        }

        public IActionResult Details(int id)
        {
            var aluno = context.alunos
            .Include(p => p.personal)
            .FirstOrDefault(a => a.AlunoID == id);
            return View(aluno);
        }

        
        public IActionResult Edit(int id)
        {
            var aluno = context.alunos.Find(id);
            ViewBag.PersonalID = new SelectList(context.personal.OrderBy(p => p.NomePersonal), "PersonalID", "NomePersonal");
            return View(aluno);
        }

        [HttpPost]
        public IActionResult Edit(Aluno aluno)
        {
            context.Entry(aluno).State = EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var aluno = context.alunos
            .Include(p => p.personal)
            .FirstOrDefault(a => a.AlunoID == id);
            return View(aluno);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(Aluno aluno)
        {
            context.alunos.Remove(aluno);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
