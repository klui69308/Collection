using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arraylist1 = new ArrayList();
            arraylist1.Add(10);
            arraylist1.Add("Sophia");
            arraylist1.Add('L');
            arraylist1.Add(10.01);

            Console.WriteLine("Display the array list");
            foreach (var obj in arraylist1)
            {
                Console.WriteLine(obj);
            }

            arraylist1.Insert(2, "Claim");
            Console.WriteLine();
            Console.WriteLine("Display the array list with an insert");
            foreach (var obj in arraylist1)
            {
                Console.WriteLine(obj);
            }

            arraylist1.Remove("Claim");
            Console.WriteLine();
            Console.WriteLine("Display the array list after removing an item");
            foreach (var obj in arraylist1)
            {
                Console.WriteLine(obj);
            }

            Hashtable hash1 = new Hashtable();
            hash1.Add("E_id", 101);
            hash1.Add("E_name", "Sophia");
            hash1.Add("Job", "Software Developer");
            hash1.Add("Salary", 65000);

            Console.WriteLine();
            Console.WriteLine("Display the hashtable with keys");
            foreach (var obj in hash1.Keys)
            {
                Console.WriteLine(obj + ": " + hash1[obj]);
            }

            List<int> list1 = new List<int>();
            list1.Add(120);
            list1.Add(20);
            list1.Add(34);

            Console.WriteLine();
            Console.WriteLine("Display the integer list");
            foreach (var obj in list1)
            {
                Console.WriteLine(obj);
            }

            list1.Insert(1, 50);
            Console.WriteLine();
            Console.WriteLine("Display the integer list after inserting an item");
            foreach (var obj in list1)
            {
                Console.WriteLine(obj);
            }

            list1.Remove(50);
            //list1.RemoveAt(1);
            Console.WriteLine();
            Console.WriteLine("Display the integer list after removing an item");
            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine(list1[i]);
            }

            Dictionary<int, string> dict1 = new Dictionary<int, string>();
            dict1.Add(101, "Sophia");
            dict1.Add(102, "John");
            dict1.Add(103, "Daphne");

            Console.WriteLine();
            Console.WriteLine("Display the string dictionary with keys");
            foreach (var obj in dict1.Keys)
            {
                Console.WriteLine(obj + ": " + dict1[obj]);
            }



            Console.ReadLine();
        }
    }
}
