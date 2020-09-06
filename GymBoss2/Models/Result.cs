using System;
using System.Collections.Generic;

namespace GymBoss2.Models
{
    public class Result
    {
        public int ResultID { get; set; }
        public int ClientID { get; set; }
        public int TrainerID { get; set; }
        public DateTime Date { get; set; }
        public int RestingHeartRate { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int BMI { get; set; }
        public int Neck { get; set; }
        public int Bust { get; set; }
        public int Chest { get; set; }
        public int UpperArm { get; set; }
        public int Forearm { get; set; }
        public int Waist { get; set; }
        public int Hips { get; set; }
        public int Thigh { get; set; }
        public int Calves { get; set; }

        public ICollection<Result> Results { get; set; }
    }
}
