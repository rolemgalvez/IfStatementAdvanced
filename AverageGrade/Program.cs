//Welcome message
Console.WriteLine("Average Grade");
Console.WriteLine("-------------");
Console.WriteLine();

//Get user input
Console.Write("Enter grade in 1st Quarter: ");
double.TryParse(Console.ReadLine(), out double firstGrade);

Console.Write("Enter grade in 2nd Quarter: ");
double.TryParse(Console.ReadLine(), out double secondGrade);

Console.Write("Enter grade in 3rd Quarter: ");
double.TryParse(Console.ReadLine(), out double thirdGrade);

//Process input
double averageGrade = (firstGrade + secondGrade + thirdGrade) / 3;
bool isGoodGrade = averageGrade >= 70 && averageGrade <= 79.99;
bool isBetterGrade = averageGrade >= 80 && averageGrade <= 89.99;
bool isBestGrade = averageGrade >= 90 && averageGrade <= 100;
bool isUnbelievableGrade = averageGrade > 100;
bool isOneTimeNiceGrade = firstGrade >= 70 || secondGrade >= 70 || thirdGrade >= 70;

//Show results
if (isGoodGrade)
{
    Console.WriteLine($"Your average grade of {averageGrade} reflects your effort.");
}
else if (isBetterGrade)
{
    Console.WriteLine($"Great job to have the average grade of {averageGrade}!");
}
else if (isBestGrade)
{
    Console.WriteLine($"Fantastic average grade of {averageGrade}!");
}
else if (isUnbelievableGrade)
{
    Console.WriteLine($"Average grade of {averageGrade}? That's unbelievable!");
}
else if (isOneTimeNiceGrade)
{
    Console.WriteLine($"You got one nice grade! But the average is {averageGrade}.");
}
else
{
    Console.WriteLine("You simply need to work harder.");
}

Console.ReadLine();