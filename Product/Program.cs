using ShopProject.Models;

ProductRepo repo = new ProductRepo();

try
{
    Product hibasTermek = new Product("", "Élelmiszer");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Product tej = new Product("Tej", "Élelmiszer");
tej.SetPrice(300);
tej.SetQuantity(10);
Console.WriteLine(tej);

repo.AddProduct(tej);
Product kenyer = new Product("Kenyér", "Élelmiszer");
kenyer.SetPrice(500);
kenyer.SetQuantity(15);
repo.AddProduct(kenyer);

Console.WriteLine("\nRaktárban lévő termékek:");
repo.ListProducts();


List<Product> products = new List<Product>
{
    new Product("Tej", "Élelmiszer"),
    new Product("Kenyér", "Élelmiszer"),
    new Product("Vaj", "Élelmiszer"),
    new Product("Sajt", "Élelmiszer"),
    new Product("Alma", "Gyümölcs"),
    new Product("Banán", "Gyümölcs"),
    new Product("Kávé", "Ital"),
    new Product("Tea", "Ital"),
    new Product("Cukor", "Fűszer"),
    new Product("Só", "Fűszer")
};

Random rand = new Random();
foreach (var product in products)
{
    product.SetPrice(rand.Next(100, 1000));
    product.SetQuantity(rand.Next(1, 20));
    repo.AddProduct(product);
}

Console.WriteLine("Termékek a raktárban");
repo.ListProducts();

