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