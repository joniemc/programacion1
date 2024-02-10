using System;

public class Program { 
    //Función principal
    public static void Main(string[] args)
    {

        int opcion = 0;
        int enteroA = 0;
        int enteroB = 0;
        do {
            ImprimirMenuConWriteLine();
             opcion = Convert.ToInt16(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese la cantidad de estudiantes para el promedio: ");
                    int cantidadEstudiantes = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("El promedio es {0}: ",CalcularPromedio(cantidadEstudiantes));
                    break;
                case 2:
                    Console.WriteLine("Ingrese el entero A: ");
                    enteroA = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Ingrese el entero B: ");
                    enteroB = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("El resultado de la suma es: {0}",CalcularSuma(enteroA,enteroB));
                    break;
                case 3:
                    Console.WriteLine("Ingrese el entero A: ");
                    enteroA = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Ingrese el entero B: ");
                    enteroB = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("El resultado de la suma es: {0}", CalcularResta(enteroA,enteroB));
                    break;
                case 4:
                    Console.WriteLine("Ingrese el numero base: ");
                    enteroA = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Ingrese el exponente: ");
                    enteroB = Convert.ToInt16(Console.ReadLine());

                    double calculoPotencia = Math.Pow(enteroA,enteroB);
                    Console.WriteLine("El resultado es: {0}", calculoPotencia);
                    break;
                case 5:
                    Console.WriteLine("Gracias por utilizar nuestra calculadora.");
                    break;
                default:
                    Console.WriteLine("Opción Invalida...");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine();
        } while (opcion!=5);
        
        
        Console.ReadLine();
    }

    public static void ImprimirMenuConWriteLine() {
        Console.WriteLine("**********Menu**********");
        Console.WriteLine("1. Calcular Promedio");
        Console.WriteLine("2. Suma");
        Console.WriteLine("3. Resta");
        Console.WriteLine("4. Calcular Potencia");
        Console.WriteLine("5. Finalizar");
        Console.WriteLine("Pesione el numero de la opción que desea...");
    }
    public static double CalcularPromedio(int cantidadEstudiantes)
    {

        double promedio;
        double sumaAcumulada = 0;

        for (int i = 0; i<cantidadEstudiantes; i++)
        {
            Console.WriteLine("Ingrese la nota {0} :", (i+1));
            double nota = Convert.ToDouble(Console.ReadLine());
            sumaAcumulada += nota;
        }

        promedio = sumaAcumulada/cantidadEstudiantes;


        return promedio;
    }

    public static double CalcularSuma(int enteroA, int enteroB) {
        return enteroA + enteroB;
    }
    public static double CalcularResta(int enteroA, int enteroB)
    {
        return enteroA - enteroB;
    }
}