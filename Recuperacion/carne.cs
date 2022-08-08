using System;
class carne:Decorador
{
  public carne(OrdenBase orden): base(orden)
  {

  }
    public override double CalcularPrecio()
    {
        return base.CalcularPrecio() + 1.50;
    }
}