using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Szpital
{
    public class Medicine
    {
        public string Nazwa { get; set; }
        public string Producent { get; set; }
        public string Kategoria { get; set; }
        public void WyszukiwanieZaNazwaLekarstw(string filePath, string searchTerm)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Medicine>().Where(m =>
                    m.Nazwa.Contains(searchTerm)).ToList();

                Console.WriteLine($"\nWyniki wyszukiwania dla '{searchTerm}':");
                foreach (var lekarstwo in records)
                {
                    Console.WriteLine($"Nazwa: {lekarstwo.Nazwa}, Producent: {lekarstwo.Producent}, Kategoria: {lekarstwo.Kategoria}");
                }
            }
        }
        public void WyszukiwanieZaProducentem(string filePath, string searchTerm)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Medicine>().Where(m =>
                    m.Producent.Contains(searchTerm)).ToList();

                Console.WriteLine($"\nWyniki wyszukiwania dla '{searchTerm}':");
                foreach (var lekarstwo in records)
                {
                    Console.WriteLine($"Nazwa: {lekarstwo.Nazwa}, Producent: {lekarstwo.Producent}, Kategoria: {lekarstwo.Kategoria}");
                }
            }
        }
        public void WyszukiwanieZaNazwaKategoria(string filePath, string searchTerm)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Medicine>().Where(m =>
                    m.Kategoria.Contains(searchTerm)).ToList();

                Console.WriteLine($"\nWyniki wyszukiwania dla '{searchTerm}':");
                foreach (var lekarstwo in records)
                {
                    Console.WriteLine($"Nazwa: {lekarstwo.Nazwa}, Producent: {lekarstwo.Producent}, Kategoria: {lekarstwo.Kategoria}");
                }
            }
        }
        public void WyswietlenieWszystkieLekarstwa(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Medicine>().ToList();

                Console.WriteLine("\nOdczytane dane...");
                foreach (var lekarstwo in records)
                {
                    Console.WriteLine($"Nazwa: {lekarstwo.Nazwa}, Producent: {lekarstwo.Producent}, Kategoria: {lekarstwo.Kategoria}");
                }
            }
        }
    }
}
