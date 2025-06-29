// See https://aka.ms/new-console-template for more information

using EspacioCalculadora;

string entrada;
double dato, ingreso;
int opcion = 1;

Calculadora Resultado1 = new Calculadora(10);
Calculadora Resultado = new Calculadora();

Resultado.Limpiar();

Console.WriteLine("------------------------");

Resultado.Sumar(5);
Resultado.Multiplicar(2);

Console.WriteLine("------------------------");

Resultado1.Dividir(5);
Resultado1.Sumar(5);

System.Console.WriteLine(Resultado.Resultado);

do
{
    System.Console.WriteLine("A que valor desea aplicarle operaciones: ");
    entrada = Console.ReadLine();
    double.TryParse(entrada, out dato);
} while (!double.TryParse(entrada, out dato));


Calculadora calculos = new Calculadora(dato);

do
{
    System.Console.WriteLine("Ingrese que operacion desea Realizar:\nSuma - 1\nResta - 2\nMultiplicacion - 3\nDivision - 4\nSALIR -c/o\n");
    int.TryParse(Console.ReadLine(), out opcion);

    switch (opcion)
    {
        case 1:
            System.Console.WriteLine("\nCon que valor va a operar: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out ingreso);
            calculos.Sumar(ingreso);
            System.Console.WriteLine("El resultado es:" + calculos.Resultado);
            break;
        case 2:
            System.Console.WriteLine("\nCon que valor va a operar: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out ingreso);
            calculos.Restar(ingreso);
            System.Console.WriteLine("El resultado es: " + calculos.Resultado);
            break;
        case 3:
            System.Console.WriteLine("\nCon que valor va a operar: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out ingreso);
            calculos.Multiplicar(ingreso);
            System.Console.WriteLine("El resultado es: " + calculos.Resultado);
            break;
        case 4:
            do
            {
                System.Console.WriteLine("\nCon que valor va a operar: ");
                entrada = Console.ReadLine();
                double.TryParse(entrada, out ingreso);
            } while (ingreso == 0);

            calculos.Dividir(ingreso);
            System.Console.WriteLine("El resultado es: " + calculos.Resultado);
            break;
    }



} while (opcion > 0 && opcion < 5);