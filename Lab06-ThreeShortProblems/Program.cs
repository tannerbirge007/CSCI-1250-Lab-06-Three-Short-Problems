/* 
 * Name: Tanner Birge
 * Course: CSCI 1250, Section 001 
 * Assignment: Lab 06, Three Short Problems 
 * Date: October 24, 2026 
 * Description: A menu that keeps running until the user quits, offering three 
 *              independent exercises or all three at once. Each exercise 
 *              practices decisions and one of the four loops. 
 */

const int RandomSeed = 4000;
const int MinMenuChoice = 1;
const int MaxMenuChoice = 5;
const int PassingScore = 60;
const int NumberOfScores = 5;

// Single seeded Random instance created once above the loops
Random rng = new Random(RandomSeed);

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

// Exercise 2: The Dice Table
if (choice == 2 || choice == 4)
{
    Console.WriteLine("=== Exercise 2: The Dice Table ===");

    int rollCount = 0;
    int winCount = 0;
    string rollAgain = "";

    // do while: the player came to roll, so the body has to run once before there is anything to ask about rolling again.
    do
    {
        rollCount++;
        int die1 = rng.Next(1, 7);
        int die2 = rng.Next(1, 7);
        int total = die1 + die2;

        Console.Write($"Roll {rollCount}: {die1} and {die2}, total {total}.");

        if (die1 == 1 && die2 == 1)
        {
            Console.WriteLine(" Snake eyes.");
        }
        else if (die1 == die2)
        {
            Console.WriteLine(" Doubles!");
        }
        else if (total == 7 || total == 11)
        {
            Console.WriteLine(" A winner.");
        }
        else
        {
            Console.WriteLine();
        }

        if (total == 7 || total == 11)
        {
            winCount++;
        }

        Console.Write("Roll again? (y/n): ");
        rollAgain = Console.ReadLine();

    } while (rollAgain == "y");

    Console.WriteLine($"You rolled {rollCount} times and won {winCount}.");
}

// Exercise 3: The Score Report
if (choice == 3 || choice == 4)
{
    Console.WriteLine("=== Exercise 3: The Score Report ===");

    int[] scores = new int[NumberOfScores];

    // for: the prompt has to say which score this is, so the position in the array is part of what the loop needs.
    for (int i = 0; i < scores.Length; i++)
    {
        Console.Write($"Score {i + 1}: ");
        scores[i] = Convert.ToInt32(Console.ReadLine());
    }

    int total = 0;
    int highest = scores[0];
    int passingCount = 0;

    // foreach: adding up, comparing, and counting need every value and no position whatsoever.
    foreach (int s in scores)
    {
        total += s;

        if (s > highest)
        {
            highest = s;
        }

        if (s >= PassingScore)
        {
            passingCount++;
        }
    }

    double average = (double)total / scores.Length;

    Console.WriteLine($"Scores entered: {scores.Length}");
    Console.WriteLine($"Total: {total}");
    Console.WriteLine($"Average: {average:F1}");
    Console.WriteLine($"Highest: {highest}");
    Console.WriteLine($"Passing: {passingCount} of {scores.Length}");
}