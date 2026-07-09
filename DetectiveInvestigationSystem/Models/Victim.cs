using System;

namespace DetectiveInvestigationSystem.Models
{
    public class Victim : Person
    {
        public string CauseOfDeath { get; }
        public string TimeOfDeath { get; }

        public Victim(
            string name,
            int age,
            string jobTitle,
            string causeOfDeath,
            string timeOfDeath)
            : base(name, age, jobTitle)
        {
            CauseOfDeath = causeOfDeath;
            TimeOfDeath = timeOfDeath;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("===== Victim Information =====");

            base.DisplayInfo();

            Console.WriteLine($"Cause Of Death : {CauseOfDeath}");
            Console.WriteLine($"Time Of Death  : {TimeOfDeath}");
        }
    }
}