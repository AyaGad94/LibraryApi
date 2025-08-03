using LibraryApi.Models;
using System.Threading.Tasks;

namespace LibraryApi.Interfaces;

public interface IUnitOfWork
{
   
    IGenericRepository<Category> Categories { get; }
    IBookRepository Books { get; }

    Task<int> CompleteAsync(); // Saves all changes at UnitOfWork.cs file
}

////****(Interface)///////////
////To abstract the Unit of Work logic.
//////Allows Dependency Injection and loose coupling