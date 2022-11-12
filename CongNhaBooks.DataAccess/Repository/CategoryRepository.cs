using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CongNhaBooks.DataAccess.Repository.IRepository;
using CongNhaBooks.Models;
using CongNhaBookStore.DataAccess.Data;

namespace CongNhaBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            // use .NET Linq to retrieve the first or dedault category object
            // then pass the id as generic entiry which matches the category ID
            var objFormDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if(objFormDb != null) // save changes if not null
            {
                objFormDb.Name = category.Name;
                //_db.SaveChanges(); Removed this one
            }
        }
    }
}

