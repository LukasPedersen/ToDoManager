using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ToDoManager.Data;
using ToDoManager.Models;

namespace CRUDExample
{
    public class EditModel : PageModel
    {
        private readonly IRepository _context;

        public EditModel(IRepository context)
        {
            _context = context;
        }

        [BindProperty]
        public ToDo Todo { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Todo = _context.GetItemById(id.Value);

            if (Todo == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public IActionResult OnPost()
        {
            _context.Update(Todo);

            return RedirectToPage("./Index");
        }

        private bool PersonExists(int id)
        {
            ToDo p = _context.GetItemById(id);

            if (p != null)
            {
                return true;
            }
            return false;
        }
    }
}
