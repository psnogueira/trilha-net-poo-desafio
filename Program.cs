using DesafioPOO.Models;

// Testes com a Classe 'Nokia'
Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia(numero: "912341234", modelo: "Nokia X", imei:"11111111", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n---------------\n");

// Testes com a Classe 'Iphone'
Console.WriteLine("Iphone:");
Smartphone iphone = new Iphone(numero: "944446666", modelo: "Iphone 12", imei:"22222222", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");