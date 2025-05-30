using DiaryApp.Data;
using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiaryApp.Controllers;

public class DiaryController : Controller
{
    private readonly ApplicationDbContext _context;

    public DiaryController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        List<DiaryEntity> entities = _context.DiaryEntities.ToList();

        return View(entities);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(DiaryEntity entity)
    {
        if(entity != null && entity.Title.Length < 3)
        {
            ModelState.AddModelError("Title", "Title must be at least 3 chars long");
        }

        if (ModelState.IsValid) 
        {
            _context.DiaryEntities.Add(entity);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(entity);
    }


    [HttpGet]
    public IActionResult Edit(int? id)
    {
        if(id == null || id == 0)
        {
            return NotFound();
        }

        DiaryEntity entity = _context.DiaryEntities.FirstOrDefault(x => x.Id == id);

        if (entity == null)
        {
            return NotFound();
        }

        return View(entity);
    }

    [HttpPost]
    public IActionResult Edit(DiaryEntity entity)
    {
        if (entity != null && entity.Title.Length < 3)
        {
            ModelState.AddModelError("Title", "Title must be at least 3 chars long");
        }

        if (ModelState.IsValid)
        {
            _context.DiaryEntities.Update(entity);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(entity);
    }

    [HttpGet]
    public IActionResult Delete(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }

        DiaryEntity entity = _context.DiaryEntities.FirstOrDefault(x => x.Id == id);

        if (entity == null)
        {
            return NotFound();
        }

        return View(entity);
    }

    [HttpPost]
    public IActionResult Delete(DiaryEntity entity)
    {
        _context.DiaryEntities.Remove(entity);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}
