using System;
using System.Collections.Generic;

class Program
{
    private static void Main(string[] args)
    {
        List<string> frutas = new List<string> { "Morango", "Manga", "Goiaba", "Uva" };

        Console.WriteLine("Minha Lista de Frutas:");
        frutas.ForEach(Console.WriteLine);

        Console.WriteLine("\nFruta no índice 2: " + frutas[2]);

        frutas.Insert(1, "Maracujá");
        frutas[4] = "Pêra";

        Console.WriteLine("\nLista Atualizada:");
        frutas.ForEach(Console.WriteLine);

        frutas.RemoveAt(3);
        frutas.Remove("Morango");

        Console.WriteLine("\nLista Após Remoções:");
        frutas.ForEach(Console.WriteLine);

        frutas.Clear();
    }
}