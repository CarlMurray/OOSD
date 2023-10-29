/*
 * Q4 solution.
 * Prompts user for name, monthly sales and sales target.
 * Calculates commission and take-home pay after deductions.
 */

// REQUIRED FOR € SYMBOL
Console.OutputEncoding = System.Text.Encoding.UTF8;

// DEFINE DEDUCTIONS
const double ANNUAL_BASE_SALARY = 24000; // €
const double TAX = 0.20; // Percentage
const double PRSI = 0.04; // Percentage
const double PENSION = 0.10; // Percentage
const double HEALTH_INSURANCE = 50; // €/month

// PROMPT FOR USER INPUTS AND CALCULATE TAKE HOME PAY
string name = GetName();
double salesTarget = GetMonthlySalesTarget();
double sales = GetMonthlySales();
double commission = CalculateCommission(sales, salesTarget);
double takeHomePay = MakeDeductions((ANNUAL_BASE_SALARY+commission), TAX, PRSI, PENSION, HEALTH_INSURANCE);

// CONSOLE OUTPUT
Console.WriteLine(
    $"Hi {name}. Your annual take home pay is {takeHomePay:C}. This equates to a monthly salary of {takeHomePay / 12:C}.");

/*
 * Description:
 * - Makes appropriate deductions to base salary.
 * Parameters:
 * - double salary: User's base salary.
 * - double tax: Tax rate percentage.
 * - double prsi: PRSI rate percentage.
 * - double pension: Pension rate percentage.
 * - double healthInsurance: Monthly health insurance deduction.
 * Returns:
 * - double: Base salary minus deductions.
 */
double MakeDeductions(double salary, double tax, double prsi, double pension, double healthInsurance)
{
    return (salary) - (salary * tax) - (salary * prsi) - (salary * pension) - (healthInsurance * 12);
}

/*
 * Description:
 * - Prompts user to enter their name.
 * Returns:
 * - string: User's name.
 */
string GetName()
{
    Console.WriteLine("Enter your name: ");
    return Console.ReadLine();
}

/*
 * Description:
 * - Prompts user to enter their achieved sales for the month.
 * Returns:
 * - double: User's monthly sales.
 */
double GetMonthlySales()
{
    Console.WriteLine("Enter your sales for this month: ");
    return Convert.ToDouble(Console.ReadLine());
}

/*
 * Description:
 * - Prompts user to enter their target sales for the month.
 * Returns:
 * - double: User's monthly sales target.
 */
double GetMonthlySalesTarget()
{
    Console.WriteLine("Enter your sales target for this month: ");
    return Convert.ToDouble(Console.ReadLine());
}

/*
 * Description:
 * - Calculates user's earned commission.
 * Parameters:
 * - double monthlySales: User's achieved sales for the month.
 * - double monthlySalesTarget: User's sales target for the month.
 * Returns:
 * - double: Commission earned.
 */
double CalculateCommission(double monthlySales, double monthlySalesTarget)
{
    double commissionToTarget;
    double commissionToTargetRate = 0.05; // COMMISSION PERCENTAGE TO TARGET
    double commissionOverTarget;
    double commissionOverTargetRate = 0.10; // COMMISSION PERCENTAGE OVER TARGET

    // IF MONTHLY SALES DOES NOT EXCEED TARGET CALCULATE LOWER RATE COMMISSION
    if (monthlySalesTarget - monthlySales >= 0)
    {
        commissionToTarget = monthlySales * commissionToTargetRate;
        return commissionToTarget;
    }

    // ELSE CALCULATE COMMISSION AT BOTH RATES
    commissionToTarget = monthlySalesTarget * commissionToTargetRate;
    commissionOverTarget = (monthlySales - monthlySalesTarget) * commissionOverTargetRate;
    return commissionOverTarget + commissionToTarget;
}