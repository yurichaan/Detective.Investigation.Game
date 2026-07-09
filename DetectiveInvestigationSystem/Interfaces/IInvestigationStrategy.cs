using DetectiveInvestigationSystem.Models;

namespace DetectiveInvestigationSystem.Interfaces
{
    public interface IInvestigationStrategy
    {
        void Execute(Case currentCase);
    }
}