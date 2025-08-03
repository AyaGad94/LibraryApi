using LibraryApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryApi.Interfaces;

public interface IBookRepository : IGenericRepository<Book>
{
    Task<IEnumerable<Book>> GetAllWithCategoryAsync();///This says: “A book repository must have a method to get books with category info,
    /// but it doesn’t say how it's implemented.


    Task<Book?> GetByIdWithCategoryAsync(int id);
}
//***** Interfaces Folder***** ====To define what your code should do, not how.
