using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using To_DoListApi.Models;

namespace To_DoListApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ToDoListController : ControllerBase
    {
        ToDoListContext db;
        public ToDoListController(ToDoListContext context)
        {
            db = context;
        }
    }
}
