using Microsoft.AspNetCore.Mvc;
using LibraryManagementAPI.Services;
using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly BookService _service;

        public BooksController(BookService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var book = _service.GetById(id);
            return book == null ? NotFound() : Ok(book);
        }

        [HttpGet("search")]
        public IActionResult GetByTitle([FromQuery] string title)
        {
            var books = _service.GetByTitle(title);
            return Ok(books);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Book book)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var createdBook = _service.Add(book);
            return CreatedAtAction(nameof(GetById), new { id = createdBook.Id }, createdBook);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Book updatedBook)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var success = _service.Update(id, updatedBook);
            return success ? NoContent() : NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var success = _service.Delete(id);
            return success ? Ok() : NotFound();
        }
    }
}
