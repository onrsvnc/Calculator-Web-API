using Calc.Models;

namespace Calc.Services
{
    public interface IHistoryService
    {
        void AddToHistory(Calculation calculation);
        void ClearHistory();
        List<string> GetHistory();
    }
}
