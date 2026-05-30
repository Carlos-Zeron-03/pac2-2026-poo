namespace IntroduccionCSharp.Variables
/*
Variable: es un espacio en la memoria RAM con un nombre que almacena un valor 
para definir una variable en C#
tipoDeDato nombreVariable = Valor Opcional
string nombre = "Juan Perez";
int edad = 20;

Tipo      Descripción       Tamaño
int =     Entero            32 bits
Long=     Entero Grande     64 bits
float =   Decimal simple    32 bits
double =  Decimal doble     64 bits
decimal = Decimal Exacto    128 bits
bool =    Booleano          8 bits => 1 byte
char =    Carácter          16 bits
string =  Texto             Variable

Metodo constructor: se va a llamar igual a la clase, tiene que ser publico, no puede retornar nada
*/

{
    public class Eje01
    {
        public Eje01()
        {
            float f = 0.1f;
            double d = 0.1;
            decimal m = 0.1m;

            Console.WriteLine(f + f + f + f + f); //0.5000001
            Console.WriteLine (d + d + d + d + d); //0.5
            Console.WriteLine (m + m + m + m + m); //0.5

        }   
    }
}