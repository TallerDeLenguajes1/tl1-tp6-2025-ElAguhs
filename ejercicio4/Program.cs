
using System.Reflection.Metadata;

Console.Write("Ingrese la 1ra cadena de texto: ");
string texto = Console.ReadLine();

int cantidad = texto.Length;

Console.Write("Cantidad de caracteres de la 1ra cadena: ");
Console.WriteLine(cantidad);

Console.Write("Ingrese la 2da cadena de texto: ");
string texto2 = Console.ReadLine();

string completo = string.Concat(texto, " ", texto2);

Console.WriteLine(completo);

bool exito;

int posicion;

string posicion_num;

do
{
    Console.WriteLine("Desde que posicion queres printear la cadena?");

    posicion_num = Console.ReadLine();

    exito = int.TryParse(posicion_num, out posicion);

} while (!exito);

string subcadena = completo.Substring(posicion);

Console.WriteLine(subcadena);

Console.WriteLine("mostrando el contenido de la cadena concatenada caracter por caracter: ");

foreach (char caracter in completo)
{
    Console.WriteLine(caracter);
}

Console.WriteLine("que palabra deseas saber cuantas veces aparece");

string buscar = Console.ReadLine();

string textoMinuscula = completo.ToLower();

string palabraMinuscula = buscar.ToLower();

int index = textoMinuscula.IndexOf(palabraMinuscula);

int contador = 0;

while (index != -1)
{

    contador++;

    index = textoMinuscula.IndexOf(palabraMinuscula, index + palabraMinuscula.Length);


}

if (contador == 0)
{
    Console.WriteLine("No se ha encontrado ninguna palabra asi en la string :/");
}
else
{
    Console.WriteLine("La palabra aparece " + contador + " veces en el texto");

}

Console.WriteLine("el texto en minuscula: " + textoMinuscula);
string textoMayuscula = completo.ToUpper();
Console.WriteLine("el texto en mayuscula: " + textoMayuscula);

Console.WriteLine("Ingrese el caracter con el que desea separar la cadena.");
string separador = Console.ReadLine();
string[] resultado = completo.Split(separador);
foreach (string r in resultado)
{
    Console.WriteLine(r);

}

ConsoleKeyInfo confirmar_operacion_simple;

do
{



    Console.WriteLine("Ingrese la operacion que desea realizar ej: 582+123");

    string operacion = Console.ReadLine();

    char[] separador_operacion = { '+', '-', '*', '/' };

    string[] numeros_separados = operacion.Split(separador_operacion);

    if (numeros_separados.Length != 2)
    {
        Console.WriteLine("porfavor ingrese una operacion simple con 2 numeros enteros y 1 operador");
        return;
    }

    char operador_utilizado = '\0';

    foreach (char op in separador_operacion)
    {
        if (operacion.Contains(op))
        {
            operador_utilizado = op;
            break;
        }
    }

    int num1_convertido, num2_convertido;

    if (!int.TryParse(numeros_separados[0], out num1_convertido) || !int.TryParse(numeros_separados[1], out num2_convertido))
    {

        Console.WriteLine("Error al convertir los números.");
        return;
    }

    if (operador_utilizado == '\0')
    {
        Console.WriteLine("No se encontró un operador válido.");
        return;
    }

    switch (operador_utilizado)
    {
        case '+':
            suma(num1_convertido, num2_convertido);
            break;
        case '-':
            resta(num1_convertido, num2_convertido);
            break;
        case '*':
            multiplicacion(num1_convertido, num2_convertido);
            break;
        case '/':
            if (num2_convertido == 0)
            {
                Console.WriteLine("Error: división por cero.");
                return;
            }
            division(num1_convertido, num2_convertido);
            break;
        default:
            Console.WriteLine("Operador no válido.");
            return;
    }

    Console.WriteLine("desea hacer otra operacion simple con 2 numeros?");
    Console.WriteLine("Ingrese el caracter s/n si quiere o no quiere respectivamente");

    confirmar_operacion_simple = Console.ReadKey(true);

} while (confirmar_operacion_simple.Key == ConsoleKey.S);

Console.WriteLine("Apriete cualquier tecla para continuar a la calculadora");

