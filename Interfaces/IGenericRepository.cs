using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LibraryApi.Interfaces;

public interface IGenericRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetByIdAsync(int id);
    Task AddAsync(T entity);////Uses generics (<T>) to support any type
    void Update(T entity);
    void Delete(T entity);
    Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);///FindAsync allows filtering by custom conditions
    ////Expression<Func<T >>>>>This is the signature of an asynchronous method in C#
    /// Task<IEnumerable<T>>
// Task<>:
// This means the method is asynchronous and will return in the future (i.e., it's async and you should await it).

// Think of Task<T> as a promise to return a value of type T later.

// IEnumerable<T>:
// This means it will return a collection of items of type T.
// Example: a list of users (IEnumerable<User>).

/// Together:

//This method returns a task that will eventually give you a collection of T ( a list of employees, products).
///Expression<Func<T, bool>> is used so the code can be translated usually into SQL, when using LINQ to Entities (like with EF Core).
}
///////////////////////This interface provides reusable methods for any entity (Book, Category)///
/////To define the common operations: GetAll, GetById, Add, Update, Delete
