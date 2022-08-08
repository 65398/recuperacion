using System;
class Chile:Decorador
{
    public Chile(OrdenBase orden): base (orden)
    {
        
    }
    public override double CalcularPrecio()
    {
        return base.CalcularPrecio()+ 0.50;
    }
}