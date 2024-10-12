using app1;

Klasa3 k = new Klasa3();
k.Klasa.inne = 20;

k.imie = "pAWEł";

Console.WriteLine(k.Klasa.inne);
Console.WriteLine(k.dane);

Pesel p = new Pesel();
p.pesel = "22222222222";


Console.WriteLine(" pesel: {0} płeć: {1}",  p.pesel, p.plec);
