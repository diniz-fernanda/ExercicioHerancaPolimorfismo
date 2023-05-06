using ExercicioHerancaPolimorfismo.Entities;
using System.Globalization;

List<Product> list = new List<Product>();

Console.Write("Enter the numbber of products: ");
int n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
    Console.WriteLine($"Product #{i} data: ");
    Console.Write("Common, used or import (c/u/i)? ");
    char ch = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (ch == 'c')
    {
        list.Add(new Product(name, price));
    }
    else if (ch == 'u')
    {
        Console.WriteLine("Manufacture data (DD/MM/YYYY): ");
        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
        list.Add(new UsedProduct(name, price, manufactureDate));
    }
    else 
    {
        Console.Write("Customs fee: ");
        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new ImportedProduct(name, price, customsFee));
    }

    Console.WriteLine();
    Console.WriteLine("PRICE TAGS: ");
    foreach(Product prod in list)
    {
        Console.WriteLine(prod.PriceTag());
    }
;

}
