

using System.Collections;
using System.Globalization;

int i = 0, j = 0, copia;

int[] invertido = new int[10];

string texto;

Console.WriteLine("Ingrese el numero");

texto = Console.ReadLine();

bool resultado = int.TryParse(texto, out i);

copia = i;

if (resultado)
{

    Console.WriteLine("se ha cambiado a numero con exito");

    Console.WriteLine(i);

    if (i > 0)
    {
        Console.WriteLine("El numero ingresado es positivo");

        while (i > 0)
        {
            i /= 10;

            j++;

        }

        Console.WriteLine("cantidad de numeros: " + j);

        Console.Write("El numero invertido es: ");

        for (int k = 0; k < j; k++)
        {

            invertido[k] = copia % 10;
            copia /= 10;
            
            Console.Write(invertido[k]);
        }


    }
    else
    {
        Console.WriteLine("El numero ingresado es negativo");
        Console.WriteLine(i);
    }

}
else
{
    Console.WriteLine("no has ingresado un numero");
    Console.WriteLine(i);


}