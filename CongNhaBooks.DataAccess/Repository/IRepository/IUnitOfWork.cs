using System;
using System.Collections.Generic;
using System.Text;

namespace CongNhaBooks.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }

        ISP_Call SP_Call { get; }

        ICoverTypeRepository CoverType { get; }
        IProductRepository Product { get; }

        void Save();
    }
}

