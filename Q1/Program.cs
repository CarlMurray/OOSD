/*
 * Solution to Q1.
 * Program prompts user for name and 3 inputs for birth date.
 * Calculates age in number of days and prints to console.
 */


// GET NAME
string name = GetName();

// GET DAY
int dayOfBirth = GetDate("Day");

// GET MONTH
int monthOfBirth = GetDate("Month");

// GET YEAR
int yearOfBirth = GetDate("Year");

// GET AGE
int ageInDays = GetAgeInDays(yearOfBirth, monthOfBirth, dayOfBirth);

// PRINT TO CONSOLE
Console.WriteLine($"Hello {name}! Your age in days is {ageInDays}.");

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
 * - int yearOfBirth: int value for the user's year of birth
 * - int monthOfBirth: int value for the user's month of birth
 * - int dayOfBirth: int value for the user's day of birth
 * Returns:
 * - int ageInDays: The user's age calculated in days.
 */
int GetAgeInDays(int year, int month, int day)
{
// CREATE DATETIME OBJECT
    DateTime birthday = new DateTime(year, month, day);

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