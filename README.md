1-String es una tipo por referencia, ya que la string es un alias de System.String, que es una clase, y en C#, las clases son por tipo referencia.
Eso quiere decir que cuando pasás un string como parámetro a un método, lo que se pasa es una referencia (puntero) al objeto en memoria, no una copia.
Pero tambien puede interpretarse como tipo por valor ya que aunque sea un tipo por referencia, no podés modificar su contenido una vez creado.

2- En C#, el tipo string permite el uso de secuencias de escape para representar caracteres especiales dentro de una cadena de texto. A continuación se detallan las secuencias más utilizadas:

\n : salto de línea.

\r : retorno de carro.

\t : tabulación horizontal.

\\ : barra invertida (\).

\' : comilla simple (').

\" : comilla doble (").

\0 : carácter nulo.

\a : sonido de alerta.

\b : retroceso.

\f : avance de página.

\v : tabulación vertical.

\uXXXX : carácter Unicode especificado en formato hexadecimal.

\xXX : carácter Unicode en formato hexadecimal corto.

Estas secuencias son utilizadas comúnmente para dar formato a los textos o insertar caracteres especiales que no pueden escribirse directamente.

3- En C#, los caracteres @ y $ pueden colocarse delante de una cadena de texto para modificar su comportamiento. Cuando se utilizan juntos @$ o $@, se combinan sus funcionalidades:
El símbolo @ convierte a la cadena en una cadena literal, donde los caracteres de escape no se interpretan (por ejemplo, \n se trata como texto plano).
El símbolo $ permite utilizar interpolación de cadenas, es decir, insertar el valor de variables o expresiones directamente dentro del texto utilizando llaves {}.
Cuando se usan ambos, se obtiene una cadena interpolada y literal, permitiendo insertar variables sin preocuparse por caracteres de escape o por escribir dobles barras invertidas.
