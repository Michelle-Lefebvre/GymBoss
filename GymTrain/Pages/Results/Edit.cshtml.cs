using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GymTrain.Data;
using GymTrain.Models;

namespace GymTrain.Pages.Results
{
    public class EditModel : PageModel
    {
        private readonly GymTrain.Data.GymTrainContext _context;

        public EditModel(GymTrain.Data.GymTrainContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Result).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResultExists(Result.ResultID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ResultExists(int id)
        {
            return _context.Results.Any(e => e.ResultID == id);
        }
    }
}
