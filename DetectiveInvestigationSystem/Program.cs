using System;
using DetectiveInvestigationSystem.Factories;
using DetectiveInvestigationSystem.Interfaces;
using DetectiveInvestigationSystem.Models;
using DetectiveInvestigationSystem.Services;

namespace DetectiveInvestigationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Detective Investigation System";

            ICaseFactory factory = new CaseFactory();

            Case currentCase = factory.CreateCase();

            GameService game = new GameService(currentCase);

            game.StartGame();
        }
    }
}