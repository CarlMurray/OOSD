/*
 * Solution to Q3.
 * Program prompts user to enter awarded grade and
 * calculates new grade with 15% increase.
 */

Console.WriteLine($"New grade: {IncreasedGrade(GetGrade())}");

/*
 * Description:
 * - Calculates the new grade with 15% increase.
 * Parameters:
 * - double _awardedGrade: The original grade awarded.
 * Returns:
 * - Grade rounded to nearest integer (no decimals).
 */
int IncreasedGrade(double _awardedGrade)
{
    return (int)Math.Round((_awardedGrade * (1.15)));
}

/*
 * Description:
 * - Prompts user to enter awarded grade. Accepts decimal value.
 * - Passed as callback fn to IncreasedGrade.
 * Returns:
 * - double grade: The user's awarded grade.
 */
double GetGrade()
{
    double grade;
    do
    {
        Console.Write("Enter a grade between 0 - 100: ");
        grade = Convert.ToDouble(Console.ReadLine());
    } while (grade < 0 || grade > 100);

    return grade;
}