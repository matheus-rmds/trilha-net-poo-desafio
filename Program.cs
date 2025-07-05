using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("7892341", "Modelo 1", "111111111", 256);
nokia.Ligar();
nokia.InstalarAplicativo("Whatspp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("8179050", "Modelo 2", "222222222", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
