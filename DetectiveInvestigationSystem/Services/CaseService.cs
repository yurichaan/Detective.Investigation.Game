using System;
using DetectiveInvestigationSystem.Models;

namespace DetectiveInvestigationSystem.Services
{
    public class CaseService
    {
        public void ShowCase(Case currentCase)
        {
            Console.Clear();

            Console.WriteLine("========== CASE INFORMATION ==========");
            Console.WriteLine();

            Console.WriteLine("Case Name : " + currentCase.CaseName);
            Console.WriteLine("Victim    : " + currentCase.Victim.Name);
            Console.WriteLine("Location  : Afaq Technology Company");
            Console.WriteLine("Time      : 9:15 PM");

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}