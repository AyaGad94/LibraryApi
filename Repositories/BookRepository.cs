using LibraryApi.Data;
using LibraryApi.Interfaces;
using LibraryApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryApi.Repositories;

public class BookRepository : GenericRepository<Book>, IBookRepository
{
    private readonly AppDbContext _context;

    public BookRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Book>> GetAllWithCategoryAsync()
    {
        return await _context.Books
            .Include(b => b.Category)
            .ToListAsync();
    }

    public async Task<Book?> GetByIdWithCategoryAsync(int id)
    {
        return await _context.Books
            .Include(b => b.Category)////// .Include(...) to Eager Load Category///
            //We need to override the GetAllAsync and GetByIdAsync methods for Book specifically.
            ///3amlt kda 3shan l data bta3t l category kolha tzhar 

            .FirstOrDefaultAsync(b => b.Id == id);
    }
}
//*********** Implementation (Logic Layer)*********This folder contains the actual logic behind your interfaces
