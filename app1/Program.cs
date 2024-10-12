
using app1;

var k1 = new Klasa1(); 
Klasa1 k2 = new Klasa1(); 
k2.zmienTekst("Ali kotek znikł");

k1.liczbabin="akak255";
//k1._liczby = 123;
Console.WriteLine(k1.liczbahex);
Console.WriteLine(k1.liczbabin);


Console.WriteLine(k1.test);
Console.WriteLine(k2.test);
Console.WriteLine(k1.test);

using( Klasa1 k = new Klasa1()){
    
}

Klasa2 kx = new Klasa2();
kx.zapiszimienazwisko("Jan Kowalski");
Console.WriteLine(kx.czytajimienazwisko());
