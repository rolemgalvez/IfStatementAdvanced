//Welcome message
Console.WriteLine("In Your Prime");
Console.WriteLine("-------------");
Console.WriteLine();

//Get user input
Console.Write("What is your gender: ");
string? gender = Console.ReadLine();

Console.Write("How old are you: ");
string ageInput = Console.ReadLine();
bool isAgeNumber = int.TryParse(ageInput, out int age);

//Process input
bool isMale = gender?.ToLower() == "male";
bool isFemale = gender?.ToLower() == "female";
bool malePrime = age >= 35 && age <= 45;
bool femalePrime = age >= 18 && age <= 28;

//Show values
if(isMale && malePrime)
{
    Console.WriteLine("My man. You are in your prime!");
    Console.WriteLine("Considering you made yourself the best version.");
}
else if (isFemale && femalePrime)
{
    Console.WriteLine("Nice Lady. You are in your prime!");
    Console.WriteLine("Spend it wisely.");
}
else if (isAgeNumber == false)
{
    Console.WriteLine($"Your entered age is {ageInput} which is a {isAgeNumber} integer.");
    Console.WriteLine($"That's why its converted value is {age}.");
    Console.WriteLine("Try again and input an integer value.");
}
else
{
    Console.WriteLine("Time is your valueable asset.");
    Console.WriteLine("So, take and appreciate it.");
}

Console.ReadLine();