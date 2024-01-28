using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Szpital
{
    public class Recipe
    {
        public string Nazwa { get; set; }
        public string Dawka { get; set; }
        public void WyszukiwanieZaNazwaLeku(string filePath, string searchTerm)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Recipe>().Where(r =>
                    r.Nazwa.Contains(searchTerm)).ToList();

                Console.WriteLine($"\nWyniki wyszukiwania dla '{searchTerm}':");
                foreach (var lekarstwo in records)
                {
                    Console.WriteLine($"Nazwa: {lekarstwo.Nazwa}, Dawka: {lekarstwo.Dawka}");
                }
            }
        }
        public void WyswietlenieWszystkieRecepty(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Recipe>().ToList();

                Console.WriteLine("\nOdczytane dane...");
                foreach (var recept in records)
                {
                    Console.WriteLine($"Nazwa: {recept.Nazwa}, Dawka: {recept.Dawka}");
                }
            }
        }
    }
}
