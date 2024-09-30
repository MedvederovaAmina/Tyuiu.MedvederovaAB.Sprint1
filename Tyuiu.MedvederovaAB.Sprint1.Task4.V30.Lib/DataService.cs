using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MedvederovaAB.Sprint1.Task4.V30.Lib
{
    public class DataService : ISprint1Task4V30
    {
        public double Calculate(double x, double y)
        {
            var res = Math.Round(x + Math.Pow(y, 3) / Math.Pow(Math.E, 2 - y), 3);
            return res;
        }
    }
}
