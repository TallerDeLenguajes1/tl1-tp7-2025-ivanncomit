// See https://aka.ms/new-console-template for more information

using EspacioCalculadora;

Console.WriteLine("Hola mundo");

//double resultado = EspacioCalculadora.Calculadora;
Calculadora Resultado1 = new Calculadora(10);
Calculadora Resultado = new Calculadora();

Resultado.Limpiar();
Console.WriteLine("------------------------");
Resultado.Sumar(5);
Resultado.Multiplicar(2);
Console.WriteLine("------------------------");
Resultado1.Dividir(5);
Resultado1.Sumar(5);
