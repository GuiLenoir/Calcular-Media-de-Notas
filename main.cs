using System;
    class Program
    {
        static void Main(string[] args)
        {
            float n1;
            float n2;
            float n3;
            float n4;
            float media;
            Console.WriteLine("Digite a Nota 1");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Nota 2");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Nota 3");
            n3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Nota 4");
            n4 = float.Parse(Console.ReadLine());
            media = (n1 + n2 + n3 + n4) / 4;
            Console.WriteLine($"Sua média é:  {media}");
            Console.ReadLine();
        }
    }