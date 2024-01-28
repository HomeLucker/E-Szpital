using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Szpital
{
    public class Doctor
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Specjalnosc { get; set; }

        public void WyswietlenieWszystkichLekarzow(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Doctor>().ToList();

                Console.WriteLine("\nOdczytane dane...");
                foreach (var lekarz in records)
                {
                    Console.WriteLine($"Imie: {lekarz.Imie}, Nazwisko: {lekarz.Nazwisko}, Specjalnosc: {lekarz.Specjalnosc}");
                }
            }
        }
        public void WyszukiwanieZaImiem(string filePath, string imie)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Doctor>().Where(d =>
                    d.Imie.Contains(imie)).ToList();

                Console.WriteLine($"\nWyniki wyszukiwania dla '{imie}':");
                foreach (var lekarz in records)
                {
                    Console.WriteLine($"Imie: {lekarz.Imie}, Nazwisko: {lekarz.Nazwisko}, Specjalnosc: {lekarz.Specjalnosc}");
                }
            }
        }
        public void WyszukiwanieZaNazwiskiem(string filePath, string nazwisko)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Doctor>().Where(d =>
                    d.Nazwisko.Contains(nazwisko)).ToList();

                Console.WriteLine($"\nWyniki wyszukiwania dla '{nazwisko}':");
                foreach (var lekarz in records)
                {
                    Console.WriteLine($"Imie: {lekarz.Imie}, Nazwisko: {lekarz.Nazwisko}, Specjalnosc: {lekarz.Specjalnosc}");
                }
            }
        }
        public void WyszukiwanieZaSpecjalnoscia(string filePath, string specjalnosc)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Doctor>().Where(d =>
                    d.Specjalnosc.Contains(specjalnosc)).ToList();

                Console.WriteLine($"\nWyniki wyszukiwania dla '{specjalnosc}':");
                foreach (var lekarz in records)
                {
                    Console.WriteLine($"Imie: {lekarz.Imie}, Nazwisko: {lekarz.Nazwisko}, Specjalnosc: {lekarz.Specjalnosc}");
                }
            }
        }

    }
}
