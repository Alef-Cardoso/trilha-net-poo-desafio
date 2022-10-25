using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Telefone Nokia");
Smartphone nokia = new Nokia(numero: "992158587", modelo: "novo", imei: "555", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Instagran");

Console.WriteLine("\nTelefone Iphone");
Smartphone iphone = new Iphone(numero: "992156647", modelo: "11", imei: "111", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Google Fotos");