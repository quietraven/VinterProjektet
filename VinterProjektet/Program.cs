int ChoiceMethod()
{
    int choice;
    while (!int.TryParse(Console.ReadLine(), out choice))
    {
        Console.WriteLine("not a number, try again");
    }
    return choice;

}

int playerChoice = ChoiceMethod();

Console.WriteLine("What is your character name?");
string name = Console.ReadLine();


// while (true)
// {

//     Console.WriteLine("\nChoose your class ");
//     Console.WriteLine("\n1. Wizard\n2. Knight\n3.  ");

//     int choice;

//     while (!int.TryParse(Console.ReadLine(), out choice))
//     {
//         Console.WriteLine("Thats not a number");
//     }




//     switch (choice)
//     {
//         case 1:
//             Character Wizard = new Wizard();

//             Wizard.DisplayStats();


//             break;
//         case 2:
//             Character Knight = new Knight();

//             Knight.DisplayStats();

//             break;
//         default:
//             Character Default = new Default();

//             Default.DisplayStats();

//             break;

//     }
    
    
// }


// Character player1 = new Knight();

// player1.Name = name;

// Console.WriteLine(player1.Name);