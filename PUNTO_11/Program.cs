using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //DECLARAR CONSTANTE
        double sueldobase = 2500000;
        double bnextra = 100000;
        double objetivo = 1000000;
        double PRcomision = 10;
        double VN1, VN2, VN3;

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

        double total= comision1 + comision2 + comision3 + bnextra + sueldobase;


        //OBJETIVO LOGRADO









    }
}