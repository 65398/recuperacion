using System;
class pollo:Decorador
{
    public pollo(OrdenBase orden): base(orden)
    {

    }
    public override double CalcularPrecio()
    {
        return base.CalcularPrecio()+ 1.25;
    }
}