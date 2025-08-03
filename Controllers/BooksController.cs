using AutoMapper;
using LibraryApi.DTOs;
using LibraryApi.Interfaces;
using LibraryApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BooksController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public BooksController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    // GET: api/books
    [HttpGet]
    public async Task<ActionResult<IEnumerable<BookDto>>> GetAll()
    {
        var books = await _unitOfWork.Books.GetAllWithCategoryAsync(); //  include Category
        var result = _mapper.Map<IEnumerable<BookDto>>(books);
        return Ok(result);
    }

    // GET: api/books/5
    [HttpGet("{id}")]
    public async Task<ActionResult<BookDto>> GetById(int id)
    {
        var book = await _unitOfWork.Books.GetByIdWithCategoryAsync(id); //  include Category
        if (book == null)
            return NotFound();

        var result = _mapper.Map<BookDto>(book);
        return Ok(result);
    }

    // POST: api/books
    [HttpPost]
    public async Task<ActionResult<BookDto>> Create(BookCreateDto dto)
    {
    
        var book = _mapper.Map<Book>(dto);
        await _unitOfWork.Books.AddAsync(book);
        await _unitOfWork.CompleteAsync(); //save changes is better

        //  Reload the book WITH Category
        var savedBook = await _unitOfWork.Books.GetByIdWithCategoryAsync(book.Id);
        var result = _mapper.Map<BookDto>(savedBook);
        return CreatedAtAction(nameof(GetById), new { id = book.Id }, result);
    }

    // PUT: api/books/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, BookCreateDto dto)
    {
        var book = await _unitOfWork.Books.GetByIdAsync(id);
        if (book == null)
            return NotFound();

        _mapper.Map(dto, book); // Update book entity
        _unitOfWork.Books.Update(book);
        await _unitOfWork.CompleteAsync();

        return NoContent(); //return ok() is better
    }

    // DELETE: api/books/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var book = await _unitOfWork.Books.GetByIdAsync(id);
        if (book == null)
            return NotFound();

        _unitOfWork.Books.Delete(book);
        await _unitOfWork.CompleteAsync();

        return NoContent();
    }
}
