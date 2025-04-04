using OnlineElectronics.Common;
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        // Використання сервісу для класу Product
        var productService = new CrudService<Product>();

        // Створення продуктів
        var product1 = new Smartphone(Guid.NewGuid(), "Iphone 16", 300, "...", "Android", 4096);
        var product2 = new Laptop(Guid.NewGuid(), "Dell XPS 13", 1500, "...", "Intel i7", 16);

        // Додавання продуктів до сервісу
        productService.Create(product1);
        productService.Create(product2);

        // Читання продукту за ID
        var readProduct = productService.Read(product1.Id);
        Console.WriteLine($"Продукт з ID {readProduct.Id}: {readProduct.Name}, Ціна: {readProduct.Price}");

        // Читання всіх продуктів
        var allProducts = productService.ReadAll();
        foreach (var product in allProducts)
        {
            Console.WriteLine($"Продукт: {product.Name}, Ціна: {product.Price}");
        }

        // Оновлення продукту
        product1.Price = 550;
        productService.Update(product1);

        // Видалення продукту
        productService.Remove(product2);
    }
}