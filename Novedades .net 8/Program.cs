//Operador de propagación
string[] beers1 = ["Sol", "Corona"];
string[] beers2 = ["Heineken", "Erdinger"];
string[] beers3 = ["Guinness", "Delirium"];

string[] beers = [.. beers1, .. beers3, .. beers2];
foreach (var beer in beers)
{
    Console.Write(beer + ", ");
}

//Constructores principales
var beer1 = new Beer("Corona");
Console.WriteLine(beer1.Name);

public class Beer(string _name) //se añade esto último
{
    /*public string Name { get; set; }

    public Beer(string name)
    {
    Name = name. ToUpper();
    }*/
    //Se sustituye por::
    public string Name = _name.ToUpper();
} //Parece que no se puede substituir en las interfaces

//Parámetros predefinidos
/*Func<double, double, double> mul = (double a, double b) => a * b;
Console.WriteLine(mul(1,10));*/
//Se substituye por
//var mul = (double a, double b = 10) => a * b; //se pueden fijar las  variable
//Console.WriteLine(mul(1)); //y no tener que pasarlas al ya tener su valor por defecto

