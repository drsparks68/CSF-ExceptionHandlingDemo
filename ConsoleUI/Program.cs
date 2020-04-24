using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BadCall();
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was an exception thrown in the app");
                Console.WriteLine(ex.Message);
                throw;
            }

            Console.ReadLine();
        }

        private static void BadCall()
        {
            int[] ages = new int[] { 1, 3, 5 };

            for (int i = 0; i <= ages.Length; i++)
            {
                try
                {
                    Console.WriteLine(ages[i]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("There was an error:");
                    Console.WriteLine(ex.Message);
                    throw new Exception("There was an error in the array", ex);
                }
            }
        }
    }
}
