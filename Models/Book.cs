namespace LibraryApi.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Author { get; set; } = null!;

    // Foreign key + Navigation to Category
    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;
}
