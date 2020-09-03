using System;
namespace GymBoss.Models
{
    public class User
    {
        public int Id { get; set; }
        public string IsManager { get; set; }
        public string IsTrainer { get; set; }
        public string IsClient { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Cell { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Code { get; set; }
        public string EmerFirstName { get; set; }
        public string EmerLastName { get; set; }
        public string EmerPhone1 { get; set; }
        public string EmerPhone2 { get; set; }
        public string Allergies { get; set; }
        public string Injuries { get; set; }
        public DateTime StartDate { get; set; }
       
    }
}