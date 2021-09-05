using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Models
{
    public interface IToDoRepository
    {
        IEnumerable<ToDo> GetTodoList();
        ToDo AddTodo(string todoItem);
    }
}
