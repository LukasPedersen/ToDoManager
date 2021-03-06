﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoManager.Data;
using ToDoManager.Models;

namespace CRUDExample
{
    public class DetailsModel : PageModel
    {
        private readonly IRepository _context;

        public DetailsModel(IRepository context)
        {
            _context = context;
        }

        public ToDo Todo { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Todo = _context.GetItemById(id);

            if (Todo == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
