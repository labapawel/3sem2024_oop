using System;
using System.IO;

namespace app1 {

 public class Klasa1 : IDisposable {
    // pole publuczne
    public string test = "ala ma kota";
    // pole prywatne
    private uint _liczby = 255; 
    public string liczbabin { 
            get {
                // getter
                return Convert.ToString(_liczby,2);
            } set {
                   //setter
                   uint zm = 0;
                   if(uint.TryParse(value, out zm))
                        _liczby = zm;
                  } 
            }
    public string liczbahex { 
            get {
                // getter
                return Convert.ToString(_liczby,16);
            } set {
                   //setter
                   uint zm = 0;
                   if(uint.TryParse(value, out zm))
                        _liczby = zm;
                  } 
            }

    // metoda
    public void zmienTekst(string nowyTekst){
        this.test = nowyTekst;
    }

        public void Dispose()
        {
        Console.WriteLine("Zamykam instancje klasy Klasa1");
        
        }

        // konstruktor
        public Klasa1(){
        Console.WriteLine("Tworze instancje klasy Klasa1");
    }
    ~Klasa1(){
        Dispose();
    }
 }

}