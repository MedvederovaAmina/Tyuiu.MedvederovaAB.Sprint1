using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MedvederovaAB.Sprint1.Task7.V12.Lib
{
    public class DataService : ISprint1Task7V12
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Round(Math.Pow((x + 1) / (x - 1), x) + 18 * x * Math.Pow(y, 2), 3);
            return res;
        }
    }
}