ConsoleKeyInfo confirmar = Console.ReadKey(true);


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

        if (numero >= 5 && numero <= 9)
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
                if (tecla.Key == ConsoleKey.S)
                {

                    Console.WriteLine("¿Qué operación desea realizar?");

                    Console.WriteLine("5-Valor absoluto, 6-cuadrado, 7-raiz cuadrada, 8-seno, 9-coseno");

                    opcion = Console.ReadLine();

                    control = int.TryParse(opcion, out numero);

                    while (!control || numero < 5 || numero > 9)
                    {
                        Console.WriteLine("Opción inválida, vuelva a intentarlo:");
                        opcion = Console.ReadLine();
                        control = int.TryParse(opcion, out numero);
                    }
                }



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
                if (tecla.Key == ConsoleKey.S)
                {

                    Console.WriteLine("¿Qué operación desea realizar?");

                    Console.WriteLine("1-Suma, 2-Resta, 3-Multiplicación, 4-División");

                    opcion = Console.ReadLine();

                    control = int.TryParse(opcion, out numero);

                    while (!control || numero < 1 || numero > 4)
                    {
                        Console.WriteLine("Opción inválida, vuelva a intentarlo:");
                        opcion = Console.ReadLine();
                        control = int.TryParse(opcion, out numero);
                    }
                }

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

    string textoNumero = total.ToString();

    string textito = "la suma entre " + a + " y " + b + " es: ";

    string respuesta = string.Concat(textito, textoNumero);

    Console.WriteLine(respuesta);

}

void resta(float a, float b)
{
    float total = a - b;

    string textoNumero = total.ToString();

    string textito = "la resta entre " + a + " y " + b + " es: ";

    string respuesta = string.Concat(textito, textoNumero);

    Console.WriteLine(respuesta);

}

void multiplicacion(float a, float b)
{
    float total = a * b;

    string textoNumero = total.ToString();

    string textito = "la multiplicacion entre " + a + " y " + b + " es: ";

    string respuesta = string.Concat(textito, textoNumero);

    Console.WriteLine(respuesta);

}

void division(float a, float b)
{

    if (b == 0)
    {
        Console.WriteLine("no se puede dividir por 0");
        return;
    }
    float total = a / b;

    string textoNumero = total.ToString();

    string textito = "la division entre " + a + " y " + b + " es: ";

    string respuesta = string.Concat(textito, textoNumero);

    Console.WriteLine(respuesta);

}

void valorAbsoluto(float c)
{

    float resultado = Math.Abs(c);

    string textoNumero = resultado.ToString();

    string textito = "el valor absoluto de " + c + " es: ";

    string respuesta = string.Concat(textito, textoNumero);

    Console.WriteLine(respuesta);
}

void cuadrado(float c)
{
    float resultado = c * c;

    string textoNumero = resultado.ToString();

    string textito = "el cuadrado de " + c + " es: ";

    string respuesta = string.Concat(textito, textoNumero);

    Console.WriteLine(respuesta);
}

void raizCuadrada(float c)
{

    if (c < 0)
    {
        Console.WriteLine("No se puede calcular la raiz cuadrada de un numero negativo");
        return;
    }

    double resultado = Math.Sqrt(c);

    string textoNumero = resultado.ToString("F2");

    string textito = "la raiz cuadrada de " + c + " es: ";

    string respuesta = string.Concat(textito, textoNumero);

    Console.WriteLine(respuesta);

}


void seno(float c)
{

    double resultado = Math.Sin(c);

    string textoNumero = resultado.ToString("F2");

    string textito = "el seno de " + c + " (radianes) es: ";

    string respuesta = string.Concat(textito, textoNumero);

    Console.WriteLine(respuesta);

}

void coseno(float c)
{
    double resultado = Math.Cos(c);

    string textoNumero = resultado.ToString("F2");

    string textito = "la coseno de " + c + " (radianes) es: ";

    string respuesta = string.Concat(textito, textoNumero);

    Console.WriteLine(respuesta);
}

void parteEntera(float d)
{

    int entero = (int)d;

    string textoNumero = entero.ToString();

    string textito = "la la parte entera del float " + d + " es: ";

    string respuesta = string.Concat(textito, textoNumero);

    Console.WriteLine(respuesta);

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


