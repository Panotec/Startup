using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("John");
            names.Add("Thomas");
            names.Add("Kevin");
            
            try
            {
                if (names[1] == "Thomas")
                {
                    Console.WriteLine("Thomas가 맞습니다.");
                }
                else
                {
                    Console.WriteLine("Thomas가 아닙니다.");
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
