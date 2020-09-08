using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GymTrain.Data;
using GymTrain.Models;
using Microsoft.Data.SqlClient;


namespace GymTrain.Pages.Clients
{
    public class IndexModel : PageModel
    {
        private readonly GymTrainContext _context;

        public IndexModel(GymTrainContext context)
        {
            _context = context;
        }
        // sort by column heading
        public string FirstMidNameSort { get; set; }
        public string LastNameSort { get; set; }
        public string StartDateSort { get; set; }

        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public IList<Client> Clients { get;set; }
        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            FirstMidNameSort = String.IsNullOrEmpty(sortOrder) ? "firstname_desc" : "";
            LastNameSort = String.IsNullOrEmpty(sortOrder) ? "lastname_desc" : "";
            StartDateSort = sortOrder == "Date" ? "date_desc" : "Date";

            CurrentFilter = searchString;

            IQueryable<Client> clientsIQ = from c in _context.Clients select c;

            if (!String.IsNullOrEmpty(searchString))
            {
                // makes search case insensitive: .ToUpper().Contains(searchString.ToUpper()
                clientsIQ = clientsIQ.Where(c => c.LastName.ToUpper().Contains(searchString.ToUpper())
                                       || c.FirstMidName.ToUpper().Contains(searchString.ToUpper()));
                     
            }

            switch (sortOrder)
            {
                case "firstname_desc":
                    clientsIQ = clientsIQ.OrderByDescending(c => c.FirstMidName);
                    break;
                case "lastname_desc":
                    clientsIQ = clientsIQ.OrderByDescending(c => c.LastName);
                    break;
                case "Date":
                    clientsIQ = clientsIQ.OrderBy(c => c.StartDate);
                    break;
                case "date_desc":
                    clientsIQ = clientsIQ.OrderByDescending(c => c.StartDate);
                    break;

                case "firstname":
                    clientsIQ = clientsIQ.OrderBy(c => c.FirstMidName);
                    break;
                default:
                    clientsIQ = clientsIQ.OrderBy(c => c.LastName);
                    break;
            }
            Clients = await clientsIQ.AsNoTracking().ToListAsync();
        }
    }
}
