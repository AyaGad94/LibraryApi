using System.Collections.Generic;

namespace LibraryApi.Models;

public class Category
{
    public int Id { get; set; }              // Primary key
    public string Name { get; set; } = null!;

    // Navigation property - a Category has many Books
    public ICollection<Book> Books { get; set; } = new List<Book>();
}
