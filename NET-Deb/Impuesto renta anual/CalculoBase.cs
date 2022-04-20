using System;

class CalculoBase
{
    //CÁLCULAMOS EL IMPUESTO
    public double Proceso(double Dinero)
    {
        double TotalPagar = Dinero * Impuesto;
        return TotalPagar;
    }

    //GETTER
    public double GetImpuesto() { return Impuesto * 100; }
   
    //PROPIEDAD DE OBJETO O CLASE
    private static double Impuesto = 0.16;
}