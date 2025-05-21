

Console.WriteLine("--------MENU--------");
Console.WriteLine("1-Sumar");
Console.WriteLine("2-Restar");
Console.WriteLine("3-Multiplicar");
Console.WriteLine("4-Dividir");

string opcion = Console.ReadLine();

int numero;

bool control = int.TryParse(opcion, out numero);

if (control)
{

    Console.WriteLine("Ingrese el primer valor");

    string num1 = Console.ReadLine();

    float a;

    bool control2 = float.TryParse(num1, out a);

    Console.WriteLine("Ingrese el segundo valor");

    string num2 = Console.ReadLine();

    float b;

    bool control3 = float.TryParse(num2, out b);

    while (!control2 || !control3)
    {

        if (!control2)
        {
            Console.WriteLine("Ingrese el primer valor denuevo");

            num1 = Console.ReadLine();

            control2 = float.TryParse(num1, out a);

        }
        else if (!control3)
        {
            Console.WriteLine("Ingrese el segundo valor denuevo");

            num2 = Console.ReadLine();

            control3 = float.TryParse(num2, out b);
        }

    }


    switch (numero)
    {
        case 1:

            suma(a, b);

            break;

        case 2:

            resta(a, b);

            break;

        case 3:

            multiplicacion(a, b);

            break;

        case 4:

            division(a, b);

            break;


    }

}
else
{
    Console.WriteLine("No has ingresado un numero");
}



void suma(float a, float b)
{
    float total = a + b;

    Console.Write("La suma es:");
    Console.WriteLine(total);

}

void resta(float a, float b)
{
    float total = a - b;

    Console.Write("La suma es:");
    Console.WriteLine(total);

}

void multiplicacion(float a, float b)
{
    float total = a * b;

    Console.Write("La suma es:");
    Console.WriteLine(total);

}

void division(float a, float b)
{
    float total = a / b;

    Console.Write("La suma es:");
    Console.WriteLine(total);

}






