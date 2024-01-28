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
    internal class AddMedicine : Medicine
    {
        public void DodacLekarstwo(string filePath)
        {
            Console.WriteLine("Wpisz Nazwę: ");
            string nazwa = Console.ReadLine();
            Console.WriteLine("Wpisz Producenta: ");
            string producent = Console.ReadLine();
            Console.WriteLine("Wpisz Kategorię: ");
            string kategoria = Console.ReadLine();
            Medicine medicine = new Medicine { Nazwa = nazwa, Producent = producent, Kategoria = kategoria };


            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = !File.Exists(filePath),
            };

            using (var writer = new StreamWriter(filePath, append: true))
            using (var csv = new CsvWriter(writer, config))
            {
                csv.WriteRecord(medicine);
            }

            Console.WriteLine("Dane dodane do pliku CSV.");
        }
    }
}
