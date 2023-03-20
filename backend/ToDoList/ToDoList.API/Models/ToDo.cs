namespace ToDoList.API.Models;


public class ToDo
{
    public static int count = 0;
    public  int id { get; set;}
    public string TaskName {get;set;}
    public bool IsDone  {get;set;}
    public DateTime Time  {get;set;}
    
    public ToDo(){
        count = count+1;
        id = count;
    }
}