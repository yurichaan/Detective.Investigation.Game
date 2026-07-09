using DetectiveInvestigationSystem.Interfaces;
using DetectiveInvestigationSystem.Models;
using System.Collections.Generic;

namespace DetectiveInvestigationSystem.Factories
{
    public class CaseFactory : ICaseFactory
    {
        public Case CreateCase()
        {
            Victim victim = new Victim(
                "Yara",
                35,
                "CEO",
                "Knife Stab",
                "9:15 PM"
            );

            List<Suspect> suspects = new List<Suspect>()
            {
                new Suspect(
                    "Ahmed",
                    40,
                    "HR Manager",
                    "He was about to lose his job.",
                    "I was in my office.",
                    false),

                new Suspect(
                    "Sarah",
                    32,
                    "Accountant",
                    "Yara discovered missing company money.",
                    "I was preparing financial reports.",
                    true),

                new Suspect(
                    "Khalid",
                    29,
                    "IT Specialist",
                    "His project was rejected.",
                    "I was fixing a server.",
                    false),

                new Suspect(
                    "Mohammed",
                    45,
                    "Security Guard",
                    "Had an argument with Yara.",
                    "I was outside the building.",
                    false)
            };

            List<Evidence> evidence = new List<Evidence>()
            {
                new Evidence(
                    "Bloody Knife",
                    "A knife covered with blood was found on the floor."),

                new Evidence(
                    "Coffee Cup",
                    "A coffee cup with fingerprints was found."),

                new Evidence(
                    "Laptop",
                    "Yara's laptop contained a threatening email."),

                new Evidence(
                    "Security Camera",
                    "The security camera stopped recording at 9:08 PM."),

                new Evidence(
                    "Threat Letter",
                    "Someone threatened Yara one week before her death.")
            };

            return new Case(
                "The Murder of Yara",
                victim,
                suspects,
                evidence);
        }
    }
}