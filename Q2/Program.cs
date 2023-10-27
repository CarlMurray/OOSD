/*
 * Q2 solution.
 * Program prompts user for seat cost + number of extras.
 * Calculates and prints total cost.
 */

// GET BASIC SEAT COST
Console.WriteLine("Enter the basic seat cost: ");
var seatCost = Convert.ToDouble(Console.ReadLine());

// GET EXTRAS
double smallBags = GetExtras("10kg checked bags", 20);
double largeBags = GetExtras("20kg checked bags", 30);
double meals = GetExtras("meals", 10);
double reservedSeats = GetExtras("reserved seats", 5);

// CALCULATE TOTAL COST
double totalCost = seatCost + smallBags + largeBags + meals + reservedSeats;
Console.WriteLine($"Total cost: {totalCost:C}");

/*
 * Description:
 * - Prompts user to enter quantity of an extra
 * and calculates the price
 * Parameters:
 * - string extra: The type of extra (bags, meals etc.)
 * - double price: The price of the extra.
 * Returns:
 * - double: Total price of extras chosen (quantity * price)
 */
double GetExtras(string extra, double price)
{
    Console.WriteLine($"Enter number of {extra} @ {price:C} each:");
    int quantity = Convert.ToInt32(Console.ReadLine());
    return quantity * price;
}