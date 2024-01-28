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
    internal class AddDoctor : Doctor
    {
        public void DodacLekarza(string filePath)
        {
            Console.WriteLine("Wpisz Imie: ");
            string imie = Console.ReadLine();
            Console.WriteLine("Wpisz Nazwisko: ");
            string nazwisko = Console.ReadLine();
            Console.WriteLine("Wpisz Specjalnosc: ");
            string specjalnosc = Console.ReadLine();
            Doctor doctor = new Doctor { Imie = imie, Nazwisko = nazwisko, Specjalnosc = specjalnosc };


            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = !File.Exists(filePath),
            };

            using (var writer = new StreamWriter(filePath, append: true))
            using (var csv = new CsvWriter(writer, config))
            {
                csv.WriteRecord(doctor);
            }

            Console.WriteLine("Dane dodane do pliku CSV.");
        }
    }
}
