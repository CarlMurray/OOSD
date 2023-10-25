/*
 * Solution to Q1.
 * Program prompts user for name and 3 inputs for birth date.
 * Calculates age in number of days and prints to console.
 */


// GET NAME
string name = GetName();

// GET DAY
int day = GetDate("Day");

// GET MONTH
int month = GetDate("Month");

// GET YEAR
int year = GetDate("Year");

// GET AGE
int age = GetAgeInDays(year, month, day);

// PRINT TO CONSOLE
Console.WriteLine($"Hello {name}! Your age in days is {age}.");

/*
 * Description:
 * - Prompts user for their name and returns the input.
 * Returns:
 * - string name; User's name.
 */
string GetName()
{
    // PROMPT USER FOR NAME AND VALIDATE
    Console.WriteLine("Enter your name: ");
    string name;
    do
    {
        name = Console.ReadLine();
        if (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Name must be at least 1 character!");
        }
    } while (string.IsNullOrEmpty(name));

    return name;
}

/*
 * Description:
 * - Calculates the user's age in days.
 * Parameters:
 * - int _year: int value for the user's year of birth
 * - int _month: int value for the user's month of birth
 * - int _day: int value for the user's day of birth
 * Returns:
 * - int ageInDays: The user's age calculated in days.
 */
int GetAgeInDays(int _year, int _month, int _day)
{
// CREATE DATETIME OBJECT
    DateTime birthday = new DateTime(_year, _month, _day);

// CALCULATE AGE IN DAYS
    int ageInDays = (int)DateTime.Today.Subtract(birthday).TotalDays;

    return ageInDays;
}

/*
 * Description:
 * - Prompts user to enter year/month/day of birth
 * Parameters:
 * - string date: Defines type of date input (year/month/day)
 * Returns:
 * - int userInput: The user's input.
 */
int GetDate(string date)
{
    // DEFINE MIN/MAX INPUT VALUES FOR EACH DATE ELEMENT
    int minValue = 1;
    int maxValue;

    if (date == "Day")
    {
        maxValue = 31;
    }
    else if (date == "Month")
    {
        maxValue = 12;
    }
    else
    {
        minValue = 1900;
        maxValue = 2023;
    }

    // PROMPT USER FOR INPUT AND VALIDATE
    int userInput;
    do
    {
        Console.Write($"Enter your birth {date} (between {minValue} - {maxValue}): ");

        userInput = Convert.ToInt32(Console.ReadLine());

        if (userInput < minValue || userInput > maxValue)
        {
            Console.WriteLine($"{date} input must be between {minValue} - {maxValue} inclusive!");
        }
    } while (userInput < minValue || userInput > maxValue);


    return userInput;
}