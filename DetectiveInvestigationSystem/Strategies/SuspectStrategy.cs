using System;
using DetectiveInvestigationSystem.Interfaces;
using DetectiveInvestigationSystem.Models;

namespace DetectiveInvestigationSystem.Strategies
{
    public class SuspectStrategy : IInvestigationStrategy
    {
        public void Execute(Case currentCase)
        {
            Console.Clear();

            foreach (var suspect in currentCase.Suspects)
            {
                suspect.DisplayInfo();
                Console.WriteLine("---------------------------");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}