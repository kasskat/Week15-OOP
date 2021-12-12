using System;
using System.Collections.Generic;
using System.IO;

namespace OOPAndFiles
{
    class Program
    {
        class XmasWishes
        {
            string name;
            string wish;


            public XmasWishes(string _name, string _wish)
            {
                name = _name;
                wish = _wish;
            }

            //getters for Movie

            public string Name
            {
                get { return name; }
            }

            public string Wish
            {
                get { return wish; }
            }
        }

        static void Main(string[] args)
        {
            //  DisplayElementsFromArray(GetDataFromFile()); //üks funktsioon teise sees

            List<XmasWishes> childWishes = new List<XmasWishes>(); //pakkume koha, millele määrame väärtusi (meie .txt failist)
            string[] wishesFromFile = GetDataFromFile();

            foreach (string line in wishesFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries); //otsib ; selleks et tükeldada massiivi elemente ja eemaldab tühikuid
                XmasWishes newWishes = new XmasWishes(tempArray[0], tempArray[1]);
                childWishes.Add(newWishes);

                /*/ 
                Console.WriteLine($"title from TempArray: {tempArray[0]}"); 
                Console.WriteLine($"rating from TempArray: {tempArray[1]}");
                Console.WriteLine($"year from TempArray: {tempArray[2]}");
                Console.WriteLine();
                /*/
            }

            foreach (XmasWishes wishFromList in childWishes)
            {
                Console.WriteLine($"{wishFromList.Name} wants {wishFromList.Wish}.");
            }

        }

        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }
        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\Laptop\samples\Week15\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
}