using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BatogovRK.Sprint1.Task6.V15.Lib
{
    public class DataService : ISprint1Task6V15
    {
        public bool CheckLettersCount(string value)
        {
            int letters = 0;
            int punct = 0;
            foreach (char c in value)
            {
                if (char.IsLetter(c))
                {
                    letters++;
                }
                else if (!char.IsDigit(c) && !char.IsWhiteSpace(c))
                {
                    punct++;
                }
            }
            if (letters > punct)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
