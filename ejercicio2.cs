

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

   

    switch (numero)
    {
        case 1:

            float total_suma = suma();

            break;

        case 2:

            float total_resta = restar();

            break;

        case 3:

            float total_multiplicacion = Multiplicar();

            break;

        case 4:

            float total_division = dividir();

            break;


    }

}
else
{
    Console.WriteLine("No has ingresado un numero");
}



float suma()
{



    return (a + b);
}

float restar()
{
    return (a - b);
}

float Multiplicar()
{
    return (a * b);
}

float dividir()
{
    return (a / b);
}

