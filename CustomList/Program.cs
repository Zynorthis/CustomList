using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            List<int> newList = new List<int>() { 1, 3, 5 };
            Console.WriteLine(newList[0].ToString() + newList[1].ToString() + newList[2].ToString());
            List<int> newList2 = new List<int>() { 2, 4, 6 };
            var newestList = newList.Zip(newList2, (first, second) => first + " " + second);
            new list = list1.Zip(newList2);
            // Console.WriteLine(newList[0].ToString());
            //int[] intArray = { };
            //Console.WriteLine(newList);
            //Console.WriteLine(intArray[0]);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
