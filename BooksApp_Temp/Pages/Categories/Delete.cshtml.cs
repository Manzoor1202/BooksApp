using BooksApp_Temp.Data;
using BooksApp_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BooksApp_Temp.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly Books_RazorDbContext _db;

        public Category Category { get; set; }

        public DeleteModel(Books_RazorDbContext db)
        {
            _db = db;
            
        }
        public void OnGet( int? id)
        {
            Category = _db.categories.FirstOrDefault(c => c.Id == id);
        }

        public IActionResult OnPost( ) 
        {
            Category = _db.categories.FirstOrDefault(c => c.Id == Category.Id);
            _db.categories.Remove(Category);
            _db.SaveChanges();
            TempData["success"] = "Category deleted successfully";
            return RedirectToPage("Index");
        }
    }
}
