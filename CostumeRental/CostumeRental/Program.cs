using CostumeRental.Models;
using CostumeRental.Services;
using System;
using System.Collections.Generic;
using System.IO;

namespace CostumeRental
{
    class Program
    {
        static RentalService rentalService = new RentalService();

        static void SeedCostumes()
        {
            rentalService.AddCostume(new Costume("J001", "Zombi Kalóz", "M", "Kalóz", 16000));
            rentalService.AddCostume(new Costume("J002", "Gyarmati Kalóz", "L", "Kalóz", 15000));
            rentalService.AddCostume(new Costume("J003", "Klasszikus Boszorkány", "L", "Fantasy", 17000));
            rentalService.AddCostume(new Costume("J004", "Nyugati Boszorkány", "S", "Fantasy", 18000));
            rentalService.AddCostume(new Costume("J005", "Oroszlán", "S", "Állat", 12000));
            rentalService.AddCostume(new Costume("J006", "Homár", "XL", "Állat", 14000));
            rentalService.AddCostume(new Costume("J007", "Cápa", "XL", "Állat", 12000));
            rentalService.AddCostume(new Costume("J008", "Vámpír", "L", "Sexi", 21000));
            rentalService.AddCostume(new Costume("J009", "Francia Szobalány", "S", "Sexi", 23000));
            rentalService.AddCostume(new Costume("J010", "Rendőr", "L", "Sexi", 21000));
        }

        static void SeedCustomers()
        {
            rentalService.AddCustomer(new Customer(1, "Józsa Béla"));
            rentalService.AddCustomer(new Customer(2, "Bálint Dezső"));
            rentalService.AddCustomer(new Customer(3, "Sallai András"));
            rentalService.AddCustomer(new Customer(4, "Rékasi József"));
        }

        static void Main()
        {
            if (File.Exists("Costume.cs")) LoadCostumes();
            else SeedCostumes();

            if (File.Exists("Customer.cs")) LoadCustomers();
            else SeedCustomers();

            string choice = string.Empty;

            while (choice != "9")
            {
                Console.WriteLine("\nFarsangi Jelmezkölcsönző Rendszer\n");
                Console.WriteLine("1. Jelmezek listázása");
                Console.WriteLine("2. Elérhető jelmezek listázása");
                Console.WriteLine("3. Új jelmez hozzáadása");
                Console.WriteLine("4. Jelmez törlése");
                Console.WriteLine("5. Ügyfelek listázása");
                Console.WriteLine("6. Új ügyfél hozzáadása");
                Console.WriteLine("7. Jelmez kölcsönzése");
                Console.WriteLine("8. Jelmez visszahozása");
                Console.WriteLine("9. Kilépés és mentés");
                Console.Write("\nVálasztás: ");
                choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Összes jelmez:");
                        Display(rentalService.ListAllCostumes());
                        break;
                    case "2":
                        //Console.WriteLine("Elérhető jelmezek:"); Display(rentalService.ListAvailableCostumes());
                        break;
                    case "3": /* TODO */ break;
                    case "4": /* TODO */ break;
                    case "5":
                        //Console.WriteLine("Ügyfelek:"); Display(rentalService.ListCustomers());
                        break;
                    case "6": /* TODO */ break;
                    case "7": /* TODO */ break;
                    case "8": /* TODO */ break;
                    case "9": SaveData(); break;
                    default: Console.WriteLine("Érvénytelen választás."); break;
                }
            }
        }

        static void Display(IEnumerable<object> items)
        {
            foreach (var item in items) Console.WriteLine(item);
        }

        static void SaveData()
        {
            // Jelmezek mentése
            //using (var writer = new StreamWriter("Costume.cs"))
            //{
            //    foreach (var costume in rentalService.ListAllCostumes())
            //    {
            //        writer.WriteLine($"{costume.Code},{costume.Name},{costume.Size},{costume.Category},{costume.Price}");
            //    }
            //}

            //// Ügyfelek mentése
            //using (var writer = new StreamWriter("Customer.cs"))
            //{
            //    foreach (var customer in rentalService.ListCustomers())
            //    {
            //        writer.WriteLine($"{customer.Id},{customer.Name}");
            //    }
            //}

            //Console.WriteLine("Adatok mentése sikeresen megtörtént.");
        }


        static void LoadCostumes()
        {
            //if (File.Exists("Costume.cs"))
            //{
            //    var lines = File.ReadAllLines("Costume.cs");
            //    foreach (var line in lines)
            //    {
            //        var parts = line.Split(',');
            //        rentalService.AddCostume(new Costume(parts[0], parts[1], parts[2], parts[3], int.Parse(parts[4])));
            //    }
            //}
        }


        static void LoadCustomers()
        {
            //if (File.Exists("Customer.cs"))
            //{
            //    var lines = File.ReadAllLines("Customers.cs");
            //    foreach (var line in lines)
            //    {
            //        var parts = line.Split(',');
            //        rentalService.AddCustomer(new Customer(int.Parse(parts[0]), parts[1]));
            //    }
            //}
        }
    }
}


    
