using ejercicio1;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Ejercicio1 obj = new Ejercicio1();
int resultado = obj.Sumar(1, 2, 3);
Console.WriteLine(resultado);

Coche miCoche = new Coche();
miCoche.AgregarPuertas(1);
Console.WriteLine(miCoche.NumeroPuertas);

Console.ReadLine();
