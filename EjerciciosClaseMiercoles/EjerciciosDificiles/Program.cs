using System;

public class Pogram {
    public static void Main(string[] args)
    {
        int opcion = 0;
        double totalVentasDiariasTerceraEdad = 0;
        int cantidadTransaccionesTerceraEdad = 0;
        double totalVentasDiariasClienteNormal = 0;
        int cantidadTransaccionesClienteNormal = 0;
        double totalVentasDiariasEmpleado = 0;
        int cantidadTransaccionesEmpleado = 0;
        do {
            Menu();
            opcion=Convert.ToInt16(Console.ReadLine());
            if (opcion==1)
            {
                Console.WriteLine("Ingrese el valor total de la venta: ");
                double totalVenta=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el tipo de cliente: ");
                int tipoCliente=Convert.ToInt16(Console.ReadLine());
                if (tipoCliente==1)
                {
                    //30%
                    totalVentasDiariasEmpleado = CalcularVentaConDescuento(totalVenta, tipoCliente);
                    cantidadTransaccionesEmpleado++;
                }

                if (tipoCliente==2)
                {
                    //15%
                    totalVentasDiariasClienteNormal = CalcularVentaConDescuento(totalVenta, tipoCliente);
                    cantidadTransaccionesClienteNormal++;
                }

                if (tipoCliente==3)
                {
                    //25%
                    totalVentasDiariasTerceraEdad = CalcularVentaConDescuento(totalVenta, tipoCliente);
                    cantidadTransaccionesTerceraEdad++;
                }
                Console.WriteLine("El valor con descuento es: L. {0}", CalcularVentaConDescuento(totalVenta, tipoCliente));

            }
            else if (opcion==2)
            {
                Console.WriteLine("**********************Cierre diario**********************");
                Console.WriteLine("El promedio de ventas para tercera edad es: L. {0}", CalcularPromedio(cantidadTransaccionesTerceraEdad,totalVentasDiariasTerceraEdad));
                Console.WriteLine("El promedio de ventas para cliente normal es: L. {0}", CalcularPromedio(cantidadTransaccionesClienteNormal, totalVentasDiariasClienteNormal));
                Console.WriteLine("El promedio de ventas para empleado es: L. {0}", CalcularPromedio(cantidadTransaccionesEmpleado, totalVentasDiariasEmpleado));
                Console.WriteLine("Gracias por utilizar nuestro sistema....");
            }
            else {
                Console.WriteLine("Opción invalida..");
            }
        } while (opcion!=2);

        Console.ReadLine();
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

    public static double CalcularPromedio(int cantidadTransacciones, double totalVentas) {
        double promedio = 0;
        if (cantidadTransacciones!=0) {
            promedio = totalVentas/cantidadTransacciones;
        }
        return promedio;
    }
}