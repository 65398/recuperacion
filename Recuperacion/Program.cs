using System;
namespace Recuperacion
{
    public class Program
    {
       static void Main (String []args )
       {
       
         Console.WriteLine("Taco");
         var Tacos= new tacos();
         Console.WriteLine("El precio del taco es de: {Tacos.CalcularPrecio()}");
         var chile=new Chile(Tacos);
         Console.WriteLine("El precio del taco mas chile es{chile.CalcularPrecio()}");
         var Pollo= new pollo(Tacos);
         Console.WriteLine("El precio del taco mas pollo es de: {Pollo.CalcularPrecio()}");
         var Carne = new carne(Tacos);
         Console.WriteLine("El precio del taco mas carne es: {Carne.CalcularPrecio()}");

       }
    }
}
