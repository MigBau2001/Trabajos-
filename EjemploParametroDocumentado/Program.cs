using System;

namespace Parametro
{

class Prueba
{
    public static void SumaUno(int x) // Static Significa que no necesito crear un objeto para utilizar el metodo de esta clase.
    {
        
        x = x + 1;
    }

    public static void Suma(in int a, in int b, out int c) // Aqui se inicializa C, al guardar el valor de la suma de a y b
    {
        c = a + b; 
    }
}

    class Program
    {
        static void Main(string[] args)
        {
            // Paso de parametro como valor
            int a =  12; 
            int b = 10;
            int c;

            Prueba.SumaUno(a);
            Console.WriteLine(a); // Se imprime 12 pues el valor que pasamos como argumento es una copia de este mismo.

            Prueba.Suma(in a,in b, out c); // C no se inicializa hasta en el metodo, pues ese es el proposito del metodo llamado(Suma())
            // a y b tienen modificador in, pues el valor de estos no se modifica, solo modificaremos el valor de c.
            Console.WriteLine(c);
        }
    }
}