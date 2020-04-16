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
         var result = new List<TodoItem>(){
             new TodoItem{ Id = 1, Action="Thing one.", IsDone=true},
             new TodoItem{ Id = 2, Action="Thing two.", IsDone=false},
         };
         return Ok(result);
     }   
    }
}
