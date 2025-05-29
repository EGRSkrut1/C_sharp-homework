public class Product_manager
{
    public static void Display_products(string[] product_names, params double[] prices)
    {
        if (product_names == null || prices == null || product_names.Length != prices.Length || product_names.Length == 0) { Console.WriteLine("Invalid product data."); return; }
        double average_price = prices.Average();
        Console.WriteLine($"Average price of products: {average_price:F2}");
        for (int i = 0; i < product_names.Length; i++) Console.WriteLine($"{product_names[i]}: {prices[i]:F2}");
    }
}
public class Program
{
    public static void Main()
    {
        string[] products = { "Apple", "Banana", "Orange" };
        double[] prices = { 25.50, 40.75, 30.00 };
        Product_manager.Display_products(products, prices);
    }
}