using System;

public class Program { 
    //Función principal
    public static void Main(string[] args)
    {

        int opcion = 0;
        do {
            ImprimirMenuConWriteLine();
             opcion = Convert.ToInt16(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    //Bloque codigo para promedio
                    Console.WriteLine("Ingrese la cantidad de estudiantes para el promedio: ");
                    int cantidadEstudiantes = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("El promedio es {0}: ",CalcularPromedio(cantidadEstudiantes));
                    break;
                case 2:
                    Console.WriteLine("Opción 2");
                    break;
                case 3:
                    //Bloque de codigo para resta
                    break;
                case 4:
                    //Bloque de codigo para potencia
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

}