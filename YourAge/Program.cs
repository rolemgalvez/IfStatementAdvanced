//Welcome message
Console.WriteLine("Your Age");
Console.WriteLine("--------");
Console.WriteLine();

//Get user input
Console.Write("Enter your name: ");
string? name = Console.ReadLine();

Console.Write("How old are you: ");
string? ageInput = Console.ReadLine();
int.TryParse(ageInput, out int age);

//Process inputs
bool isChild = age >= 0 && age <= 14;
bool isYouth = age >= 15 && age <= 24;
bool isAdult = age >= 25 && age <= 64;
bool isSeniors = age >= 65;

//Show values
if (isChild || isYouth)
{
    Console.WriteLine($"You have way to go {name}!");
}
else if (isAdult)
{
    Console.WriteLine($"Take your time {name}.");
}
else if (isSeniors)
{
    Console.WriteLine($"Appreciate your contributions {name}.");
    Console.WriteLine("Invest to next generation.");
}
else
{
    Console.WriteLine($"Well {name}, age doesn't matter anyways.");
}

Console.ReadLine();