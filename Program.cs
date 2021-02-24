using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Assignment2._2
{
    public class Minister {
        string MinisterName;
        int MinisterYear;

        public string Name
        {
            get { return MinisterName; }
            set { MinisterName = value; }
        }

        public int Year
        {
            get { return MinisterYear; }
            set { MinisterYear = value; }
        }
        public override string ToString()
        {
            return "Name: " + Name + ", " + "Year: " + Year;
        }
        public Minister(string name,int year)
        {
            this.Name = name;
            this.Year = year;
        }
    }
    class Program
    {
        static Dictionary<string, Minister> obj = new Dictionary<string, Minister>();
        static void Main(string[] args)
        {
            DictionaryInit();

            Console.WriteLine("Prime Minister in 2004:-");
            foreach (var primeMini in obj.Values)
            {
                if (primeMini.Year == 2004)
                {
                    Console.WriteLine(primeMini);
                }
            }

            Console.WriteLine("\nAfter Adding current Prime Minister.\n");
            obj["forth"] = new Minister("Narendra Modi",2014);
            foreach (var primeMini in obj.Values)
                Console.WriteLine(primeMini);
            


            Console.WriteLine("\nAfter Sorting the list of Prime Ministers by Year.\n");
            obj = obj.OrderBy(r => r.Value.Year).ToDictionary(r => r.Key, r => r.Value);
            foreach (var primeMini in obj.Values)
                Console.WriteLine(primeMini);
            
        }

        private static void DictionaryInit()
        {
            obj.Add("First", new Minister("Atal Bihari Vajpayee", 1998));
            obj.Add("second", new Minister("Narendra Modi", 2014));
            obj.Add("third", new Minister("Manmohan Singh", 2004));
        }
    }
}
