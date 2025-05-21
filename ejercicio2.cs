bool incorrecta;
ConsoleKeyInfo tecla;
ConsoleKeyInfo tecla2;
do
{

    incorrecta = true;

    Console.WriteLine("--------MENU--------");
    Console.WriteLine("1-Sumar");
    Console.WriteLine("2-Restar");
    Console.WriteLine("3-Multiplicar");
    Console.WriteLine("4-Dividir");
    Console.WriteLine("5-valor absoluto de un número");
    Console.WriteLine("6-cuadrado del numero");
    Console.WriteLine("7-raíz cuadrada");
    Console.WriteLine("8-seno del numero");
    Console.WriteLine("9-Coseno del numero");
    Console.WriteLine("10-parte entera de un tipo float");

    string opcion = Console.ReadLine();

    int numero;

    bool control = int.TryParse(opcion, out numero);

    if (!control)
    {
        Console.WriteLine("Lo que ingresaste no es un numero");
        incorrecta = false;
    }

    if (numero < 1 || numero > 10)
    {

        Console.WriteLine("El numero que ingresaste no está en las opciones");
        incorrecta = false;
    }

    if (control && incorrecta)
    {

        if (numero > 4)
        {
            bool control4;
            float c;
            string num3;
            do
            {


                Console.WriteLine("Ingrese el numero");

                num3 = Console.ReadLine();

                control4 = float.TryParse(num3, out c);

            } while (!control4);

            do
            {

                switch (numero)
                {
                    case 5:

                        valorAbsoluto(c);

                        break;

                    case 6:

                        cuadrado(c);

                        break;

                    case 7:

                        raizCuadrada(c);

                        break;

                    case 8:

                        seno(c);

                        break;

                    case 9:

                        coseno(c);

                        break;


                }
                Console.WriteLine("Desea realizar otra operacion con los mismos numeros?");
                Console.WriteLine("Presione la letra 's' o 'n' si quiere o no quiere respectivamente");
                tecla = Console.ReadKey(true);

            } while (tecla.Key == ConsoleKey.S);




        }
        else if (numero == 10)
        {

            float d;
            bool control5;
            string num4;

            do
            {
                Console.WriteLine("Ingrese un numero tipo float");

                num4 = Console.ReadLine();

                control5 = float.TryParse(num4, out d);

            } while (!control5);

            parteEntera(d);



        }
        else if (numero <= 4 && numero >= 1)
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



            do
            {

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

                Console.WriteLine("Desea realizar otra operacion con los mismos numeros?");
                Console.WriteLine("Presione la letra 's' o 'n' si quiere o no quiere respectivamente");
                tecla = Console.ReadKey(true);

            } while (tecla.Key == ConsoleKey.S);







        }






    }
    else
    {
        Console.WriteLine("No has ingresado un numero");
    }

    Console.WriteLine("desea realizar la operacion con otros numeros?");
    Console.WriteLine("Presione la letra 's' o 'n' si quiere o no quiere respectivamente");
    tecla2 = Console.ReadKey(true);

} while (tecla2.Key == ConsoleKey.S);

Console.WriteLine("Muchas gracias por utilizar esta calculadora");

minijuego();




void suma(float a, float b)
{
    float total = a + b;

    Console.Write("La suma es:");
    Console.WriteLine(total);

}

void resta(float a, float b)
{
    float total = a - b;

    Console.Write("La resta es:");
    Console.WriteLine(total);

}

void multiplicacion(float a, float b)
{
    float total = a * b;

    Console.Write("La multiplicacion es:");
    Console.WriteLine(total);

}

void division(float a, float b)
{

    if (b == 0)
    {
        Console.WriteLine("no se puede dividir por 0");
        return;
    }
    float total = a / b;

    Console.Write("La division es:");
    Console.WriteLine(total);

}

void valorAbsoluto(float c)
{

    float resultado = Math.Abs(c);

    Console.Write("El valor absoluto del numero es ");
    Console.WriteLine(resultado);
}

void cuadrado(float c)
{
    c *= c;

    Console.Write("El cuadrado del numero es ");
    Console.WriteLine(c);
}

void raizCuadrada(float c)
{

    if (c < 0)
    {
        Console.WriteLine("No se puede calcular la raiz cuadrada de un numero negativo");
        return;
    }

    double resultado = Math.Sqrt(c);

    Console.Write("La raiz cuadrada de un numero es: ");
    Console.WriteLine(resultado);
}


void seno(float c)
{

    double resultado = Math.Sin(c);

    Console.Write("El seno de un numero es: ");
    Console.WriteLine(resultado);

}

void coseno(float c)
{
    double resultado = Math.Cos(c);

    Console.Write("El coseno de un numero es: ");
    Console.WriteLine(resultado);
}

void parteEntera(float d)
{

    int entero = (int)d;

    Console.Write("El entero del numero float es: ");
    Console.WriteLine(entero);

}

void minijuego()
{
    Console.WriteLine("-------------------------------------");
    Console.WriteLine("Ahora vamos a hacer un minijuego, ingrese dos numeros y le diré cual es el mas grande (los numeros deben ser validos)");


    int e, f;

    bool confirmar, confirmar2;

    string dato1, dato2;

    do
    {
        dato1 = Console.ReadLine();

        confirmar = int.TryParse(dato1, out e);

    } while (!confirmar);

    do
    {

        dato2 = Console.ReadLine();

        confirmar2 = int.TryParse(dato2, out f);

    } while (!confirmar2);

    if (e > f)
    {
        Console.Write("El numero mas grande es: ");
        Console.WriteLine(e);

    }
    else if (f > e)
    {
        Console.Write("El numero mas grande es: ");
        Console.WriteLine(f);
    }
    else if (f == e)
    {
        Console.WriteLine("Los dos son iguales, no hay uno mayor");
    }

}