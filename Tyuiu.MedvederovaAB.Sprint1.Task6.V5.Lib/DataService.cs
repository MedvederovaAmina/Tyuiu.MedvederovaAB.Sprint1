using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MedvederovaAB.Sprint1.Task6.V5.Lib
{
    public class DataService : ISprint1Task6V5
    {
        public string CheckSymmetricalWords(string str)
        {
            string[] splitStr = str.Split(" ");
            string result = "";
            foreach ( string st in splitStr )
            {
                char[] arr =  st.ToCharArray();
                Array.Reverse(arr);
                if (st.Equals(new string(arr))) result += st;

            }
          return result;

            
       
        }   
    }
}
