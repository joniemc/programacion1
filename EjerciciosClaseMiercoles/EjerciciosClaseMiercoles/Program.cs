using System;

public class Program {
    public static void Main(string[] args) {
        //Solución del ejercicio: Es par o impar?

        //1. Solicitamos el ingreso de un numero desde pantalla
        Console.WriteLine("Ingrese un numero entero: ");
        
        //Declaramos la variable numero y convertimos a entero el valor ingresado por el usuario
        int numero = int.Parse(Console.ReadLine());

        //Hacemos uso del operador ternacio para determinar si el numero ingresado es par o impar
        //luego imprimimos el resultado
        string resultado = (numero%2==0) ? "Es Par" : "Es Impar";
        Console.WriteLine(resultado);

        //2. Ejemplos de concatenación, uso del Write y WriteLine 
        string cadenaResultado = "cadena 1"+numero+"+ Cadena 2";
        Console.WriteLine("El numero validado es:"+numero+"y el resultado es:"+resultado);
        Console.Write("El numero validado es: {0} y el resultado es: {1}",numero,resultado);
        Console.WriteLine(cadenaResultado);
        string carater = "a";
        Console.WriteLine(numero+carater);

        //3. Ejercicio de suma
        Console.WriteLine("Ingrese un segundo numero entero: ");
        int numero2 = Convert.ToInt16(Console.ReadLine()); //Esta es otra forma en la que podemos convertir tipos de datos
        int suma = numero+numero2;
        Console.WriteLine("La suma es: {0}",numero+numero2);
        Console.WriteLine("La suma ejemplo 2 es: {0}", suma);

        Console.ReadLine();
    }
}
