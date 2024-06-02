//Constructors

//

class Human 
{
    //variables
    private string fisstName;
    private string lastName;

    public Human ()
    {
        Console.WriteLine("Constructor called"); 
    }

    //parametrized construxtor


}

Human basicHuman = new Human();

Console.WriteLine("¿Cual es tu nombre?");
var name = Console.ReadLine();
var currentDate = DateTime.Now;
Console.WriteLine($"{Environment.NewLine}Hola {name}, el {currentDate:d} a las {currentDate:t}!");
Console.Write($"{Environment.NewLine}Pulsa alguna tecla para salir...");
Console.ReadKey(true);


