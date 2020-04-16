using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Todo.Api.Models;
using Todo.Api.Services;

namespace Todo.Api.Controllers
{
    [ApiController]
    [Route("api/todos")]
    public class TodoItemsController : ControllerBase
    {
      private TodoRepository repository;
     public TodoItemsController()
     {
         repository = new TodoRepository();
     }
    [HttpGet]
     public IActionResult GetTodos()
     {
         var result = repository.GetAllTodoItems();
         if (result == null)
         {
             return NotFound();
         }
         return Ok(result);
     }   
    }
}
