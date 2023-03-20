using System.Collections;
using ToDoList.API.DTO;
using ToDoList.API.Models;
using ToDoList.API.Services;

namespace ToDoList.API.Repositories;

public interface IToDoRepository
{
    public List<ToDo> getToDos();
    public void AddToDo(ToDoDTO todo);
    
    public void RemoveToDo(int id);
}

public class ToDoRepository : IToDoRepository
{
    private List<ToDo> ToDos;

    public ToDoRepository (){
        ToDos =  new List<ToDo> { };
    }

    public List<ToDo> getToDos()
    {
        return ToDos;
    }

    public void AddToDo(ToDoDTO todo)
    {
        ToDos.Add(new ToDo(
    ){TaskName = todo.TaskName,IsDone = todo.IsDone,Time = new DateTime(2022,10,15)});
    }

    public void RemoveToDo(int id)
    {
        var index = -1;
        for(var i = 0; i < ToDos.Count; i++) {
            if(ToDos[i].id == id) {
                index = i;
            }
        }

        if (index != -1)
        {
            ToDos.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("id not found");
        }
        Console.WriteLine("index of item delete is "+index.ToString());
        
    }
}