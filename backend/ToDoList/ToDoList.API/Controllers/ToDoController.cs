using Microsoft.AspNetCore.Mvc;
using ToDoList.API.DTO;
using ToDoList.API.Models;
using ToDoList.API.Repositories;
using ToDoList.API.Services;

namespace ToDoList.API.Controllers;

[ApiController]
[Route("todo")]
public class ToDoController : ControllerBase
{
    private readonly IToDoService _toDoService;

    public ToDoController(IToDoService toDoService)
    {
        _toDoService = toDoService;
    }

    [HttpGet]
    public List<ToDo> GetToDos()
    {
        return _toDoService.GetToDos() ;
    }
    
    [HttpPost(Name = "PostToDos")]
    public void AddToDo([FromBody] ToDoDTO dto)
    {
        _toDoService.AddToDo(dto);
        Console.WriteLine("test");
    }
    
    [HttpPatch(Name = "RemoveToDos")]
    public void RemoveToDo(int id)
    {
        _toDoService.RemoveToDo(id);
    }
}