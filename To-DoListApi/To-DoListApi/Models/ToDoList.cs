using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace To_DoListApi.Models
{
    class ToDoList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsCompleted { get; set; } = false;
        public DateTime UntilDate { get; set; }
        public DateTime ModifiteDate { get; set; }
    }
}
