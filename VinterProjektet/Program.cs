

Console.WriteLine("What is your character name?");
string name = Console.ReadLine();
while (true)
{

    Console.WriteLine("Choose your class ");
    Console.WriteLine("\n1. Wizard\n2. Knight\n3.  ");

    int choise;

    while (!int.TryParse(Console.ReadLine(), out choise))
    {
        Console.WriteLine("Thats not a number");
    }

    // fixa fel, chat säger döp om
    switch (choise)
    {
        case 1:
            Character Wizard = new Wizard();
            break;
        case 2:
            Character Knight = new Knight();
            break;
        default:
            Character Deafault = new Default();
            break;

    }
}


// Character player1 = new Knight();

// player1.Name = name;

// Console.WriteLine(player1.Name);