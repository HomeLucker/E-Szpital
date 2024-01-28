using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Szpital
{
    internal class AddRecipe : Recipe
    {
        public void DodacRecipe(string filePath)
        {
            Console.WriteLine("Wpisz Nazwę: ");
            string nazwa = Console.ReadLine();
            Console.WriteLine("Wpisz Przeciwwskazania: ");
            string dawka = Console.ReadLine();
            Recipe recipe = new Recipe { Nazwa = nazwa, Dawka = dawka };


            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = !File.Exists(filePath),
            };

            using (var writer = new StreamWriter(filePath, append: true))
            using (var csv = new CsvWriter(writer, config))
            {
                csv.WriteRecord(recipe);
            }

            Console.WriteLine("Dane dodane do pliku CSV.");
        }
    }
}
