using System.Dynamic;

namespace EspacioCalculadora
{
    
public class Calculadora
{
    private double dato;

    public Calculadora(double dato = 0)
    {
        this.dato = dato;    
    }

        public void Sumar(double termino)
    {
        dato = termino + dato;
    }
    public void Restar(double termino)
    {
        dato = dato - termino;
    }
    public void Multiplicar(double termino)
    {
        dato = termino * dato;
    }
    public void Dividir(double termino)
    {
        dato = dato/termino;
    }
    public void Limpiar()
    {
        Console.Clear();
    }
    public double Resultado
    {
        get => dato;
    }
}

}
