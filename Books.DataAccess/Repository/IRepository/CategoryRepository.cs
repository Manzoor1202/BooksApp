using Books.Models;
using BooksApp.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Books.DataAccess.Repository.IRepository
{
    public class CategoryRepository :Repository<Category>, ICategoryRepository
    {
        private BooksDbContext _db;
        public CategoryRepository(BooksDbContext db) :base(db) 
        {
            _db = db;
        }

        public void Update(Category obj)
        {
           _db.Categories.Update(obj); 
        }
    }
}
