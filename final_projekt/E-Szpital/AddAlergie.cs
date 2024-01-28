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
    internal class AddAlergie : Alergie
    {
        public void DodacAllergie(string filePath)
        {
            Console.WriteLine("Wpisz Nazwę: ");
            string nazwa = Console.ReadLine();
            Console.WriteLine("Wpisz Przeciwwskazania: ");
            string pwwskazania = Console.ReadLine();
            Console.WriteLine("Wpisz Kategorię: ");
            string kategoria = Console.ReadLine();
            Alergie allergie = new Alergie { Nazwa = nazwa, TypAlergii = kategoria, OpisAlergii = pwwskazania };

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = !File.Exists(filePath),
            };

            using (var writer = new StreamWriter(filePath, append: true))
            using (var csv = new CsvWriter(writer, config))
            {
                csv.WriteRecord(allergie);
            }

            Console.WriteLine("Dane dodane do pliku CSV.");
        }
    }
}
