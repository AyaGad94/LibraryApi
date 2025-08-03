namespace LibraryApi.DTOs;

public class BookDto
{
    public int Id { get; set; }             
    public string Title { get; set; } = ""; 
    public string Author { get; set; } = ""; 
    public string CategoryName { get; set; } = ""; 
}
///////Read (Get) Representation///


//////Used when returning book data to the client ( in GET and POST responses).

/////Includes Id and readable CategoryName from the navigation property.//

////It is the "full view" of the book that includes extra context.