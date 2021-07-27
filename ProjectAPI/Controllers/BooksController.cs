using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAPI.Data.Models.ViewModels;
using ProjectAPI.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BooksService _booksService;

        public BooksController(BooksService booksService)
        {
            _booksService = booksService;
        }
        [HttpPost("add-book-with-authors")]
        public IActionResult AddBook([FromBody]BookVM book)
        {
            _booksService.AddBookWithAuthors(book);
            return Ok();
        }

        [HttpGet("get-book")]

        public IActionResult GetResult()
        {
            var result = _booksService.GetAllBooks();
            return Ok(result);
        }

        [HttpGet("get-book-id/{id}")]

        public IActionResult GetResultById(int id)
        {
            var selectedResult = _booksService.GetBookById(id);
            return Ok(selectedResult);
        }

        [HttpPut("update-book-id/{id}")]

        public IActionResult UpdateBookById(int id, [FromBody]BookVM book)
        {
            var updateBook = _booksService.UpdateBookById(id, book);
            return Ok(updateBook);
        }

        [HttpDelete("delete-book-id/{id}")]

        public IActionResult DeleteBookById(int id)
        {
            var deleteResult = _booksService.DeleteBookById(id);
            return Ok(deleteResult);
        }
    }
}
