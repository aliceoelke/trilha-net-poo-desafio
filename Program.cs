using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia = new Nokia(numero: "123456", modelo: "Nokia 110", imei: "37999999999", memoria: 32);
Console.WriteLine("Iniciando smartphone Nokia: ");
nokia.Ligar();
nokia.InstalarAplicativo("Meu Alelo");

Smartphone iphone = new Iphone(numero: "987654", modelo: "iPhone 13", imei: "48999999999", memoria: 256);
Console.WriteLine("Iniciando smartphone Iphone: ");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("iFood");