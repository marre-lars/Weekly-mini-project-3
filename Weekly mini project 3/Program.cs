using System;
using System.Collections.Generic;
using System.Text;


List<Computer> computers = new List<Computer>();
computers.Add(new Computer("HP", "X30", 2022, 2500));
computers.Add(new Computer("Lenovo", "L3-70", 2024, 8500));
computers.Add(new Computer("Dell", "T3s7", 1998, 17500));


List<MobilePhones> phones = new List<MobilePhones>();
phones.Add(new MobilePhones("Samsung", "Galaxys", 2019, 3500));
phones.Add(new MobilePhones("Nokia", "3310", 2004, 6500));
phones.Add(new MobilePhones("Sony", "H54", 1989, 35000));

Console.WriteLine("Phones");
Console.WriteLine();
List<MobilePhones> sortedPhones = phones.OrderBy(phone => phone.Brand).ToList();
Console.WriteLine("Brand".PadRight(10) + "Model".PadRight(10) + "Date".PadRight(10) + "Price".PadRight(10));

foreach (MobilePhones phone in phones)
{
    Console.WriteLine(phone.Brand.PadRight(10) + phone.Model.PadRight(10) + phone.PurchaseDate.ToString().PadRight(10) + phone.Price);
}

Console.WriteLine("----------------------------------------------");
Console.WriteLine("Computers");
Console.WriteLine();
List<Computer> sortedComputers = computers.OrderBy(computer => computer.Brand).ToList();
Console.WriteLine("Brand".PadRight(10) + "Model".PadRight(10) + "Date".PadRight(10) + "Price".PadRight(10));

foreach (Computer computer in computers)
{
    Console.WriteLine(computer.Brand.PadRight(10) + computer.Model.PadRight(10) + computer.PurchaseDate.ToString().PadRight(10) + computer.Price);
}

Console.ReadLine();
class Computer
{

    public Computer(string brand, string model, int purchaseDate, int price)
    {
        Brand = brand;
        Model = model;
        PurchaseDate = purchaseDate;
        Price = price;
    }

    public string Brand { get; set; }
    public string Model { get; set; }

    public int PurchaseDate { get; set; }
    public int Price { get; set; }
}



class MobilePhones
{

    public MobilePhones(string brand, string model, int purchaseDate, int price)
    {
        Brand = brand;
        Model = model;
        PurchaseDate = purchaseDate;
        Price = price;
    }

    public string Brand { get; set; }
    public string Model { get; set; }

    public int PurchaseDate { get; set; }
    public int Price { get; set; }
}




