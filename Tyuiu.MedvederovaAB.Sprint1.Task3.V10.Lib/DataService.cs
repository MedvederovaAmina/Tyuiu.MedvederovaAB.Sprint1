using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MedvederovaAB.Sprint1.Task3.V10.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public string NumberToMoney(double number)
        {
            number = Math.Round(number, 3, MidpointRounding.ToEven);

            
            int rubles = (int)number; 
            int kopecks = (int)Math.Round((number - rubles) * 100);

            return $"{number:F3} руб. — это {rubles} руб. {kopecks} коп."; 
        }
    }
}
