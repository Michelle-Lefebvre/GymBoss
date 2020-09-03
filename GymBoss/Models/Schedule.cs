using System;
namespace GymBoss.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public int PTrainerId { get; set; }
        public int ClientId { get; set; }
        public string EmailReminder { get; set; }
        public DateTime StartDate { get; set; }
    }
}