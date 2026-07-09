using System;
using DetectiveInvestigationSystem.Models;

namespace DetectiveInvestigationSystem.Services
{
    public class SuspectService
    {
        public void ShowSuspect(Suspect suspect)
        {
            Console.Clear();

            suspect.DisplayInfo();

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}