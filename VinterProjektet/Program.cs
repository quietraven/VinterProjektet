int ChoiceMethod()
{
    int choice;
    while (!int.TryParse(Console.ReadLine(), out choice))
    {
        Console.WriteLine("not a number, try again");
    }
    return choice;

}

Console.WriteLine("What is your character name?");
string name = Console.ReadLine();

Character Player = new();

while (true)
{
    List<string> inventory = [];

    Console.WriteLine("\nChoose your class ");
    Console.WriteLine("\n1. Wizard\n2. Knight\n3.  ");

    int choice = ChoiceMethod();

    switch (choice)
    {
        case 1:
            Player = new Wizard();

            Player.DisplayStats();


            break;
        case 2:
            Player = new Knight();
            break;
        default:
            Character Default = new Default(); // hur får jag default stats

            break;

    }

    Player.DisplayStats();

    Console.WriteLine("story");
    Console.WriteLine("1. 2. ");
    
    choice =ChoiceMethod();

    if (choice == 1)
    {
        Console.WriteLine("");
    }

    else if (choice == 2)
    {
        Console.WriteLine("");
    }



}

