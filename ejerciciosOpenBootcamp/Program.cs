//Crear variables para datos de una persona y formar un msj
Console.WriteLine("Ingresa tu nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine("Ingresa tu edad usando numeros: ");
int edad = Convert.ToInt32(Console.ReadLine());
string msj = $"Hola {nombre} tu edad es {edad}";
Console.WriteLine(msj);

//Describir objeto usando su tipo de variable Coche:puertas, ruedas, marca, ITV vigente - Mesa:peso, largo, material, color
//Coche:
int cantidadPuertas = 5;
int cantidadRuedas = 4;
string marca = "Corsa Classic";
bool ITVvigente = true;
//Mesa:
double kgMesa = 5.5;
double mtsMesa = 2.5;
string materialMesa = "Madera";
string colorMesa = "Blanca";

//Verificar las sigientes condiciones -Numero mayor o igual a 18 -Un char es ´a´ -Se cumplen dos condiciones verdaderas -Se cumple una de dos condiciones a la vez true y false
int num1 = 20;
int num2 = 10;
char unaLetra = 'a';
Console.WriteLine("\nCondiciones todas true");
Console.WriteLine(num1 >= 18);
Console.WriteLine(unaLetra=='a');
Console.WriteLine(num1<21 && num1> 19);
Console.WriteLine(num2>3||num2<5);
