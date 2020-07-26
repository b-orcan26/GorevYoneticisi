using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GorevYoneticisi.Models
{
    public interface IRepository<T> where T:class
    {
        DbSet<T> Table { get; }
        T Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);

        IQueryable<T> All();
        
    }
}
