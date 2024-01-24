using System;

class Program
{
    static void Main()
    {
        Console.Write("introduce un ano: ");
        int ano = Convert.ToInt32(Console.ReadLine());

        if (EsBisiesto(ano))
        {
            Console.WriteLine(ano + " es bisiesto");
        }
        else
        {
            Console.WriteLine(ano + " no bisiesto");
        }
    }

    static bool EsBisiesto(int ano)
    {
        return (ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0);
    }
}