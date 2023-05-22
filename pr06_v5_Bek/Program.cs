using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string inputFile = "products.txt"; // Имя входного файла
        string unavailableFile = "unavailable_products.txt"; // Имя файла для недоступных товаров
        string remainingFile = "remaining_products.txt"; // Имя файла для оставшихся товаров

        List<Product> products = ReadProductsFromFile(inputFile); // Чтение товаров из файла

        List<Product> unavailableProducts = GetUnavailableProducts(products); // Получение недоступных товаров
        List<Product> remainingProducts = GetRemainingProducts(products); // Получение оставшихся товаров

        WriteProductsToFile(unavailableFile, unavailableProducts); // Запись недоступных товаров в файл
        WriteProductsToFile(remainingFile, remainingProducts); // Запись оставшихся товаров в файл

        int unavailableCount = unavailableProducts.Count; // Количество недоступных товаров
        Console.WriteLine("Количество недоступных товаров: " + unavailableCount);
    }

    static List<Product> ReadProductsFromFile(string fileName)
    {
        List<Product> products = new List<Product>();

        try
        {
            string[] lines = File.ReadAllLines(fileName); // Чтение всех строк из файла

            foreach (string line in lines)
            {
                string[] parts = line.Split('$'); // Разделение строки на части по символу '$'

                string code = parts[0]; // Код товара
                string name = parts[1]; // Название товара
                int quantity = int.Parse(parts[2]); // Количество товара
                decimal cost = decimal.Parse(parts[3]); // Стоимость товара

                Product product = new Product(code, name, quantity, cost); // Создание объекта товара
                products.Add(product); // Добавление товара в список
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Файл не найден: " + fileName); // Обработка исключения, если файл не найден
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка при чтении файла: " + ex.Message); // Обработка исключения чтения файла
        }

        return products; // Возврат списка товаров
    }

    static List<Product> GetUnavailableProducts(List<Product> products)
    {
        List<Product> unavailableProducts = new List<Product>();

        foreach (Product product in products)
        {
            if (product.Quantity == 0) // Проверка, является ли товар недоступным
            {
                unavailableProducts.Add(product); // Добавление недоступного товара в список
            }
        }

        return unavailableProducts; // Возврат списка недоступных товаров
    }

    static List<Product> GetRemainingProducts(List<Product> products)
    {
        List<Product> remainingProducts = new List<Product>();

        foreach (Product product in products)
        {
            if (product.Quantity > 0) // Проверка, является ли товар оставшимся
            {
                remainingProducts.Add(product); // Добавление оставшегося товара в список
            }
        }

        remainingProducts.Sort((p1, p2) => p2.Quantity.CompareTo(p1.Quantity)); // Сортировка оставшихся товаров по количеству

        return remainingProducts; // Возврат списка оставшихся товаров
    }

    static void WriteProductsToFile(string fileName, List<Product> products)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName)) // Использование блока using для автоматического закрытия файла после записи
            {
                foreach (Product product in products)
                {
                    string line = $"{product.Code}${product.Name}${product.Quantity}${product.Cost}"; // Форматирование строки товара
                    writer.WriteLine(line); // Запись строки в файл
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка при записи в файл: " + ex.Message); // Обработка исключения записи в файл
        }
    }
}

class Product
{
    public string Code { get; } // Код товара
    public string Name { get; } // Название товара
    public int Quantity { get; } // Количество товара
    public decimal Cost { get; } // Стоимость товара

    public Product(string code, string name, int quantity, decimal cost)
    {
        Code = code;
        Name = name;
        Quantity = quantity;
        Cost = cost;
    }
}
