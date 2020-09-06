using GymTrain.Data;
using GymTrain.Models;
using System;
using System.Linq;

namespace GymTrain.Data
{
    public static class DbInitializer
    {
        public static void Initialize(GymTrainContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Clients.
            if (context.Clients.Any())
            {
                return;   // DB has been seeded
            }

            var Clients = new Client[]
            {
                new Client{FirstMidName="Carson",LastName="Alexander",StartDate=DateTime.Parse("2019-09-01")},
                new Client{FirstMidName="Meredith",LastName="Alonso",StartDate=DateTime.Parse("2017-09-01")},
                new Client{FirstMidName="Arturo",LastName="Anand",StartDate=DateTime.Parse("2018-09-01")},
                new Client{FirstMidName="Gytis",LastName="Barzdukas",StartDate=DateTime.Parse("2017-09-01")},
                new Client{FirstMidName="Yan",LastName="Li",StartDate=DateTime.Parse("2017-09-01")},
                new Client{FirstMidName="Peggy",LastName="Justice",StartDate=DateTime.Parse("2016-09-01")},
                new Client{FirstMidName="Laura",LastName="Norman",StartDate=DateTime.Parse("2018-09-01")},
                new Client{FirstMidName="Nino",LastName="Olivetto",StartDate=DateTime.Parse("2019-09-01")}
            };

            context.Clients.AddRange(Clients);
            context.SaveChanges();

            var Trainer = new Trainer[]
            {
                new Trainer{LastName="Mahtack", FirstMidName="Sharie", Certified="Kinesiologist", Education="Bs", Specialty="Rehabilitation", Description="20 years experience", Image="", IsMale="0", Pkg5="100", Pkg12="85", Pkg20="80"},
                
                new Trainer{LastName="Glenski", FirstMidName="Marie", Certified="Sports Therapist, Kinesiologist", Education="Bs", Specialty="Resistance, Rehabilitation", Description="Specialist in high intensity training in resistance and rehabilitation.", Image="", IsMale="0", Pkg5="110", Pkg12="100", Pkg20="95"},
                
                new Trainer{LastName="Maiton", FirstMidName="Jason", Certified="Coach, Kinesiologist", Education="PT", Specialty="Powerlifting", Description="Specialist in high-intensity training in resistance and lifting heavy weights (relatively).", Image="", IsMale="1", Pkg5="70", Pkg12="65", Pkg20="60"},
                
                new Trainer{LastName="Mahtack", FirstMidName="Sharie", Certified="Coach, Kinesiologist", Education="", Specialty="", Description="", Image="", IsMale="", Pkg5="100", Pkg12="85", Pkg20="80"},
                
                new Trainer{LastName="Mahtack", FirstMidName="Sharie", Certified="Coach, Kinesiologist", Education="", Specialty="", Description="", Image="", IsMale="", Pkg5="100", Pkg12="85", Pkg20="80"},
                
                new Trainer{LastName="Mahtack", FirstMidName="Sharie", Certified="Coach, Kinesiologist", Education="", Specialty="", Description="", Image="", IsMale="", Pkg5="100", Pkg12="85", Pkg20="80"},
                
                new Trainer{LastName="Mahtack", FirstMidName="Sharie", Certified="Coach, Kinesiologist", Education="", Specialty="", Description="", Image="", IsMale="", Pkg5="100", Pkg12="85", Pkg20="80"},
                
                new Trainer{LastName="Mahtack", FirstMidName="Sharie", Certified="Coach, Kinesiologist", Education="", Specialty="", Description="", Image="", IsMale="", Pkg5="100", Pkg12="85", Pkg20="80"},
    
            };

            context.Trainers.AddRange(Trainers);
            context.SaveChanges();

            var Results = new Result[]
            {
                new Result{ResultID=1050,Title="Chemistry",Credits=3},
                new Result{ResultID=4022,Title="Microeconomics",Credits=3},
                new Result{ResultID=4041,Title="Macroeconomics",Credits=3},
                new Result{ResultID=1045,Title="Calculus",Credits=4},
                new Result{ResultID=3141,Title="Trigonometry",Credits=4},
                new Result{ResultID=2021,Title="Composition",Credits=3},
                new Result{ResultID=2042,Title="Literature",Credits=4}
            };

            context.Results.AddRange(Results);
            context.SaveChanges();

            var Sessions = new Session[]
            {
                new Session{ClientID=1,ResultID=1050,Grade=Grade.A},
                new Session{ClientID=1,ResultID=4022,Grade=Grade.C},
                new Session{ClientID=1,ResultID=4041,Grade=Grade.B},
                new Session{ClientID=2,ResultID=1045,Grade=Grade.B},
                new Session{ClientID=2,ResultID=3141,Grade=Grade.F},
                new Session{ClientID=2,ResultID=2021,Grade=Grade.F},
                new Session{ClientID=3,ResultID=1050},
                new Session{ClientID=4,ResultID=1050},
                new Session{ClientID=4,ResultID=4022,Grade=Grade.F},
                new Session{ClientID=5,ResultID=4041,Grade=Grade.C},
                new Session{ClientID=6,ResultID=1045},
                new Session{ClientID=7,ResultID=3141,Grade=Grade.A},
            };

            context.Sessions.AddRange(Sessions);
            context.SaveChanges();
        }
    }
}