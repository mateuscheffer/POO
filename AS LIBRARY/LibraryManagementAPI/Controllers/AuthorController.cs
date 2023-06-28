using System.Collections.Generic;
using AutoMapper;
using LibraryManagementAPI.Domain.DTOs;
using LibraryManagementAPI.Domain.Interfaces;
using LibraryManagementAPI.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementAPI.Controllers
{
    [ApiController]
    [Route("api/author")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public AuthorController(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var authors = _authorRepository.GetAll();
            var authorDTOs = _mapper.Map<List<AuthorDTO>>(authors);
            
            return Ok(authorDTOs);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var author = _authorRepository.GetById(id);

            if (author == null)
            {
                return NotFound();
            }

            var authorDTO = _mapper.Map<AuthorDTO>(author);
            
            return Ok(authorDTO);
        }

        [HttpPost]
        public IActionResult Create(AuthorDTO authorDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var author = _mapper.Map<Author>(authorDTO);
            _authorRepository.Add(author);

            return CreatedAtAction(nameof(GetById), new { id = author.Id }, author);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, AuthorDTO authorDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var author = _authorRepository.GetById(id);

            if (author == null)
            {
                return NotFound();
            }

            _mapper.Map(authorDTO, author);
            _authorRepository.Update(author);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var author = _authorRepository.GetById(id);

            if (author == null)
            {
                return NotFound();
            }

            _authorRepository.Delete(author);

            return NoContent();
        }
    }
}
