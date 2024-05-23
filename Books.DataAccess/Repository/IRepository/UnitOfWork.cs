using BooksApp.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.DataAccess.Repository.IRepository
{
    public class UnitOfWork : IUnitOfWork
    {
        private BooksDbContext _db;
        public ICategoryRepository Category { get; private set; }
        public UnitOfWork(BooksDbContext db) 
        {
            _db = db;
            Category = new CategoryRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
