using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shortcuts
{
    public static class SagarUtilities
    {
        public static double GetDoubleFromUser(string v)
        {
            Console.WriteLine(v);
            try
            {
                return double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Entry");
                return GetDoubleFromUser(v);
            }
        }

        public static string GetStringFromUser(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid Entry");
                return GetStringFromUser(message);
            }
            else
            {
                return input;
            }
        }
    }
}
