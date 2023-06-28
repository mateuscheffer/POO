using System.Collections.Generic;
using AutoMapper;
using LibraryManagementAPI.Domain.DTOs;
using LibraryManagementAPI.Domain.Interfaces;
using LibraryManagementAPI.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementAPI.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        // private readonly IUserService _userService;

        public UserController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userRepository.GetAll();
            var userDTOs = _mapper.Map<List<UserDTO>>(users);
            
            return Ok(userDTOs);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _userRepository.GetById(id);

            if (user == null)
            {
                return NotFound();
            }

            var userDTO = _mapper.Map<UserDTO>(user);
            
            return Ok(userDTO);
        }

        [HttpPost]
        public IActionResult Create(UserDTO userDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var user = _mapper.Map<User>(userDTO);
            _userRepository.Add(user);

            return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, UserDTO userDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var user = _userRepository.GetById(id);

            if (user == null)
            {
                return NotFound();
            }

            _mapper.Map(userDTO, user);
            _userRepository.Update(user);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var user = _userRepository.GetById(id);

            if (user == null)
            {
                return NotFound();
            }

            _userRepository.Delete(user);

            return NoContent();
        }

        // [HttpPost("{userId}/borrow/{bookId}")]
        // public IActionResult BorrowBook(int userId, int bookId)
        // {
        //     try
        //     {
        //         _userService.BorrowBook(userId, bookId);
        //         return Ok("Livro emprestado com sucesso!");
        //     }
        //     catch (NotFoundException)
        //     {
        //         return NotFound("Usuário ou livro não encontrado.");
        //     }
        //     catch (InvalidOperationException)
        //     {
        //         return BadRequest("O livro não está disponível para empréstimo.");
        //     }
        //     catch (Exception)
        //     {
        //         return StatusCode(500, "Ocorreu um erro ao emprestar o livro.");
        //     }
        // }
    }
}
