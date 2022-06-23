// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] cibiPreferiti = { "Carbonara", "Hamburger", "Pizza", "Meringata", "Bistecca", "Sushi" };


Console.WriteLine("La lista dei cibi contiene " + cibiPreferiti.Length + " elementi");

for(int i = 0; i < cibiPreferiti.Length; i++)
{
    Console.WriteLine((i+1) + " " + cibiPreferiti[i]);
}

Console.WriteLine("Il mio cibo preferito è: " + cibiPreferiti[0]);


int last = cibiPreferiti.Length - 1;
Console.WriteLine("L'ultimo dei miei cibi preferiti è: " + cibiPreferiti[last]);