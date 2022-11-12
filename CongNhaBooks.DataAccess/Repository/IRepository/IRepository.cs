﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CongNhaBooks.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T Get(int id); // Retrieve a category from the database by id
        
        // List of Categories based on requirements
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedEnumerable<T>> orderBy = null,
            string includeProperties = null // useful for foreign key references
            );

        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
            );

        void Add(T entity); // to add an entity
        void Remove(int id); // to remove an object or Category
        void Remove(T entity); // another way to remove an object
        void RemoveRange(IEnumerable<T> entiry); // removes a complete rage of entities
    }
}

