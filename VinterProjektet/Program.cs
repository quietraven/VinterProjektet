Console.WriteLine("What is your character name?");
string name = Console.ReadLine(); 

Console.WriteLine("Choose your class ");
Console.WriteLine("\n1. Wizard\n2. Knight\n3.  ");

int choise;

while(!int.TryParse(Console.ReadLine(), out choise))
{
    Console.WriteLine("Thats not a number");
}

switch(choise)
{
    case 1:
    Character player1 = new Wizard();
    break;
    case 2:
    Character player = new Knight();
    break;
    default:

}


// Character player1 = new Knight();

// player1.Name = name;

// Console.WriteLine(player1.Name);