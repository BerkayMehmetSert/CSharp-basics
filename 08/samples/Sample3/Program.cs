using Sample3;

var product1 = new Product { Id = 1, Name = "Product 1" };
var product2 = new Product { Id = 2, Name = "Product 2" };
var product3 = new Product { Id = 3, Name = "Product 3" };

List<Product> products = new()
{
    product1,
    product2,
    product3
};

foreach (var product in products)
{
    Console.WriteLine(product.Name);
}