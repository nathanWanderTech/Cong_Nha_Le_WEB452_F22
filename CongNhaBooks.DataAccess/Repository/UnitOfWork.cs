﻿using System;
using System.Collections.Generic;
using System.Text;

using CongNhaBooks.DataAccess.Repository.IRepository;
using CongNhaBookStore.DataAccess.Data;

namespace CongNhaBooks.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public ICategoryRepository Category { get; private set; }
        public ISP_Call SP_Call { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save() // all changes will be saved when the save method is called at the parent level
        {
            _db.SaveChanges();
        }
    }
}

