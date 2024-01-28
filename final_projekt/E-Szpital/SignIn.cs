using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Szpital
{
    internal class SignIn : Program
    {

        public string Login { get; set; }
        public string Haslo { get; set; }


        public bool Logowanie(string filePath, string login, string haslo)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<SignIn>().ToList();

                foreach (var uzytkownik in records)
                {
                    if (uzytkownik.Login == login && uzytkownik.Haslo == haslo)
                    {
                        return true; 
                    }
                }
            }
            return false;
        }
    }
}
