using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Models
{
    public class SQLToDoRepository : IToDoRepository
    {
        public readonly AppDbContext context;
        public SQLToDoRepository(AppDbContext context)
        {
            this.context = context;
        }

       
        public ToDo AddTodo(string todoItem)
        {
            var todoObj = new ToDo
            {
                TaskName = todoItem
            };
            context.ToDoTasks.Add(todoObj);
            context.SaveChanges();
            return todoObj;
        }

        public IEnumerable<ToDo> GetTodoList()
        {
            return context.ToDoTasks;
        }
    }
}
