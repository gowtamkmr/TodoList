using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Models
{
    public class ToDo
    {
        public int Id { get; set; }

        [Required]
        public string TaskName { get; set; }
    }
}
