//Welcome message
Console.WriteLine("Can You Pass");
Console.WriteLine("------------");
Console.WriteLine();

//Get user input
Console.Write("What is your name: ");
string? name = Console.ReadLine();

Console.Write("Enter your General Weighted Average: ");
bool isGwa = decimal.TryParse(Console.ReadLine(), out decimal gwa);

//Evaluate input
bool isJuan = name.ToLower() == "juan";
bool isPedro = name.ToLower() == "pedro";
bool gradePass = gwa >= 70;

if (isJuan && gradePass)
{
    Console.WriteLine("Hello Juan Dela Cruz. You pass!");
}
else if (isPedro && gradePass)
{
    Console.WriteLine($"Nice {name}! You pass with your grade {gwa}.");
}
else if (isJuan || gradePass)
{
    Console.WriteLine($"Hi {name}. It is {gradePass} that you pass.");
}
else
{
    Console.WriteLine("You have room for improvements.");
}

if(gwa > 100)
{
    Console.WriteLine("Gotta say, you pass the limit, Saitama.");
}