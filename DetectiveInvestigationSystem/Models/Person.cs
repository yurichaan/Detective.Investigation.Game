using System;

namespace DetectiveInvestigationSystem.Models
{
    public abstract class Person
    {
        public string Name { get; }
        public int Age { get; }
        public string JobTitle { get; }

        protected Person(string name, int age, string jobTitle)
        {
            Name = name;
            Age = age;
            JobTitle = jobTitle;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name      : {Name}");
            Console.WriteLine($"Age       : {Age}");
            Console.WriteLine($"Job Title : {JobTitle}");
        }
    }
}