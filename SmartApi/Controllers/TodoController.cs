using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        public TodoController(ITodoRepository todoItems)
        {
            TodoItems = todoItems;
        }

        public ITodoRepository TodoItems { get; set; }
        [HttpGet]
        public IEnumerable<TodoItem> GetAll()
        {
            return TodoItems.GetAll();
        }
        [HttpGet("{id}", Name = "GetTodo")]
        public ActionResult GetById(string id)
        {
            var item = TodoItems.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            //else
            return new ObjectResult(item);

        }
        [HttpPost]
        public IActionResult Create([FromBody] TodoItem item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            TodoItems.Add(item);
            return CreatedAtRoute("GetTodo", new { item.Key }, item);
            {

            }
        }
        [HttpPut("{id}")]
        public IActionResult Update(string id, [FromBody] TodoItem item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            TodoItems.Add(item);
            return new NoContentResult();

        }
        [HttpPatch("{id}")]
        public IActionResult Update([FromBody] TodoItem item, string id)
        {
            if (item == null)
            {
                return NotFound();

            }

            var todo = TodoItems.Find(id);
            if (todo == null)
            {
                return NotFound();
            }
            item.Key = todo.Key;
            TodoItems.Update(item);
            return new NoContentResult();
            }
        [HttpDelete("{id}")]
        public IActionResult Delete(string id) 
        {
            var todo = TodoItems.Find(id);
            if (id == null)
            {
                return NotFound();

            }
            TodoItems.Remove(id);
            return new NoContentResult();

        }
    }
}
