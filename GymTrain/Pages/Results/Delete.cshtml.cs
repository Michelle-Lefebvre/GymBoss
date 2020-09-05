using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GymTrain.Data;
using GymTrain.Models;

namespace GymTrain.Pages.Results
{
    public class DeleteModel : PageModel
    {
        private readonly GymTrain.Data.GymTrainContext _context;

        public DeleteModel(GymTrain.Data.GymTrainContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Result Result { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Result = await _context.Results.FirstOrDefaultAsync(m => m.ResultID == id);

            if (Result == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Result = await _context.Results.FindAsync(id);

            if (Result != null)
            {
                _context.Results.Remove(Result);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
