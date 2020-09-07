using System;
using System.Collections.Generic;
namespace GymTrain.Models
{
    public class Result
    {
        public int ResultID { get; set; }
        public int ClientID { get; set; }
        public int TrainerID { get; set; }
        public DateTime Date { get; set; }
        public int RestingHeartRate { get; set; }
        public int Height { get; set; }
        public decimal Weight { get; set; }
        public decimal BMI { get; set; }
        public decimal Neck { get; set; }
        public decimal Bust { get; set; }
        public decimal Chest { get; set; }
        public decimal UpperArm { get; set; }
        public decimal Forearm { get; set; }
        public decimal Waist { get; set; }
        public decimal Hips { get; set; }
        public decimal Thigh { get; set; }
        public decimal Calves { get; set; }

        public ICollection<Result> Results { get; set; }
    }
}