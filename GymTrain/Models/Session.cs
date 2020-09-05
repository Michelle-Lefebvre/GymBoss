using System;

namespace GymTrain.Models
{
    public class Session
    {
        public int SessionID { get; set; }
        public int TrainerID { get; set; }
        public int ClientID { get; set; }
        public DateTime DayTime { get; set; }
        public string EmailReminder { get; set; }
        

        public Trainer Trainers { get; set; }
        public Client Clients { get; set; }
    }
}