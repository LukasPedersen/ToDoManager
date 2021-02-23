using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoManager.Data;
using ToDoManager.Models;

namespace CRUDExample
{
    public class DeleteModel : PageModel
    {
        private readonly IRepository _context;

        public DeleteModel(IRepository context)
        {
            _context = context;
        }

        [BindProperty]
        public ToDo Todo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
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

        public IActionResult OnPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Todo = _context.GetItemById(id);

            if (Todo != null)
            {
                _context.Remove(Todo.Id);
            }

            return RedirectToPage("Index");
        }
    }
}
