using DesafioPOO.Models;

// Testes com a Classe 'Nokia'
Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia(numero: "1112341234", modelo: "Modelo 1", imei:"11111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n---------------\n");

// Testes com a Classe 'Iphone'
Console.WriteLine("Iphone:");
Smartphone iphone = new Iphone(numero: "55244466666", modelo: "Modelo 2", imei:"22222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");