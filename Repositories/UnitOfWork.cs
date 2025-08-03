using LibraryApi.Data;
using LibraryApi.Interfaces;
using LibraryApi.Models;
using System.Threading.Tasks;

namespace LibraryApi.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    
    public IGenericRepository<Category> Categories { get; }
    public IBookRepository Books { get; }

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
        Books = new BookRepository(context);
        Categories = new GenericRepository<Category>(context);
    }

    public async Task<int> CompleteAsync() => await _context.SaveChangesAsync();//ay savechanges b3ml feha write ll update and create data(make them in order to other classes inhertience from them)
}
/////********(Implementation)*********
////To implement the logic to coordinate all repositories.
////Ensures single SaveChanges() call after multiple DB operations.

///////Think of this like the project manager that ensures all the team (repositories) finish their tasks before submitting (saving changes to DB).