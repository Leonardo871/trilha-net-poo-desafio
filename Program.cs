using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone NOKIA");
Smartphone Nokia = new Nokia(numero : "99999999",modelo :" Modelo 1" ,imei :"111111",memoria :64);
Nokia.Ligar();
Nokia.InstalarAplicativo("Whatsaap");
Nokia.ReceberLigacao();

Console.WriteLine("Smartphone IPHONE");
Smartphone Iphone = new Iphone(numero : "121212121",modelo :" Modelo 2" ,imei :"22222",memoria :80);
Iphone.Ligar();
Iphone.InstalarAplicativo("Telegram");
Iphone.ReceberLigacao();