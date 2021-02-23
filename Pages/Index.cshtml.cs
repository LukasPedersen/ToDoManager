using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using ToDoManager.Data;
using ToDoManager.Models;
using System.Threading.Tasks;

namespace ToDoManager.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IRepository _context;

        public IndexModel(IRepository context)
        {
            _context = context;
        }

        public IList<ToDo> ToDoList { get; set; }

        public void OnGet()
        {
            ToDoList = _context.GetAll();
        }
    }
}
