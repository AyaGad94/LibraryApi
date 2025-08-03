namespace LibraryApi.DTOs;

public class BookCreateDto
{
    public string Title { get; set; } = "";
    public string Author { get; set; } = "";
    public int CategoryId { get; set; }     // Needed to assign category
}

//*****Aim of DTOs/ Folder:////
////The DTOs folder contains Data Transfer Objects (DTOs) — special classes used to send and receive data between the API and the outside world (like Swagger, Postman, frontend apps).



///////Write (Input) Representation///
////Used when receiving input from the client ( in POST and PUT requests).
////Only includes data needed to create or update a book.
////Uses CategoryId (a foreign key), not the full CategoryName.