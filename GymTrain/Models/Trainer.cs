using System.Collections.Generic;

namespace GymTrain.Models
{
    public class Trainer
    {
        public int TrainerID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public string Certified { get; set; }
        public string Education { get; set; }
        public string Specialty { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int IsMale { get; set; }
        public decimal Pkg5 { get; set; }
        public decimal Pkg12 { get; set; }
        public decimal Pkg20 { get; set; }

        public ICollection<Client> Clients { get; set; }
        public ICollection<Session> Sessions { get; set; }
    }
}