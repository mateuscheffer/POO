using AutoMapper;
using LibraryManagementAPI.Domain.DTOs;
using LibraryManagementAPI.Domain.Interfaces;
using LibraryManagementAPI.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementAPI.Controllers
{
    [ApiController]
    [Route("api/book")]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public BookController(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var books = _bookRepository.GetAll();
            var bookDTOs = _mapper.Map<List<BookDTO>>(books);
            
            return Ok(bookDTOs);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var book = _bookRepository.GetById(id);

            if (book == null)
            {
                return NotFound();
            }

            var bookDTO = _mapper.Map<BookDTO>(book);
            
            return Ok(bookDTO);
        }

        [HttpPost]
        public IActionResult Create(BookDTO bookDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var book = _mapper.Map<Book>(bookDTO);
            _bookRepository.Add(book);

            return CreatedAtAction(nameof(GetById), new { id = book.Id }, book);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, BookDTO bookDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var book = _bookRepository.GetById(id);

            if (book == null)
            {
                return NotFound();
            }

            _mapper.Map(bookDTO, book);
            _bookRepository.Update(book);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var book = _bookRepository.GetById(id);

            if (book == null)
            {
                return NotFound();
            }

            _bookRepository.Delete(book);

            return NoContent();
        }
    }
}
