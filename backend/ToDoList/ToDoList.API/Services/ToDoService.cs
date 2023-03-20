using System.Runtime.InteropServices;
using ToDoList.API.DTO;
using ToDoList.API.Models;
using ToDoList.API.Repositories;

namespace ToDoList.API.Services;

public interface IToDoService
{
    public List<ToDo> GetToDos();
    public void AddToDo(ToDoDTO todo);
    
    public void RemoveToDo(int id);

}

public class ToDoService : IToDoService
{
    private readonly IToDoRepository _toDoRepository;

    public ToDoService(IToDoRepository toDoRepository)
    {
        _toDoRepository = toDoRepository;
    }
    public List<ToDo> GetToDos()
    {
        return _toDoRepository.getToDos();
    }

    public void AddToDo(ToDoDTO todo)
    {
        _toDoRepository.AddToDo(todo);
    }
    
    public void RemoveToDo(int id)
    {
        _toDoRepository.RemoveToDo(id);
    }
}