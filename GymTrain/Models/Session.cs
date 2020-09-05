using System;

namespace GymTrain.Models
{
    public class Session
    {
        public int SessionID { get; set; }
        public int TrainerID { get; set; }
        public int ClietnID { get; set; }
        public DateTime DayTime { get; set; }
        public string EmailReminder { get; set; }
        

        public Result Result { get; set; }
        public Client Client { get; set; }
    }
}