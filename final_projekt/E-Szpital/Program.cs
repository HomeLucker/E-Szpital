using System;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;

namespace E_Szpital
{
    class Program
    {
        static void Main()
        {
            string signin = "logowanie.csv";

            Console.Write("Wprowadź login: ");
            string login = Console.ReadLine();

            Console.Write("Wprowadź hasło: ");
            string haslo = Console.ReadLine();

            SignIn SignIn = new SignIn();
            if (SignIn.Logowanie(signin, login, haslo))
            {
                Console.WriteLine("\nJesteś zalogowany!");
                Program();
            }
            else
            {
                Console.WriteLine("\nWystąpił błąd, sprobój ponownie :(");
                Main();
            }

            void Program()
            {
                string pharmacy = "apteki.csv";
                string hospital = "szpitale.csv";
                string clinic = "przychodnie.csv";
                string medicine = "lekarstwa.csv";
                string doctor = "lekarzy.csv";
                string alergie = "alergie.csv";
                string recipe = "recepty.csv";

                Doctor Doctor = new Doctor();
                Medicine Medicine = new Medicine();
                Building Building = new Building();
                Alergie Alergia = new Alergie();
                Recipe Recipe = new Recipe();
                AddBuilding AddBuilding = new AddBuilding();
                AddMedicine AddMedicine = new AddMedicine();
                AddDoctor AddDoctor = new AddDoctor();
                AddAlergie AddAlergie = new AddAlergie();
                AddRecipe AddRecipe = new AddRecipe();
                

                while (true)
                {
                    Console.WriteLine("\n1. Pokaż apteki");
                    Console.WriteLine("2. Pokaż szpitale");
                    Console.WriteLine("3. Pokaż przychodnie");
                    Console.WriteLine("4. Pokaż lekarstwa");
                    Console.WriteLine("5. Pokaż lekarzy");
                    Console.WriteLine("6. Pokaż alergie");
                    Console.WriteLine("7. Pokaż recepty");
                    Console.WriteLine("8. Dodaj");
                    Console.WriteLine("9. Wyjście");

                    Console.WriteLine("Wybierz opcję (1-8): ");
                    string wybor = Console.ReadLine();
                    switch (wybor)
                    {
                        case "1":
                            while (true)
                            {
                                Console.WriteLine("\n--1. Znam nazwe");
                                Console.WriteLine("--2. Znam dzielnice");
                                Console.WriteLine("--3. Pokaż wszystkie apteki");
                                Console.WriteLine("--4. Wróć");

                                Console.WriteLine("Wybierz opcję (1-4): ");
                                string wybor_apteki = Console.ReadLine();
                                switch (wybor_apteki)
                                {
                                    case "1":
                                        Console.WriteLine("\nWpisz nazwę: ");
                                        string nazwa = Console.ReadLine();
                                        Building.WyszukiwanieZaNazwa(pharmacy, nazwa);
                                        break;
                                    case "2":
                                        Console.WriteLine("\nWpisz dzielnicę: ");
                                        string dzielnica = Console.ReadLine();
                                        Building.WyszukiwanieZaDzielnica(pharmacy, dzielnica);
                                        break;
                                    case "3":
                                        Building.WyswietlenieWszystkieBudynki(pharmacy);
                                        break;
                                    case "4":
                                        Console.Clear();
                                        Program();
                                        break;
                                    default:
                                        Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                                        break;
                                }
                            }
                        case "2":
                            while (true)
                            {
                                Console.WriteLine("\n--1. Znam nazwe");
                                Console.WriteLine("--2. Znam dzielnice");
                                Console.WriteLine("--3. Pokaż wszystkie szpitale");
                                Console.WriteLine("--4. Wróć");

                                Console.WriteLine("Wybierz opcję (1-4): ");
                                string wybor_szpitala = Console.ReadLine();
                                switch (wybor_szpitala)
                                {
                                    case "1":
                                        Console.WriteLine("\nWpisz nazwę: ");
                                        string nazwa = Console.ReadLine();
                                        Building.WyszukiwanieZaNazwa(hospital, nazwa);
                                        break;
                                    case "2":
                                        Console.WriteLine("\nWpisz dzielnicę: ");
                                        string dzielnica = Console.ReadLine();
                                        Building.WyszukiwanieZaDzielnica(hospital, dzielnica);
                                        break;
                                    case "3":
                                        Building.WyswietlenieWszystkieBudynki(hospital);
                                        break;
                                    case "4":
                                        Console.Clear();
                                        Program();
                                        break;
                                    default:
                                        Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                                        break;
                                }
                            }
                        case "3":
                            while (true)
                            {
                                Console.WriteLine("\n--1. Znam nazwe");
                                Console.WriteLine("--2. Znam dzielnice");
                                Console.WriteLine("--3. Pokaż wszystkie przychodnie");
                                Console.WriteLine("--4. Wróć");

                                Console.WriteLine("Wybierz opcję (1-4): ");
                                string wybor_szpitala = Console.ReadLine();
                                switch (wybor_szpitala)
                                {
                                    case "1":
                                        Console.WriteLine("\nWpisz nazwę: ");
                                        string nazwa = Console.ReadLine();
                                        Building.WyszukiwanieZaNazwa(clinic, nazwa);
                                        break;
                                    case "2":
                                        Console.WriteLine("\nWpisz dzielnicę: ");
                                        string dzielnica = Console.ReadLine();
                                        Building.WyszukiwanieZaDzielnica(clinic, dzielnica);
                                        break;
                                    case "3":
                                        Building.WyswietlenieWszystkieBudynki(clinic);
                                        break;
                                    case "4":
                                        Console.Clear();
                                        Program();
                                        break;
                                    default:
                                        Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                                        break;
                                }
                            }
                        case "4":
                            while (true)
                            {
                                Console.WriteLine("\n--1. Znam Nazwę");
                                Console.WriteLine("--2. Znam Producenta");
                                Console.WriteLine("--3. Znam Kategorie");
                                Console.WriteLine("--4. Pokaż wszystkie lekarstwa");
                                Console.WriteLine("--5. Wróć");

                                Console.WriteLine("Wybierz opcję (1-5): ");
                                string wybor_szpitala = Console.ReadLine();
                                switch (wybor_szpitala)
                                {
                                    case "1":
                                        Console.WriteLine("\nWpisz nazwę: ");
                                        string nazwa = Console.ReadLine();
                                        Medicine.WyszukiwanieZaNazwaLekarstw(medicine, nazwa);
                                        break;
                                    case "2":
                                        Console.WriteLine("\nWpisz Producenta: ");
                                        string producent = Console.ReadLine();
                                        Medicine.WyszukiwanieZaProducentem(medicine, producent);
                                        break;
                                    case "3":
                                        Console.WriteLine("\nWpisz Kategorie: ");
                                        string kategoria = Console.ReadLine();
                                        Medicine.WyszukiwanieZaNazwaKategoria(medicine, kategoria);
                                        break;
                                        break;
                                    case "4":
                                        Medicine.WyswietlenieWszystkieLekarstwa(medicine);
                                        break;
                                    case "5":
                                        Console.Clear();
                                        Program();
                                        break;
                                    default:
                                        Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                                        break;
                                }
                            }
                        case "5":
                            while (true)
                            {
                                Console.WriteLine("\n--1. Znam Imie");
                                Console.WriteLine("--2. Znam Nazwisko");
                                Console.WriteLine("--3. Znam Specjalność");
                                Console.WriteLine("--4. Pokaż wszystkich lekarzów");
                                Console.WriteLine("--5. Wróć");

                                Console.WriteLine("Wybierz opcję (1-5): ");
                                string wybor_lekarza = Console.ReadLine();
                                switch (wybor_lekarza)
                                {
                                    case "1":
                                        Console.WriteLine("\nWpisz Imie: ");
                                        string imie = Console.ReadLine();
                                        Doctor.WyszukiwanieZaImiem(doctor, imie);
                                        break;
                                    case "2":
                                        Console.WriteLine("\nWpisz Nazwisko: ");
                                        string nazwisko = Console.ReadLine();
                                        Doctor.WyszukiwanieZaNazwiskiem(doctor, nazwisko);
                                        break;
                                    case "3":
                                        Console.WriteLine("\nWpisz Specjalnosc: ");
                                        string specjalnosc = Console.ReadLine();
                                        Doctor.WyszukiwanieZaSpecjalnoscia(doctor, specjalnosc);
                                        break;
                                    case "4":
                                        Doctor.WyswietlenieWszystkichLekarzow(doctor);
                                        break;
                                    case "5":
                                        Console.Clear();
                                        Program();
                                        break;
                                    default:
                                        Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                                        break;
                                }
                            }
                        case "6": //alergia
                            while (true)
                            {
                                Console.WriteLine("\n--1. Znam nazwę alergii");
                                Console.WriteLine("--2. Wyświetlić wszystkie kategorie alergii");
                                Console.WriteLine("--3. Wróć");

                                Console.WriteLine("Wybierz opcję (1-4): ");
                                string wybor_alergii = Console.ReadLine();
                                switch (wybor_alergii)
                                {
                                    case "1":
                                        Console.WriteLine("\nWpisz nazwę alergii");
                                        string nazwa = Console.ReadLine();
                                        Alergia.WyszukiwanieZaNazwaAllergia(alergie, nazwa);
                                        break;
                                    case "2":
                                        Alergia.WyswietlenieWszystkieAllergie(alergie);
                                        break;
                                    case "3":
                                        Console.Clear();
                                        Program();
                                        break;
                                    default:
                                        Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                                        break;

                                }
                            }
                        case "7": 
                            while (true)
                            {
                                Console.WriteLine("\n--1. Znam nazwę");
                                Console.WriteLine("--2. Wyświetlić wszystkie recepty");
                                Console.WriteLine("--3. Wróć");

                                Console.WriteLine("Wybierz opcję (1-4): ");
                                string wybor_alergii = Console.ReadLine();
                                switch (wybor_alergii)
                                {
                                    case "1":
                                        Console.WriteLine("\nWpisz nazwę");
                                        string nazwa = Console.ReadLine();
                                        Recipe.WyszukiwanieZaNazwaLeku(recipe, nazwa);
                                        break;
                                    case "2":
                                        Recipe.WyswietlenieWszystkieRecepty(recipe);
                                        break;
                                    case "3":
                                        Console.Clear();
                                        Program();
                                        break;
                                    default:
                                        Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                                        break;

                                }
                            }
                        case "8":
                            while (true)
                            {
                                Console.WriteLine("\n--1. Dodaj aptekę");
                                Console.WriteLine("--2. Dodaj szpital");
                                Console.WriteLine("--3. Dodaj przychodnie");
                                Console.WriteLine("--4. Dodaj lekarstwo");
                                Console.WriteLine("--5. Dodaj lekarza");
                                Console.WriteLine("--6. Dodaj alergie");
                                Console.WriteLine("--7. Dodaj recept");
                                Console.WriteLine("--8. Wróć");
                                Console.Write("Wybierz opcję (1-8): ");
                                string wybor_dodaj = Console.ReadLine();
                                switch (wybor_dodaj)
                                {
                                    case "1":;
                                        AddBuilding.DodacBudynek(pharmacy);
                                        break;
                                    case "2":
                                        AddBuilding.DodacBudynek(hospital);
                                        break;
                                    case "3":
                                        AddBuilding.DodacBudynek(clinic);
                                        break;
                                    case "4":
                                        AddMedicine.DodacLekarstwo(medicine);
                                        break;
                                    case "5":
                                        AddDoctor.DodacLekarza(doctor);
                                        break;
                                    case "6":
                                        AddAlergie.DodacAllergie(alergie);
                                        break;
                                    case "7":
                                        AddRecipe.DodacRecipe(recipe);
                                        break;
                                    case "8":
                                        Console.Clear();
                                        Program();
                                        break;
                                    default:
                                        Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                                        break;
                                }
                            }
                        case "9":
                            Console.WriteLine('9');
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                            break;

                    }
                }
            }
            Program();
        }
    }
}
