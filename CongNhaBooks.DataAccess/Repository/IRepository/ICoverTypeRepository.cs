using System;
using System.Collections.Generic;
using System.Text;

using CongNhaBooks.Models;

namespace CongNhaBooks.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType coverType);
    }
}
