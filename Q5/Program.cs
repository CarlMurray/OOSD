/*
 * Q5 solution.
 * Creates a Product class to represent products.
 * Prints product details and applies discount to products.
 * Option to apply discount to multiple products using ApplyBulkDiscount,
 * or discount products individually using ApplyProductDiscount method.
 */

// REQUIRED FOR € SYMBOL
Console.OutputEncoding = System.Text.Encoding.UTF8;

// CREATE PRODUCTS
Product milk = new Product("Milk", "90293", 1.50, "Dairy");
Product bananas = new Product("Bananas", "63792", 3.50, "Fruit");

// PRINT PRODUCT DETAILS TO CONSOLE
milk.PrintProductDetails();
bananas.PrintProductDetails();

// CREATE ARRAY OF PRODUCTS FOR BULK DISCOUNT
Product[] products = new Product[] { milk, bananas };

// APPLY DISCOUNT TO ARRAY OF PRODUCTS
ApplyBulkDiscount(10, products);

// PRINT NEW PRODUCT DETAILS
Console.WriteLine();
Console.WriteLine("Prices updated:");
Console.WriteLine("---------------------");
milk.PrintProductDetails();
bananas.PrintProductDetails();


/*
 * Description:
 * - Applies specified discount to multiple products for convenience.
 * Parameters:
 * - double discountPercentage: A positive decimal percentage discount value to
 *   apply to the original price.
 * - Product[] products: An array of products to be discounted.
 */
void ApplyBulkDiscount(double discountPercentage, Product[] products)
{
    foreach (var product in products)
    {
        product.ApplyProductDiscount(discountPercentage);
    }
}

/*
 * Description:
 * - Represents a product.
 * Properties:
 * - string Name: The name of the product.
 * - string ID: The ID (e.g. SKU) of the product.
 * - double Price: The price of the product.
 * - string Category: The product category.
 * Methods:
 * - PrintProductDetails: Prints the Name, ID, Price, Category of the product to console.
 * - ApplyProductDiscount: Applies specified discountPercentage to the product's price.
 *      - Ensures discountPercentage always positive value.
 */
public class Product
{
    public string Name { get; set; }
    public string ID { get; set; }
    public double Price { get; set; }
    public string Category { get; set; }

    public Product(string _Name, string _ID, double _Price, string _Category)
    {
        Name = _Name;
        ID = _ID;
        Price = _Price;
        Category = _Category;
    }

    /*
     * Description:
     * - Prints product details to console.
     */
    public void PrintProductDetails()
    {
        Console.WriteLine("*********************");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Price: {Price:C}");
        Console.WriteLine($"Category: {Category}");
        Console.WriteLine("*********************");
    }

    /*
     * Description:
     * - Applies discount to Product.
     * Parameters:
     * - double discountPercentage: Percentage discount to apply (always positive).
     */
    public void ApplyProductDiscount(double discountPercentage)
    {
        Price = (Price * (1 - double.Abs(discountPercentage) / 100));
    }
}