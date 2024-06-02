//case to if exercise
/*int age = 19;

if (age==15)
{
    Console.WriteLine("Too young to party in the club!");
}
else 
{
    if(age==25)
    {
        Console.WriteLine("Good to go!");
    }
    else
    {
        Console.WriteLine("How old are you then?");
    }
}*/


//in celsius
int temperature = -5;
string stateOfMatter;

if (temperature < 0) stateOfMatter = "solid";
else stateOfMatter = "liquid";

Console.WriteLine("state of matter is {0}", stateOfMatter);
//Console.ReadKey();

// in short
temperature +=30;
stateOfMatter = temperature < 0 ? "solid" : "liquid";
Console.WriteLine("state of matter is {0}", stateOfMatter);

//excercise -> add the gas state
temperature +=80;

stateOfMatter = temperature > 100 ? "gas" : temperature < 0? "solid" :  "liquid";

Console.WriteLine("state of matter is {0}", stateOfMatter);
Console.ReadKey();