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
    public class IndexModel : PageModel
    {
        private readonly GymTrain.Data.GymTrainContext _context;

        public IndexModel(GymTrain.Data.GymTrainContext context)
        {
            _context = context;
        }

        public IList<Client> Client { get;set; }

        public async Task OnGetAsync()
        {
            Client = await _context.Clients.ToListAsync();
        }
    }
}
