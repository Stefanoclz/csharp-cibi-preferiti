// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] cibiPreferiti = { "Carbonara", "Hamburger", "Pizza", "Meringata", "Bistecca", "Sushi" };


Console.WriteLine("La lista dei cibi contiene " + cibiPreferiti.Length + " elementi");

string answer = Console.ReadLine();

int random = new Random().Next(0, 6);


for (int i = 0; i < cibiPreferiti.Length; i++)
{
    if (answer == cibiPreferiti[i] && random == i)
    {
        Console.WriteLine((i + 1) + " " + cibiPreferiti[i] + " --> Stessi gusti bro!");
    }
    else if(random == i)
    {
        Console.WriteLine((i + 1) + " " + cibiPreferiti[i] + " --> Cibo preferito dal PC");
    } 
    else if (answer == cibiPreferiti[i])
    {
        Console.WriteLine((i + 1) + " " + cibiPreferiti[i] + " --> Cibo preferito dall'utente");
    }
    else
    {
        Console.WriteLine((i + 1) + " " + cibiPreferiti[i]);
    }
    
}

Console.WriteLine("Il mio cibo preferito è: " + cibiPreferiti[0]);


int last = cibiPreferiti.Length - 1;
Console.WriteLine("L'ultimo dei miei cibi preferiti è: " + cibiPreferiti[last]);


if(cibiPreferiti.Length % 2 == 0)
{
    Console.WriteLine("I cibi al centro sono: " + cibiPreferiti[cibiPreferiti.Length/2] + " e " + cibiPreferiti[(cibiPreferiti.Length / 2) + 1]);
} else
{
    Console.WriteLine("Il cibo al centro è: " + cibiPreferiti[cibiPreferiti.Length / 2]);
}

