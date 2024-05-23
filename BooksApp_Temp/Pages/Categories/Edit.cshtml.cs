using BooksApp_Temp.Data;
using BooksApp_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BooksApp_Temp.Pages.Categories
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly Books_RazorDbContext _db;

        public Category Category { get; set; }

        public EditModel(Books_RazorDbContext db)
        {
            _db = db;   
        }
        public void OnGet(int? id)
        {
           Category = _db.categories.FirstOrDefault(c => c.Id == id);
        }

        public IActionResult OnPost() 
        {
            if (ModelState.IsValid)
            {
                _db.categories.Update(Category);
                _db.SaveChanges();
                TempData["success"] = "Category updated successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
