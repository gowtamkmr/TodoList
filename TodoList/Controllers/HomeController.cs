using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TodoList.Models;

namespace TodoList.Controllers
{
    public class HomeController : Controller
    {
        private readonly IToDoRepository _taskRepository;

        public HomeController(IToDoRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        //Code to Retrive data during initial load
        public IActionResult Index()
        {
            try
            {
                var model = _taskRepository.GetTodoList();
                return View(model);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        //Code to add a To-Do Item
        [HttpPost]
        public ToDo CreateToDo(string todoItem)
        {           
                ToDo newToDo = _taskRepository.AddTodo(todoItem);
                return newToDo;            
        }
               
    }
}
