using System;
class program
{
    static void Main(string[] args)
    {
        int[] numeros = { 10, 20, 30, 40, 50, 60 };
        int[] n = new int[] { 3, 4, 5 };
        char[] c = { 'L', 'u', 'i', 's' };
        string s = "Mona Lisa";

        Console.WriteLine("El arreglo de tipo entero de 6 elementos es:");

        Console.WriteLine(numeros[0]); Console.WriteLine(numeros[1]);
        Console.WriteLine(numeros[2]); Console.WriteLine(numeros[3]);
        Console.WriteLine(numeros[4]); Console.WriteLine(numeros[5]);

        Console.WriteLine("El arreglo de tipo entero de 3 elementos es:");

        Console.WriteLine(n[0]); Console.WriteLine(n[1]);
        Console.WriteLine(n[2]);

        Console.WriteLine("El arreglo de tipo char de 4 elementos es:");

        Console.WriteLine(c[0]); Console.WriteLine(c[1]);
        Console.WriteLine(c[2]); Console.WriteLine(c[3]);

        Console.WriteLine("la cadena tipo char de Mona Lisa es:");

        Console.WriteLine(s[0]); Console.WriteLine(s[1]);
        Console.WriteLine(s[2]); Console.WriteLine(s[3]);
        Console.WriteLine(s[5]); Console.WriteLine(s[6]);
        Console.WriteLine(s[7]); Console.WriteLine(s[8]);
        Console.ReadKey();
    }
}