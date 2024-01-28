using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Szpital
{
    public class Alergie
    {
        public string Nazwa { get;set; }
        public string TypAlergii { get; set; }
        public string OpisAlergii { get; set; }
        public void WyszukiwanieZaNazwaAllergia(string filePath, string searchTerm)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Alergie>().Where(a =>
                    a.Nazwa.Contains(searchTerm)).ToList();

                Console.WriteLine($"\nWyniki wyszukiwania dla '{searchTerm}':");
                foreach (var lekarstwo in records)
                {
                    Console.WriteLine($"Nazwa: {lekarstwo.Nazwa}, Typ alergii: {lekarstwo.TypAlergii}, Opis alergii: {lekarstwo.OpisAlergii}");
                }
            }
        }

        public void WyswietlenieWszystkieAllergie(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Alergie>().ToList();

                Console.WriteLine("\nOdczytane dane...");
                foreach (var allergia in records)
                {
                    Console.WriteLine($"Nazwa: {allergia.Nazwa}, Kategoria: {allergia.TypAlergii}, Słowny opis: {allergia.OpisAlergii}");
                }
            }
        }
    }
}
