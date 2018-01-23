using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variabler
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                string fornavn = "mikkel";
                string efternavn = "Cronberg";
                Console.WriteLine(fornavn + " " + efternavn);
                Console.WriteLine(fornavn.ToUpper() + " " + efternavn);
                Console.WriteLine(efternavn.Substring(1,4));
                
                
                Console.ReadLine();
            }
        }
    }
}
    
    

