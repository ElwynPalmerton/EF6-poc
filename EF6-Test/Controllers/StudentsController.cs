using System;
using System.Data.Entity;
using System.Threading.Tasks;
using EF6;
using EF6.Models;
using Microsoft.AspNetCore.Mvc;

namespace EF6_Test.Controllers
{


    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        //private readonly SchoolContext _context;

        //public StudentsController(SchoolContext context)
        //{
        //    _context = context;
        //}

        [HttpGet]
        [Route("index")]
        public async Task<IActionResult> Index()
        {
            using (var context = new SchoolContext())
            {
                return Ok(await context.Students.ToListAsync());
            }
        }

        //[HttpGet]
        //[Route("details")]
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var student = await _context.Students.SingleOrDefaultAsync(m => m.ID == id);
        //    if (student == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(student);
        //}
        
       
        //[HttpPost]
        //[Route("create")]
        //public async Task<IActionResult> Create(Student student)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Students.Add(student);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction("Index");
        //    }
        //    return Ok(student);
        //}

        //[HttpGet]
        //[Route("edit")]
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var student = await _context.Students.SingleOrDefaultAsync(m => m.ID == id);
        //    if (student == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(student);
        //}

  
        //[HttpPost]
        //[Route("edit")]
        //  public async Task<IActionResult> Edit(int id, Student student)
        //{
        //    if (id != student.ID)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        _context.Students.Attach(student);
        //        _context.Entry(student).State = EntityState.Modified;
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction("Index");
        //    }
        //    return Ok(student);
        //}

        //[HttpGet]
        //[Route("delete")]
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var student = await _context.Students.SingleOrDefaultAsync(m => m.ID == id);
        //    if (student == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(student);
        //}

        //[HttpPost, ActionName("delete")]
        ////[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var student = await _context.Students.SingleOrDefaultAsync(m => m.ID == id);
        //    _context.Students.Remove(student);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}

    }
}
