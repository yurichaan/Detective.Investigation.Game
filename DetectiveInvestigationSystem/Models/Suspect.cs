using System;

namespace DetectiveInvestigationSystem.Models
{
    public class Suspect : Person
    {
        public string Motive { get; }
        public string Alibi { get; }
        public bool IsGuilty { get; }

        public Suspect(
            string name,
            int age,
            string jobTitle,
            string motive,
            string alibi,
            bool isGuilty)
            : base(name, age, jobTitle)
        {
            Motive = motive;
            Alibi = alibi;
            IsGuilty = isGuilty;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("===== Suspect Information =====");

            base.DisplayInfo();

            Console.WriteLine($"Alibi : {Alibi}");
        }
    }
}