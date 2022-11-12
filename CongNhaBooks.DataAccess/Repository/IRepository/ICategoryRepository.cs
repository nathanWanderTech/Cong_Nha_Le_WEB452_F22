using System;
using System.Collections.Generic;
using System.Text;

using CongNhaBooks.Models;

namespace CongNhaBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}

