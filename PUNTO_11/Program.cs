using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello");
        //DECLARAR CONSTANTE
        const double sueldobase = 2500000;
      const double bnextra = 100000;
     const double objetivo = 1000000;
    const  double PRcomision = 10;
        double VN1, VN2, VN3, EXCELENTE;

        Console.Write("Ingresar la primera venta del mes: ");
        VN1=Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresar la segunda venta del mes: ");
        VN2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresar la tercera venta del mes: ");
        VN3= Convert.ToDouble(Console.ReadLine());

        //COMISIONES

        double comision1= VN1 * PRcomision;
        double comision2= VN2 * PRcomision;
        double comision3= VN3 * PRcomision;

        //TOTAL DE COMISIONES

        double totalcm= comision1 + comision2 + comision3;

        // Cálculo de la venta que generó mayor comisión

        double mayorComision = comision1;
        int comisionmayor = 1;

        if (comision2 > mayorComision);
        {
            mayorComision = comision2;
            comisionmayor = 2;
        }

        if (comision3 > mayorComision);
        {
            mayorComision = comision3;
            comisionmayor = 3;
        }

        // Cálculo del promedio de las comisiones
        double PromedioComisiones = totalcm / 3;

        // Total recibido (sueldo base + comisiones)
        double TotalMensual = sueldobase + totalcm;

        // Comprobamos si superó el objetivo y se lleva el beneficio extra
        double totalVentas = VN1 + VN2 + VN3;

        if (totalVentas >= objetivo)
        {
            TotalMensual += bnextra;
            Console.WriteLine("¡Felicidades! El vendedor superó el objetivo y ha ganado una bonificación de $100000");
        }
        else
        {
            Console.WriteLine("El vendedor no ha superado el objetivo del mes.");
        }

        // Resultados
        Console.WriteLine($"\nComisiones por cada venta:");
        Console.WriteLine($"Comisión por venta 1: ${comision1}");
        Console.WriteLine($"Comisión por venta 2: ${comision2}");
        Console.WriteLine($"Comisión por venta 3: ${comision3}");

        Console.WriteLine($"\nTotal de comisiones: ${totalcm}");
        Console.WriteLine($"Total mensual (sueldo base + comisiones): ${TotalMensual}");
        Console.WriteLine($"La venta que generó mayor comisión fue la venta {comisionmayor} con ${mayorComision}");
        Console.WriteLine($"Promedio de comisiones por cada venta: ${PromedioComisiones}");








    }
}