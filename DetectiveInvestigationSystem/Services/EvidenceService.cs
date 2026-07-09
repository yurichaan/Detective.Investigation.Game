using System;
using DetectiveInvestigationSystem.Models;

namespace DetectiveInvestigationSystem.Services
{
    public class EvidenceService
    {
        public void ShowEvidence(Evidence evidence)
        {
            Console.Clear();

            evidence.DisplayEvidence();

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}