using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Serialization_of_objects
{
    
    internal class Program
    {
        [Serializable]
        class Fractions
        {
            public int numerator { get; set; }
            public int denominator { get; set; }

            public Fractions() { }
           
            
        }
        [Serializable]
        class Work
        {
            public List<Fractions> fractions;
           
            public void Menu()
            {
                Console.WriteLine("Enter numerator and denominator");
                int numerator = int.Parse(Console.ReadLine());
                int denominator = int.Parse(Console.ReadLine());

                Fractions item = new Fractions() { numerator = numerator, denominator = denominator };
                fractions.Add(item);
            }
        }


        static void Main(string[] args)
        {
            Work work = new Work();
            work.Menu();

            string fileName = "Work.json";
            File.Create(fileName);
            // Serialize
            string jsonString = JsonSerializer.Serialize(work);
            File.WriteAllText(fileName, jsonString);

            // Deserialize
            jsonString = File.ReadAllText(fileName);
            Work list = JsonSerializer.Deserialize<Work>(jsonString);

        }
    }
}
