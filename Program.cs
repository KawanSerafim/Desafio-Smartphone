using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:\n");
Nokia nokia = new Nokia(numero: "1234", modelo: "modelo_1", imei: "111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:\n");
Iphone iphone = new Iphone(numero: "123456", modelo: "modelo_7", imei: "222222", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Youtube");
iphone.ReceberLigacao();