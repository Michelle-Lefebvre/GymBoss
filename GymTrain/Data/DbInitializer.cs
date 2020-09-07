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
                new Trainer{LastName="Mahtack", FirstMidName="Sharie", Certified="Kinesiologist", Education="Bs", Specialty="Rehabilitation", Description="20 years experience. Faucibus purus in massa tempor nec feugiat nisl pretium. Pharetra vel turpis nunc eget lorem dolor sed. Mattis pellentesque id nibh tortor id aliquet lectus. Elit duis tristique sollicitudin nibh sit amet commodo nulla. Facilisis magna etiam tempor orci eu lobortis. Sit amet tellus cras adipiscing enim eu turpis egestas. At in tellus integer feugiat scelerisque varius. Ultrices in iaculis nunc sed augue lacus viverra vitae congue. Proin sagittis nisl rhoncus mattis rhoncus urna neque viverra justo. Nulla facilisi cras fermentum odio eu. Vestibulum mattis ullamcorper velit sed ullamcorper morbi tincidunt ornare massa. Elementum curabitur vitae nunc sed velit dignissim sodales.", Image="profilePicWoman.jpg", IsMale=0, Pkg5=100, Pkg12=85, Pkg20=80},
                
                new Trainer{LastName="Glenski", FirstMidName="Marie", Certified="Sports Therapist, Kinesiologist", Education="Bs", Specialty="Resistance, Rehabilitation", Description="Specialist in high intensity training in resistance and rehabilitation. Faucibus purus in massa tempor nec feugiat nisl pretium. Pharetra vel turpis nunc eget lorem dolor sed. Mattis pellentesque id nibh tortor id aliquet lectus. Elit duis tristique sollicitudin nibh sit amet commodo nulla. Facilisis magna etiam tempor orci eu lobortis. Sit amet tellus cras adipiscing enim eu turpis egestas. At in tellus integer feugiat scelerisque varius. Ultrices in iaculis nunc sed augue lacus viverra vitae congue. Proin sagittis nisl rhoncus mattis rhoncus urna neque viverra justo. Nulla facilisi cras fermentum odio eu. Vestibulum mattis ullamcorper velit sed ullamcorper morbi tincidunt ornare massa. Elementum curabitur vitae nunc sed velit dignissim sodales.", Image="profilePicWoman2.jpg", IsMale=0, Pkg5=110, Pkg12=100, Pkg20=95},
                
                new Trainer{LastName="Maison", FirstMidName="Jason", Certified="Coach, Kinesiologist", Education="PT", Specialty="Powerlifting", Description="Specialist in high-intensity training in resistance and lifting heavy weights (relatively). Faucibus purus in massa tempor nec feugiat nisl pretium. Pharetra vel turpis nunc eget lorem dolor sed. Mattis pellentesque id nibh tortor id aliquet lectus. Elit duis tristique sollicitudin nibh sit amet commodo nulla. Facilisis magna etiam tempor orci eu lobortis. Sit amet tellus cras adipiscing enim eu turpis egestas. At in tellus integer feugiat scelerisque varius. Ultrices in iaculis nunc sed augue lacus viverra vitae congue. Proin sagittis nisl rhoncus mattis rhoncus urna neque viverra justo. Nulla facilisi cras fermentum odio eu. Vestibulum mattis ullamcorper velit sed ullamcorper morbi tincidunt ornare massa. Elementum curabitur vitae nunc sed velit dignissim sodales.", Image="profilePicMan4.jpg", IsMale=1, Pkg5=70, Pkg12=65, Pkg20=60},
                
                new Trainer{LastName="Trabucco", FirstMidName="Dino", Certified="Personal Trainer", Education="YMCA Certified", Specialty="Sports", Description="Marathons and Triathletes. Faucibus purus in massa tempor nec feugiat nisl pretium. Pharetra vel turpis nunc eget lorem dolor sed. Mattis pellentesque id nibh tortor id aliquet lectus. Elit duis tristique sollicitudin nibh sit amet commodo nulla. Facilisis magna etiam tempor orci eu lobortis. Sit amet tellus cras adipiscing enim eu turpis egestas. At in tellus integer feugiat scelerisque varius. Ultrices in iaculis nunc sed augue lacus viverra vitae congue. Proin sagittis nisl rhoncus mattis rhoncus urna neque viverra justo. Nulla facilisi cras fermentum odio eu. Vestibulum mattis ullamcorper velit sed ullamcorper morbi tincidunt ornare massa. Elementum curabitur vitae nunc sed velit dignissim sodales.", Image="profilePicMan.jpg", IsMale=1, Pkg5=68, Pkg12=60, Pkg20=55},
                
                new Trainer{LastName="Skites", FirstMidName="Matt", Certified="Personal Trainer", Education="YMCA FIT - Individual Conditioning, YMCA FIT - Corrective Conditioning", Specialty="", Description="Functional, HIIT and Circuit are the types of training we will focus on. Faucibus purus in massa tempor nec feugiat nisl pretium. Pharetra vel turpis nunc eget lorem dolor sed. Mattis pellentesque id nibh tortor id aliquet lectus. Elit duis tristique sollicitudin nibh sit amet commodo nulla. Facilisis magna etiam tempor orci eu lobortis. Sit amet tellus cras adipiscing enim eu turpis egestas. At in tellus integer feugiat scelerisque varius. Ultrices in iaculis nunc sed augue lacus viverra vitae congue. Proin sagittis nisl rhoncus mattis rhoncus urna neque viverra justo. Nulla facilisi cras fermentum odio eu. Vestibulum mattis ullamcorper velit sed ullamcorper morbi tincidunt ornare massa. Elementum curabitur vitae nunc sed velit dignissim sodales.", Image="profilePicMan2.jpg", IsMale=0, Pkg5=50, Pkg12=45, Pkg20=40},
                
                new Trainer{LastName="Ngwanza", FirstMidName="Nuru", Certified="Kinesiologist", Education="Bs", Specialty="Rehabilitation", Description="Faucibus purus in massa tempor nec feugiat nisl pretium. Pharetra vel turpis nunc eget lorem dolor sed. Mattis pellentesque id nibh tortor id aliquet lectus. Elit duis tristique sollicitudin nibh sit amet commodo nulla. Facilisis magna etiam tempor orci eu lobortis. Sit amet tellus cras adipiscing enim eu turpis egestas. At in tellus integer feugiat scelerisque varius. Ultrices in iaculis nunc sed augue lacus viverra vitae congue. Proin sagittis nisl rhoncus mattis rhoncus urna neque viverra justo. Nulla facilisi cras fermentum odio eu. Vestibulum mattis ullamcorper velit sed ullamcorper morbi tincidunt ornare massa. Elementum curabitur vitae nunc sed velit dignissim sodales.", Image="profilePicWoman3.jpg", IsMale=0, Pkg5=100, Pkg12=85, Pkg20=80}
            };

            context.Trainers.AddRange(Trainer);
            context.SaveChanges();

            var Results = new Result[]
            {
                new Result{ClientID=3, TrainerID=1, Date=DateTime.Parse("2020-09-01"), RestingHeartRate=68, Height=58, Weight=140, BMI=29, Neck=12, Bust=30, Chest=27, UpperArm=13, Forearm=10, Waist=27, Hips=32, Thigh=12, Calves=6}, 
                
                new Result{ClientID=3, TrainerID=1, Date=DateTime.Parse("2020-08-01"), RestingHeartRate=70, Height=58, Weight=155, BMI=32, Neck=16, Bust=32, Chest=30, UpperArm=16, Forearm=12, Waist=29, Hips=36, Thigh=14, Calves=6}, 
                
                new Result{ClientID=3, TrainerID=1, Date=DateTime.Parse("2020-07-01"), RestingHeartRate=72, Height=58, Weight=173, BMI=36, Neck=17, Bust=33, Chest=30, UpperArm=17, Forearm=15, Waist=31, Hips=39, Thigh=16, Calves=7}, 
                
                new Result{ClientID=5, TrainerID=1, Date=DateTime.Parse("2020-09-04"), RestingHeartRate=69, Height=66, Weight=143, BMI=23, Neck=7, Bust=30, Chest=27, UpperArm=10, Forearm=6, Waist=24, Hips=26, Thigh=8, Calves=4}, 
                
                new Result{ClientID=5, TrainerID=1, Date=DateTime.Parse("2020-08-11"), RestingHeartRate=69, Height=66, Weight=150, BMI=24, Neck=9, Bust=32, Chest=28, UpperArm=10, Forearm=7, Waist=26, Hips=28, Thigh=9, Calves=5}, 
                
                new Result{ClientID=5, TrainerID=1, Date=DateTime.Parse("2020-07-01"), RestingHeartRate=70, Height=66, Weight=155, BMI=25, Neck=10, Bust=33, Chest=28, UpperArm=10, Forearm=7, Waist=28, Hips=30, Thigh=10, Calves=5}, 
            };

            context.Results.AddRange(Results);
            context.SaveChanges();

            var Sessions = new Session[]
            {
                new Session{TrainerID=1,ClientID=3, DayTime=DateTime.Parse("09/18/2020 07:00:00")},
                new Session{TrainerID=1,ClientID=3, DayTime=DateTime.Parse("09/20/2020 07:00:00")},
                new Session{TrainerID=1,ClientID=3, DayTime=DateTime.Parse("09/22/2020 07:00:00")},
                new Session{TrainerID=1,ClientID=3, DayTime=DateTime.Parse("09/24/2020 07:00:00")},
                new Session{TrainerID=1,ClientID=3, DayTime=DateTime.Parse("09/26/2020 07:00:00")},

                new Session{TrainerID=1,ClientID=5, DayTime=DateTime.Parse("09/18/2020 08:00:00")},
                new Session{TrainerID=1,ClientID=5, DayTime=DateTime.Parse("09/20/2020 08:00:00")},
                new Session{TrainerID=1,ClientID=5, DayTime=DateTime.Parse("09/22/2020 08:00:00")},
                new Session{TrainerID=1,ClientID=5, DayTime=DateTime.Parse("09/24/2020 08:00:00")},
                new Session{TrainerID=1,ClientID=5, DayTime=DateTime.Parse("09/26/2020 08:00:00")},
                
                new Session{TrainerID=1,ClientID=7, DayTime=DateTime.Parse("09/18/2020 09:15:00")},
                new Session{TrainerID=1,ClientID=7, DayTime=DateTime.Parse("09/20/2020 09:15:00")},
                new Session{TrainerID=1,ClientID=7, DayTime=DateTime.Parse("09/22/2020 09:15:00")},
                new Session{TrainerID=1,ClientID=7, DayTime=DateTime.Parse("09/24/2020 09:15:00")},
                new Session{TrainerID=1,ClientID=7, DayTime=DateTime.Parse("09/26/2020 09:15:00")},
                
                new Session{TrainerID=1,ClientID=9, DayTime=DateTime.Parse("09/18/2020 10:30:00")},
                new Session{TrainerID=1,ClientID=9, DayTime=DateTime.Parse("09/20/2020 10:30:00")},
                new Session{TrainerID=1,ClientID=9, DayTime=DateTime.Parse("09/22/2020 10:30:00")},
                new Session{TrainerID=1,ClientID=9, DayTime=DateTime.Parse("09/24/2020 10:30:00")},
                new Session{TrainerID=1,ClientID=9, DayTime=DateTime.Parse("09/26/2020 10:30:00")},
                
                new Session{TrainerID=1,ClientID=11, DayTime=DateTime.Parse("09/18/2020 12:00:00")},
                new Session{TrainerID=1,ClientID=11, DayTime=DateTime.Parse("09/20/2020 12:00:00")},
                new Session{TrainerID=1,ClientID=11, DayTime=DateTime.Parse("09/22/2020 12:00:00")},
                new Session{TrainerID=1,ClientID=11, DayTime=DateTime.Parse("09/24/2020 12:00:00")},
                new Session{TrainerID=1,ClientID=11, DayTime=DateTime.Parse("09/26/2020 12:00:00")},
                
                
            };

            context.Sessions.AddRange(Sessions);
            context.SaveChanges();
        }
    }
}