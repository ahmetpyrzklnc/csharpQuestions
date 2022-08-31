using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziToplamaOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Random random = new Random();

            int[] alice = new int[3]; // alice's array

            for (int i = 0; i < alice.Length; i++)
            {
                alice[i] = random.Next(1, 10); 
            }

            Console.WriteLine("Alice Array"); 

            foreach (var item in alice) // // print Alice's array 
            {
                
                Console.WriteLine(item);
            }

            Console.WriteLine("-----");

            
            int[] bob = new int[3]; // bob's array

            for (int i = 0; i < bob.Length; i++)
            {
                bob[i] = random.Next(1, 10);
            }

            Console.WriteLine("Bob Array");

            foreach (var item in bob) // print Bob's Array
            {
                
                Console.WriteLine(item);
            }

            Console.WriteLine("-----");

            Console.WriteLine("First Round Winner: ");

            int alicePoint = 0; // determine the total score
            int bobPoint = 0;

            if (alice[0] < bob[0])
            {
                Console.WriteLine("Bob!");
                bobPoint++;
            }
            else if (alice[0] > bob[0]) 
            {
                Console.WriteLine("Alice!");
                alicePoint++;
            }
            else
            {
                Console.WriteLine("To tie!");
            }

            Console.WriteLine("-----");

            Console.WriteLine("Second Round Winner: ");

            if (alice[1] < bob[1])
            {
                Console.WriteLine("Bob!");
                bobPoint++;
            }
            else if (alice[1] > bob[1])
            {
                Console.WriteLine("Alice!");
                alicePoint++;
            }
            else
            {
                Console.WriteLine("To tie!");
            }

            Console.WriteLine("-----");

            Console.WriteLine("Third Round Winner: ");

            if (alice[2] < bob[2])
            {
                Console.WriteLine("Bob!");
                bobPoint++;
            }
            else if (alice[2] > bob[2])
            {
                Console.WriteLine("Alice!");
                alicePoint++;
            }
            else
            {
                Console.WriteLine("To tie");
            }

            Console.WriteLine("-----");

            Console.WriteLine("Game Winner: "); // result

            if (alicePoint < bobPoint)
            {
                Console.WriteLine("Bob!");
            }
            else if(alicePoint > bobPoint)
            {
                Console.WriteLine("Alice!");
            }
            else
            {
                Console.WriteLine("To tie!");
            }


            Console.ReadLine();
        }
    }
}
