using System;
using System.Collections;
using System.Collections.Generic;

namespace Aufgabe001
{
    class Program
    {
        private static List<test> meineListe = new List<test>();

        static void Main(string[] args)
        {

            

            Console.WriteLine("Benutze add, check, delete und show");
            string userInput = Console.ReadLine();

            if (userInput.StartsWith("add"))
            {
                string[] alleParts = userInput.Split(" ");

                int counter = 0;

                foreach (string item in alleParts)
                {
                    Console.WriteLine("Index{0} = {1}",counter++, item);
                }
                string[] relevanteParts = new string[] { };
                string name = alleParts[1].ToString();
                Console.WriteLine(name);

                alleParts.CopyTo(relevanteParts, 1);

                //foreach (string test in relevanteParts)
                //{
                //    Console.WriteLine(test);
                //}

                //string name = string.Join(" ", relevanteParts);

                //Console.WriteLine(name);



            }
            else if (userInput.StartsWith("check"))
            {

                
                

            }
            else if (userInput.StartsWith("delete"))
            {

            }
            else if (userInput.StartsWith("show"))
            {

            }



            











            /*
            // Eine ArrayList wird initialisiert
            ArrayList myArrayList = new ArrayList();

            string input;

            string[] gesamterInput;

            string[] wichtigerInput = new string[] { };



            Console.WriteLine("Benutze add, check, delete und show");
            input = Console.ReadLine();

            if (input.StartsWith("add"))
            {
                gesamterInput = input.Split(" ");
                gesamterInput.CopyTo(wichtigerInput, 1);

                myArrayList.Add(wichtigerInput);


            }
            else if (input.StartsWith("check"))
            {
                gesamterInput = input.Split(" ");
                gesamterInput.CopyTo(wichtigerInput, 1);

                myArrayList.

            }
            else if (input.StartsWith("delete"))
            {

            }
            else if (input.StartsWith("show"))
            {
                
            }
            */




            Console.ReadKey();
        }
    }
}
