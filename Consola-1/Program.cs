// See https://aka.ms/new-console-template for more information

using EspacioCalculadora;

Console.WriteLine("Hola mundo");

//double resultado = EspacioCalculadora.Calculadora;
Calculadora Resultado = new Calculadora();

Resultado.Limpiar();
Resultado.Dividir(5);
Resultado.Multiplicar(10);
Resultado.Sumar(5);
Resultado.Dividir(5);
Resultado.Multiplicar(10);
Resultado.Sumar(5);

