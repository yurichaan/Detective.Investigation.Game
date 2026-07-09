using System;
using DetectiveInvestigationSystem.Interfaces;
using DetectiveInvestigationSystem.Models;

namespace DetectiveInvestigationSystem.Strategies
{
    public class VictimStrategy : IInvestigationStrategy
    {
        public void Execute(Case currentCase)
        {
            Console.Clear();

            currentCase.Victim.DisplayInfo();

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}