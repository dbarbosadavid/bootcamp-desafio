using DesafioPOO.Models;


//teste de criação e métodos
Console.WriteLine("Smartphone G60 (Nokia): \n");
Smartphone g60 = new Nokia(numero: "(99) 99999-9999", modelo: "Nokia G60", imei: "123456789012345", memoria: 128);
g60.Ligar();
g60.ReceberLigacao();
g60.InstalarAplicativo("Spotify");

Console.WriteLine("\n===============================");

Console.WriteLine("Smartphone I13 (Iphone): \n");
Smartphone i13 = new Iphone(numero: "(11) 11111-1111", modelo: "iPhone 13", imei: "246802468024680", memoria: 256);
i13.Ligar();
i13.ReceberLigacao();
i13.InstalarAplicativo("YouTube");

//teste de alteração e acesso a variáveis
Console.WriteLine("\n===============================");
Console.WriteLine($"Alterando telefone do {i13.Modelo}");
i13.numero = "(22) 22222-2222";
i13.toString();

Console.WriteLine("\n===============================");
Console.WriteLine($"Alterando telefone do {g60.Modelo}");
g60.numero = "(88) 88888-8888";
g60.toString();


