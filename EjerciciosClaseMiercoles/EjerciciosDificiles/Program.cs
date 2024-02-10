using System;

public class Pogram {
    public static void Main(string[] args)
    {
        int opcion = 0;
        double totalVentasDiarias = 0;
        do {
            Menu();
            opcion=Convert.ToInt16(Console.ReadLine());
            if (opcion==1)
            {
                Console.WriteLine("Ingrese el valor total de la venta: ");
                double totalVenta=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el tipo de cliente: ");
                int tipoCliente=Convert.ToInt16(Console.ReadLine());
                totalVentasDiarias += CalcularVentaConDescuento(totalVenta, tipoCliente);

                Console.WriteLine("El valor con descuento es: {0}", CalcularVentaConDescuento(totalVenta, tipoCliente));

            }
            else if (opcion==2)
            {
                //bloque de codigo Cierre
            }
            else {
                Console.WriteLine("Opción invalida..");
            }
        } while (opcion!=2);
    }

    public static void Menu() {
        Console.WriteLine("***********Menu***********");
        Console.WriteLine("1. Ingresar una venta");
        Console.WriteLine("2. Cierre del dia");
        Console.WriteLine("Ingrese una opción...");
    }

    public static double CalcularVentaConDescuento(double totalVenta, int tipoCliente) {
        double ventaConDescuento = 0;
        if (tipoCliente==1) {
            //30%
            ventaConDescuento = totalVenta*0.70;
        }

        if (tipoCliente==2)
        {
            //15%
            ventaConDescuento = totalVenta*0.85;
        }

        if (tipoCliente==3)
        {
            //25%
            ventaConDescuento = totalVenta*0.75;
        }

        return ventaConDescuento;
    }
}