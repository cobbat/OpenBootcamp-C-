//ejercicios bucles *PALABRA CLAVE(CONDICION){BLOQQ DE CODIGO}*
//Ejercicio 1 - While
//Escribe una tabla de multiplicar del 1 al 10 para un número entero que recibe por consola.
Console.WriteLine("ingresa un numero para mostrar su tabla del 1 al 10:");
int.TryParse(Console.ReadLine(), out var numIngresado);
int n = 1;
Console.WriteLine($"tabla del {numIngresado}");
while (n<=10)              //ME AYUDO PABLO EN TODO >:(
{
    Console.WriteLine(numIngresado*n);
    n++; //iterar solo la variable de control
}
//Ejercicio 2 - Do while
//Escribe un programa que realice estos pasos: 
//-Reciba al menos un número por consola
//-Determine si el número es positivo o negativo
//-Presente un contador para cada tipo (positivo y negativo).
Console.WriteLine("\nIngresa un numero");
int.TryParse(Console.ReadLine(), out var numero);
int numNegativo = 0;
int numPositivo = 0;
do
{
    Console.WriteLine($"");
    
} while ();

//Ejercicio 3 - For
//Escribe un programa que realice estos pasos:
//-Reciba 3 datos:
//ancho
//alto
//relleno o no
//-Dibuje en consola con un mismo caracter, por ejemplo *, un rectángulo de las dimensiones introducidas y use el tercer dato para
//discernir si el rectángulo está relleno (tiene más * dentro) o no.
//-En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.


