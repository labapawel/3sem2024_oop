using adresacjaIP;

IP ip = new IP("192.168.0.1",(byte)6); // 255.255.0.0


string Adres = $"Adres IP: \t\t {ip.uint2bin(ip.ip, (byte)ip.wielkoscMaski())} -  {ip.uint2IPv4(ip.ip)} "; 
Console.WriteLine(Adres);
Adres = $"Maska: \t\t\t {ip.uint2bin(ip.maska, (byte)ip.wielkoscMaski())} -  {ip.uint2IPv4(ip.maska)} "; 
Console.WriteLine(Adres);
Adres = $"Adres sieci: \t\t {ip.uint2bin(ip.adresSieci(), (byte)ip.wielkoscMaski())} -  {ip.uint2IPv4(ip.adresSieci())} "; 
Console.WriteLine(Adres);
Adres = $"Adres rozgłoszeniowy: \t {ip.uint2bin(ip.adresRozgloszeniowy(), (byte)ip.wielkoscMaski())} -  {ip.uint2IPv4(ip.adresRozgloszeniowy())} "; 
Console.WriteLine(Adres);
Adres = $"Minimalny host: \t {ip.uint2bin(ip.pierwszyHost(), (byte)ip.wielkoscMaski())} -  {ip.uint2IPv4(ip.pierwszyHost())} "; 
Console.WriteLine(Adres);
Adres = $"Maksymalny host: \t {ip.uint2bin(ip.ostatniHost(), (byte)ip.wielkoscMaski())} -  {ip.uint2IPv4(ip.ostatniHost())} "; 
Console.WriteLine(Adres);
Console.WriteLine($"Adresów w sieci: {ip.ileHostow()}");


