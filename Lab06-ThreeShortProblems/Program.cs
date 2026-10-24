/* 
 * Name: Tanner Birge
 * Course: CSCI 1250, Section 001 
 * Assignment: Lab 06, Three Short Problems 
 * Date: October 24, 2026 
 * Description: A menu that keeps running until the user quits, offering three 
 *              independent exercises or all three at once. Each exercise 
 *              practices decisions and one of the four loops. 
 */

const int MinMenuChoice = 1;
const int MaxMenuChoice = 5;

// The Menu: prints the menu once and validates the user's choice
Console.WriteLine("=== CSCI 1250 Lab 06 ===");
Console.WriteLine("1. The Grade Checker");
Console.WriteLine("2. The Dice Table");
Console.WriteLine("3. The Score Report");
Console.WriteLine("4. All three");
Console.WriteLine("5. Quit");
Console.Write("Choose 1 through 5: ");
int choice = Convert.ToInt32(Console.ReadLine());

// while: the number of repeats is unknown before the loop starts since the user may enter an invalid choice zero or multiple times.
while (choice < MinMenuChoice || choice > MaxMenuChoice)
{
    Console.WriteLine("Choose a number from 1 to 5.");
    Console.Write("Choose 1 through 5: ");
    choice = Convert.ToInt32(Console.ReadLine());
}

// Exercise 1: The Grade Checker
if (choice == 1 || choice == 4)
{
    Console.WriteLine("=== Exercise 1: The Grade Checker ===");
    Console.Write("Score: ");
    int score = Convert.ToInt32(Console.ReadLine());

    // while: the number of repeats is unknown before the loop starts because a user could enter valid input immediately or invalid input multiple times.
    while (score < 0 || score > 100)
    {
        Console.WriteLine("A score must be between 0 and 100.");
        Console.Write("Score: ");
        score = Convert.ToInt32(Console.ReadLine());
    }

    // Top-to-bottom decision chain so higher thresholds take priority
    if (score >= 90)
    {
        Console.WriteLine($"{score} earns an A.");
    }
    else if (score >= 80)
    {
        Console.WriteLine($"{score} earns a B.");
    }
    else if (score >= 70)
    {
        Console.WriteLine($"{score} earns a C.");
    }
    else if (score >= 60)
    {
        Console.WriteLine($"{score} earns a D.");
    }
    else
    {
        Console.WriteLine($"{score} earns an F.");
    }
}

if (choice == 2 || choice == 4)
{
    // Exercise 2 placeholder
}

if (choice == 3 || choice == 4)
{
    // Exercise 3 placeholder
}