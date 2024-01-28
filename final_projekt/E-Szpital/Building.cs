using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Szpital
{
    public class Building
    {
        public string Nazwa { get; set; }
        public string Adres { get; set; }
        public string Dzielnica { get; set; }

        public void WyswietlenieWszystkieBudynki(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Building>().ToList();

                Console.WriteLine("\nOdczytane dane...:");
                foreach (var pharmacy in records)
                {
                    Console.WriteLine($"Nazwa: {pharmacy.Nazwa}, Adres: {pharmacy.Adres}, Dzielnica: {pharmacy.Dzielnica}");
                }
            }
        }


        public void WyszukiwanieZaNazwa(string filePath, string searchTerm)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Building>().Where(b =>
                    b.Nazwa.Contains(searchTerm)).ToList();

                Console.WriteLine($"\nWyniki wyszukiwania dla '{searchTerm}':");
                foreach (var pharmacy in records)
                {
                    Console.WriteLine($"Nazwa: {pharmacy.Nazwa}, Adres: {pharmacy.Adres}, Dzielnica: {pharmacy.Dzielnica}");
                }
            }
        }
        public void WyszukiwanieZaDzielnica(string filePath, string searchTerm)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Building>().Where(b =>
                    b.Dzielnica.Contains(searchTerm)).ToList();

                Console.WriteLine($"\nWyniki wyszukiwania dla '{searchTerm}':");
                foreach (var pharmacy in records)
                {
                    Console.WriteLine($"Nazwa: {pharmacy.Nazwa}, Adres: {pharmacy.Adres}, Dzielnica: {pharmacy.Dzielnica}");
                }
            }
        }

    }


    
    


}
