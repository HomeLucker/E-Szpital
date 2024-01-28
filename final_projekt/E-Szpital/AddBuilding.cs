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
    internal class AddBuilding : Building
    {
        public void DodacBudynek(string filePath)
        {
            Console.WriteLine("Wpisz Nazwę: ");
            string nazwa = Console.ReadLine();
            Console.WriteLine("Wpisz Adres: ");
            string adres = Console.ReadLine();
            Console.WriteLine("Wpisz Dzielnicę: ");
            string dzielnica = Console.ReadLine();
            Building budynek = new Building { Nazwa = nazwa, Adres = adres, Dzielnica = dzielnica };


            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = !File.Exists(filePath),
            };

            using (var writer = new StreamWriter(filePath, append: true))
            using (var csv = new CsvWriter(writer, config))
            {
                csv.WriteRecord(budynek);
            }

            Console.WriteLine("Dane dodane do pliku CSV.");
        }
    }
}