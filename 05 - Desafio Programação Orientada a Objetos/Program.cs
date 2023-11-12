using DesafioPOO.Models;


Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("72392", "iPhone 8", "92929", 256);
iphone.Ligar();
iphone.InstalarAplicativo("Waze");

Console.WriteLine("");

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("92832", "NK108", "999999", 12);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");