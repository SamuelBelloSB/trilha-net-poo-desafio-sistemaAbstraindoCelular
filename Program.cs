using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iphone1 = new Iphone("7777-7777", "Iphone 1", "IMEI-0001", 8);
Console.WriteLine($"O modelo {iphone1.Modelo} possui IMEI: {iphone1.Imei} com {iphone1.Memoria}GB de memória. Número: {iphone1.Numero}.");
iphone1.InstalarAplicativo("Youtube");

Nokia nokia1 = new Nokia("8888-7777", "Nokia 1", "IMEI-0002", 8);
Console.WriteLine($"\nO modelo {nokia1.Modelo} possui IMEI: {nokia1.Imei} com {nokia1.Memoria}GB de memória. Número: {nokia1.Numero}.");
nokia1.InstalarAplicativo("Youtube");