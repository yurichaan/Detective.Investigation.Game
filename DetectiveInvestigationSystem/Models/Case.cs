using System.Collections.Generic;

namespace DetectiveInvestigationSystem.Models
{
    public class Case
    {
        public string CaseName { get; }
        public Victim Victim { get; }

        public List<Suspect> Suspects { get; }

        public List<Evidence> EvidenceList { get; }

        public Case(
            string caseName,
            Victim victim,
            List<Suspect> suspects,
            List<Evidence> evidenceList)
        {
            CaseName = caseName;
            Victim = victim;
            Suspects = suspects;
            EvidenceList = evidenceList;
        }
    }
}