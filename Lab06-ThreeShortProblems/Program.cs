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

if (choice == 1 || choice == 4)
{
    // Exercise 1 placeholder
}

if (choice == 2 || choice == 4)
{
    // Exercise 2 placeholder
}

if (choice == 3 || choice == 4)
{
    // Exercise 3 placeholder
}
