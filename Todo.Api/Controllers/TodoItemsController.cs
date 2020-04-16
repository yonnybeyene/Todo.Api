using System;
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
    private ITodoRepository repository;
    public TodoItemsController(ITodoRepository todoRepository)
     {
         repository = new TodoRepository() ??
            throw new ArgumentNullException(nameof(todoRepository));
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
