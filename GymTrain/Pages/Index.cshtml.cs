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

namespace GymTrain.Pages
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
        public string CertifiedSort { get; set; }
        public string SpecialtySort { get; set; }
        public string IsMaleSort { get; set; }
        public string Pkg5Sort { get; set; }


        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public IList<Trainer> Trainers { get;set; }

        public async Task OnGetAsync(string sortOrder)
        {
            FirstMidNameSort = String.IsNullOrEmpty(sortOrder) ? "firstname_desc" : "";
            LastNameSort = String.IsNullOrEmpty(sortOrder) ? "lastname_desc" : "";
            CertifiedSort = String.IsNullOrEmpty(sortOrder) ? "certified_desc" : "";
            SpecialtySort = String.IsNullOrEmpty(sortOrder) ? "specialty_desc" : "";
            IsMaleSort = String.IsNullOrEmpty(sortOrder) ? "isMale_desc" : "";
            Pkg5Sort = String.IsNullOrEmpty(sortOrder) ? "pkg5_desc" : "";
            
            IQueryable<Trainer> trainersIQ = from t in _context.Trainers select t;

            switch (sortOrder)
            {
                case "firstname_desc":
                    trainersIQ = trainersIQ.OrderByDescending(t => t.FirstMidName);
                    break;
                case "lastname_desc":
                    trainersIQ = trainersIQ.OrderByDescending(t => t.LastName);
                    break;
                case "certified_desc":
                    trainersIQ = trainersIQ.OrderByDescending(t => t.Certified);
                    break;
                case "specialty_desc":
                    trainersIQ = trainersIQ.OrderByDescending(t => t.Specialty);
                    break;
                case "isMale_desc":
                    trainersIQ = trainersIQ.OrderByDescending(t => t.IsMale);
                    break;
                case "pkg5_desc":
                    trainersIQ = trainersIQ.OrderByDescending(t => t.Pkg5);
                    break;

                case "firstname":
                    trainersIQ = trainersIQ.OrderBy(t => t.FirstMidName);
                    break;
                case "certified":
                    trainersIQ = trainersIQ.OrderBy(t => t.Certified);
                    break;
                case "specialty":
                    trainersIQ = trainersIQ.OrderBy(t => t.Specialty);
                    break;
                case "isMale":
                    trainersIQ = trainersIQ.OrderBy(t => t.IsMale);
                    break;
                case "pkg5":
                    trainersIQ = trainersIQ.OrderBy(t => t.Pkg5);
                    break;
                default:
                    trainersIQ = trainersIQ.OrderBy(t => t.LastName);
                    break;
            }
            Trainers = await trainersIQ.AsNoTracking().ToListAsync();
        }
    }
}
