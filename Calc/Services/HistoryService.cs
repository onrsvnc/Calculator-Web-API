using Calc.Models;

namespace Calc.Services
{
    public class HistoryService : IHistoryService
    {
        static List<Calculation> calculationHistory = CalculationHistory.calculationHistory;

        public void AddToHistory(Calculation calculation)
        {
            calculationHistory.Add(calculation);
        }

        public void ClearHistory()
        {
            calculationHistory.Clear();
        }

        public List<string> GetHistory()
        {
            List<string> history = new List<string>();
            foreach (var calculation in calculationHistory)
            {
                string a = calculation.a.ToString();
                string b = calculation.b.ToString();
                string result = calculation.result.ToString();
                string? operation = calculation.operation.ToString();
                history.Add(a + " " + operation + " " + b + " " + "=" + " " + result);
            }

            return history;
        }
    }
}
