using BooksApp_Temp.Data;
using BooksApp_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BooksApp_Temp.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Books_RazorDbContext _db;
        public List<Category> CategoryList { get; set; }
        public IndexModel( Books_RazorDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
           CategoryList = _db.categories.ToList();
        }
    }
}
