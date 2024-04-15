using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// Implementado!!

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "(12)99877-6655", modelo: "Nokia-S", imei: "11111111", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whats App");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("(11)00122-3344", "Iphone 15 Pro Max", "22222222", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");