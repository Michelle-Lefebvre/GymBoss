using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GymTrain.Data;
using GymTrain.Models;

namespace GymTrain.Pages.Clients
{
    public class DetailsModel : PageModel
    {
        private readonly GymTrain.Data.GymTrainContext _context;

        public DetailsModel(GymTrain.Data.GymTrainContext context)
        {
            _context = context;
        }

        public Client Client { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Client = await _context.Clients.FirstOrDefaultAsync(m => m.ClientID == id);

            if (Client == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
