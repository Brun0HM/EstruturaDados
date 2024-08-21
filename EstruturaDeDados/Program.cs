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

        //Trabalhando com dicionario (dictionary)
        /* Criando um Dicionario de dados */
        Dictionary<int, string> carros = new Dictionary<int, string>();

        carros.Add(5, "Corsa");
        carros.Add(10, "Masserati");
        carros.Add(2, "porshe");

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Minha dicionario de carros");

        foreach (var carro in carros)
        {
            Console.WriteLine($"{carro.Key} - {carro.Value}");
        }



        // TRabalhando com fila
        // criar uma fila (queue)

        Queue<string> FilaBanco = new Queue<string>();
        FilaBanco.Enqueue("André");
        FilaBanco.Enqueue("josé");
        FilaBanco.Enqueue("mazzi");
        FilaBanco.Enqueue("bruno");

        foreach (var pessoa in FilaBanco)
        {
            Console.WriteLine(pessoa);
        }
        FilaBanco.Dequeue();

        Console.WriteLine();
        Console.WriteLine("===============");
        Console.WriteLine();
        foreach (var pessoa in FilaBanco)
        {

            Console.WriteLine(pessoa);
        }

        // verificar se existe um elemento na fila

        bool achou = FilaBanco.Contains("manoel"); 
            if (achou) {
            Console.WriteLine("A pessoa está na fila");
        }
        else {
            Console.WriteLine("A pessoa NÃO está na Fila");
        }

        Console.WriteLine();
        Console.WriteLine("===============");
        Console.WriteLine();

        // TRABALHANDO COM  PILHA (STACK)
        Stack<string> Livros = new Stack<string>();
        //adicionar elementos em uma pilha
        Livros.Push("Chapeu");
        Livros.Push("Mazzi o incio");
        Livros.Push("Mazzi o fim");

        foreach (var Livro in Livros)
        {
            Console.WriteLine(Livro);
        }

        Console.WriteLine();
        Console.WriteLine("===============");
        Console.WriteLine();
    }
}