using System;
using DetectiveInvestigationSystem.Interfaces;
using DetectiveInvestigationSystem.Models;

namespace DetectiveInvestigationSystem.Strategies
{
    public class EvidenceStrategy : IInvestigationStrategy
    {
        public void Execute(Case currentCase)
        {
            Console.Clear();

            foreach (var evidence in currentCase.EvidenceList)
            {
                evidence.DisplayEvidence();
                Console.WriteLine("---------------------------");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}