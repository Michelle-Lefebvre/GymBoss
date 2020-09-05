using System;
using System.Collections.Generic;

namespace GymTrain.Models
{
    public class Client
    {
        public int ClientID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime StartDate { get; set; }

        // The Results property of a Client entity holds all of the Result entities that are related to that Client's ID.
        // Other collection types are List<Result> or HashSet<Result>
        public ICollection<Result> Results { get; set; }
        public ICollection<Session> Sessions { get; set; }
        
    }
}