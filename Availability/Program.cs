//Welcome message
Console.WriteLine("Availability");
Console.WriteLine("------------");
Console.WriteLine();

//Get user input
Console.Write("What is your name: ");
string? name = Console.ReadLine();

Console.Write("What is your order: ");
string? order = Console.ReadLine();

//Show values
if (order?.ToLower() == "manok" || order?.ToLower() == "baboy")
{
    Console.WriteLine($"{name}, What a jucylicious order!");
}
else if (order?.ToLower() == "turon" || order?.ToLower() == "calamares")
{
    Console.WriteLine($"{name}, Great choice of snack!");
}
else if (name?.ToLower() == "juan")
{
    Console.WriteLine($"Sorry {name}, your given order is currently not available.");
}
else
{
    Console.WriteLine($"We don't have {order} here.");
}

Console.ReadLine();