using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace To_DoListApi.Models
{
    public class ToDoListContext : DbContext
    {
        public DbSet<ToDoList> TDList { get; set; }
        public ToDoListContext(DbContextOptions<ToDoListContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
