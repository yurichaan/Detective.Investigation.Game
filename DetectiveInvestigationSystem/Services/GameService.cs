using System;
using DetectiveInvestigationSystem.Models;
using DetectiveInvestigationSystem.Interfaces;
using DetectiveInvestigationSystem.Strategies;

namespace DetectiveInvestigationSystem.Services
{
    public class GameService
    {
        private readonly Case currentCase;

        public GameService(Case currentCase)
        {
            this.currentCase = currentCase;
        }

        public void ShowLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine(@"
     _____       _            _   _           _   
    |  __ \     | |          | | (_)         | |  
    | |  | | ___| |_ ___  ___| |_ _  ___ __ _| |_ 
    | |  | |/ _ \ __/ _ \/ __| __| |/ __/ _` | __|
    | |__| |  __/ ||  __/\__ \ |_| | (_| (_| | |_ 
    |_____/ \___|\__\___||___/\__|_|\___\__,_|\__|

               DETECTIVE INVESTIGATION
    ");

            Console.ResetColor();
        }

        public void ShowCaseInfo()
        {
            SetColor(ConsoleColor.Cyan);

            Console.WriteLine("========================================");
            Console.WriteLine("   DETECTIVE INVESTIGATION SYSTEM");
            Console.WriteLine("========================================");

            ResetColor();

            Console.WriteLine("Case: " + currentCase.CaseName);
            Console.WriteLine("Victim: " + currentCase.Victim.Name);
            Console.WriteLine("Location: Afaq Technology Company");
            Console.WriteLine("Time: 9:15 PM");
        }

        public void StartGame()
        {
            bool exit = false;
            Console.Clear();
            ShowLogo();

            Console.WriteLine();
            Console.WriteLine("Case: " + currentCase.CaseName);
            Console.WriteLine("Victim: " + currentCase.Victim.Name);
            Console.WriteLine();
            Console.WriteLine("Press any key to start...");
            Console.ReadKey();
            while (!exit)
            {
                Console.Clear();

                ShowLogo();

                Console.WriteLine("========================================");
                Console.WriteLine("   DETECTIVE INVESTIGATION SYSTEM");
                Console.WriteLine("========================================");
                Console.WriteLine();
                Console.WriteLine("Case: " + currentCase.CaseName);
                Console.WriteLine();
                SetColor(ConsoleColor.Yellow);

                Console.WriteLine("1. View Case Information");
                Console.WriteLine("2. View Victim");
                Console.WriteLine("3. View Suspects");
                Console.WriteLine("4. View Evidence");
                Console.WriteLine("5. Detective Notebook");
                Console.WriteLine("6. Accuse Suspect");

                ResetColor();

                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ShowCaseInformation();
                        break;

                    case "2":
                        ShowVictim();
                        break;

                    case "3":
                        ShowSuspects();
                        break;

                    case "4":
                        ShowEvidence();
                        break;

                    case "5":
                        Console.WriteLine("Notebook coming soon...");
                        Console.ReadKey();
                        break;

                    case "6":
                        AccuseSuspect();
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private void ShowCaseInformation()
        {
            Console.Clear();

            Console.WriteLine("========== CASE INFORMATION ==========");
            Console.WriteLine($"Case Name : {currentCase.CaseName}");
            Console.WriteLine("Location  : Afaq Technology Company");
            Console.WriteLine("Time      : 9:15 PM");

            Console.WriteLine();
            Console.WriteLine("Press any key to return...");
            Console.ReadKey();
        }

        private void ShowVictim()
        {
            Console.Clear();

            currentCase.Victim.DisplayInfo();

            Console.WriteLine();
            Console.WriteLine("Press any key to return...");
            Console.ReadKey();
        }

        private void ShowSuspects()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("========== SUSPECTS ==========");
                Console.WriteLine();

                for (int i = 0; i < currentCase.Suspects.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {currentCase.Suspects[i].Name}");
                }

                Console.WriteLine("0. Back");
                Console.WriteLine();

                Console.Write("Choose a suspect: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    continue;
                }

                if (choice == 0)
                    return;

                if (choice >= 1 && choice <= currentCase.Suspects.Count)
                {
                    Console.Clear();
                    SetColor(ConsoleColor.DarkYellow);
                    ResetColor();

                    Console.WriteLine();
                    Console.WriteLine("Press any key to return...");
                    Console.ReadKey();
                }
            }
        }

        private void ShowEvidence()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("========== EVIDENCE ==========");
                Console.WriteLine();

                for (int i = 0; i < currentCase.EvidenceList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {currentCase.EvidenceList[i].Name}");
                }

                Console.WriteLine("0. Back");
                Console.WriteLine();

                Console.Write("Choose evidence: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    continue;
                }

                if (choice == 0)
                    return;

                if (choice >= 1 && choice <= currentCase.EvidenceList.Count)
                {
                    Console.Clear();
                    currentCase.EvidenceList[choice - 1].DisplayEvidence();

                    Console.WriteLine();
                    Console.WriteLine("Press any key to return...");
                    Console.ReadKey();
                }
            }
        }
        private void AccuseSuspect()
        {
            Console.Clear();

            Console.WriteLine("========== ACCUSE A SUSPECT ==========\n");

            for (int i = 0; i < currentCase.Suspects.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {currentCase.Suspects[i].Name}");
            }

            Console.Write("\nChoose a suspect: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input.");
                Console.ReadKey();
                return;
            }

            if (choice < 1 || choice > currentCase.Suspects.Count)
            {
                Console.WriteLine("Invalid choice.");
                Console.ReadKey();
                return;
            }

            var suspect = currentCase.Suspects[choice - 1];

            Console.WriteLine($"\nYou selected: {suspect.Name}");
            Console.Write("Are you sure? (Y/N): ");

            string answer = Console.ReadLine().ToUpper();

            if (answer != "Y")
                return;

            Console.Clear();

            if (suspect.IsGuilty)
            {
                SetColor(ConsoleColor.Green);
                Console.WriteLine("================================");
                Console.WriteLine("         CASE SOLVED");
                Console.WriteLine("================================");
                Console.WriteLine();
                Console.WriteLine($"The killer was {suspect.Name}");
                Console.WriteLine();
                Console.WriteLine("Score : 100");
                Console.WriteLine("Rank  : Master Detective");
            }
            else
            {
                SetColor(ConsoleColor.Red);
                Console.WriteLine("================================");
                Console.WriteLine("         CASE FAILED");
                Console.WriteLine("================================");
                Console.WriteLine();
                Console.WriteLine($"{suspect.Name} is innocent.");
                Console.WriteLine("The real killer escaped.");
                Console.WriteLine();
                Console.WriteLine("Score : 40");
                Console.WriteLine("Rank  : Rookie Detective");
            }

            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        private void SetColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        private void ResetColor()
        {
            Console.ResetColor();
        }
    }
    
}