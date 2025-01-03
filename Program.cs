using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "995906506", modelo: "tijolão", imei: "0101010101", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Iphone(numero: "995906506", modelo: "tijolão", imei: "0101010101", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");