using System;

namespace DetectiveInvestigationSystem.Models
{
    public class Evidence
    {
        public string Name { get; }
        public string Description { get; }

        public Evidence(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void DisplayEvidence()
        {
            Console.WriteLine($"Evidence : {Name}");
            Console.WriteLine($"Details  : {Description}");
        }
    }
}