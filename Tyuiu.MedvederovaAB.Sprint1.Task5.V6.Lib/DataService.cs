using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MedvederovaAB.Sprint1.Task5.V6.Lib
{
    public class DataService : ISprint1Task5V6
    {
        public int Calculate(int k)
        {
            if (k % 7 == 0)
            {
                return 7;
            }
            else { return (k % 7); }
        }
    }
}
