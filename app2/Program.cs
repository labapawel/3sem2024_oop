using app1;

/**
    mies 80+m rok = 1800-1899
    mies 60+m rok = 2200-2299
    mies 40+m rok = 2100-2199
    mies 20+m rok = 2000-2099
    mies 0+m rok = 1900-1999
*/


Klasa3 k = new Klasa3();
k.Klasa.inne = 20;

k.imie = "pAWEł";

Console.WriteLine(k.Klasa.inne);
Console.WriteLine(k.dane);

Pesel p = new Pesel();
p.pesel = "22810128916"; 



Console.WriteLine(" pesel: {0} płeć: {1} Data ur {2:yyyy-MM-dd} {3}",  p.pesel, p.plec, p.dataur, p.generator(new DateTime(1822,1,1),Plec.M));
