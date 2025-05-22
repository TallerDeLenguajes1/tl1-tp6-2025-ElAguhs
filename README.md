String es una tipo por referencia, ya que la string es un alias de System.String, que es una clase, y en C#, las clases son por tipo referencia.
Eso quiere decir que cuando pasás un string como parámetro a un método, lo que se pasa es una referencia (puntero) al objeto en memoria, no una copia.
Pero tambien puede interpretarse como tipo por valor ya que aunque sea un tipo por referencia, no podés modificar su contenido una vez creado.


