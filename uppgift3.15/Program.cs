using System;

namespace uppgift3._15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur många timmar tänker du köra bilen? max hyr är 950 " + " 80 kr per timme");
            int timmar = int.Parse(Console.ReadLine());
           
            if (timmar > 11) 
            {
                Console.WriteLine("du kan tuvär hyra bilen för mer än 950 ");

            }
           
                else if (timmar < 950)
            {
                Console.WriteLine("den totala priset är" + timmar * 80 + "kr");
            }



        }

    }
}
