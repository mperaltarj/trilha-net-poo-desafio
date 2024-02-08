using DesafioPOO.Models;





Console.WriteLine("Smartfone Nokia: ");
Nokia n = new Nokia("(21)98225-6936", "Nokia Tijolo", "MAR8745", 32);
n.Ligar();
n.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartfone Iphone: ");
Iphone i = new Iphone("(21)98225-6930", "Iphone 12", "MAR8743", 64);
i.ReceberLigacao();
i.InstalarAplicativo("Telegram");