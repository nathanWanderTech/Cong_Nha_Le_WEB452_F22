using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CongNhaBooks.DataAccess.Repository.IRepository;
using CongNhaBooks.Models;
using CongNhaBookStore.DataAccess.Data;

namespace CongNhaBooks.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product product)
        {
            // use .NET Linq to retrieve the first or dedault category object
            // then pass the id as generic entiry which matches the category ID
            var objFormDb = _db.Product.FirstOrDefault(s => s.Id == product.Id);
            if(objFormDb != null) // save changes if not null
            {
                if(product.ImageUrl != null)
                {
                    objFormDb.ImageUrl = product.ImageUrl; // add check for ImageUrl
                }
            }
            objFormDb.Title = product.Title;
            objFormDb.Description = product.Description;
            objFormDb.ISBN = product.ISBN;
            objFormDb.Author = product.Author;
            objFormDb.ListPrice = product.ListPrice;
            objFormDb.CategoryId = product.CategoryId;
            objFormDb.CoverTypeId = product.CoverTypeId;
        }
    }
}

