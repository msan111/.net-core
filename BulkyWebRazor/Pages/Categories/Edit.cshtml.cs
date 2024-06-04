using BulkyWebRazor.Data;
using BulkyWebRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor.Pages.Categories;

[BindProperties]
public class Edit : PageModel
{
    private readonly ApplicationDbContext _db;

    public Category Category { get; set; }
    public Edit(ApplicationDbContext db)
    {
        _db = db;
    }
    public void OnGet(int? id)
    {
        if (id != null && id != null)
        {
            Category = _db.Categories.Find(id);
        }
    }

    public IActionResult OnPost()
    {
        if (ModelState.IsValid)
        {
            _db.Categories.Update(Category);
            _db.SaveChanges();
            TempData["success"] = "Category updated successfully";
            return RedirectToPage("Index");
        }

        return Page();

    }
}