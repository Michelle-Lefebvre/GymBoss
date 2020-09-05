using System;
namespace GymBoss2.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public int TrainerId { get; set; }
        public int ClientId { get; set; }
        public string EmailReminder { get; set; }
        public DateTime StartDate { get; set; }
    }
}