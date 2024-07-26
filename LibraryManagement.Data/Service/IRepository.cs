using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Data.Entity;
namespace LibraryManagement.Data.Service
{
    public interface IService<T>
    {
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(long id);
        Task<T> AddToLibrary(T entity);
        Task<T> GetById(long id);
        Task<T> GetByName(string name);
        Task<T> Borrow(string name);
        Task<T> Return(T entity);
    }
}