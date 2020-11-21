using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_challenges
{
    class Program
    {
        //Methods


        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name to continue");
            Greeter custName = new Greeter();
            string name = Console.ReadLine();
            custName.whatsYourName(name);
            Console.ReadLine();
            Console.WriteLine("\n\n\n\n\n");
        


            custName.FareWell(name);
            Console.ReadLine();
            Console.ReadLine();
            custName.dtResponse();

            Console.WriteLine("Who is your friend?");
            Greeter newCustName = new Greeter();
            name = Console.ReadLine();

            custName.dtResponse();
            
            
            
        }
    }

    public class Greeter
    {
        
        public void whatsYourName(string name)
        {
            Console.WriteLine($"hello, {name}");
        }

        public void FareWell(string name)
        {
            Console.WriteLine($"Have a great evening, {name}");
        }
        public void dtResponse()
        {
            DateTime date = new DateTime();
            date = DateTime.Now;

          if(date.Hour <= 11) 
            {
                Console.WriteLine("Good Morning");
            }
            else if (date.Hour > 12 && date.Hour < 15)
            {
                Console.WriteLine("Good Afternoon");
            }
            else if(date.Hour > 15 && date.Hour < 24)
            {
                Console.WriteLine("Good Evening");
            }
            else
            {
                Console.WriteLine("I seem to miss place my brain today");
            }

            Console.ReadLine();
            
        }
    }
}
