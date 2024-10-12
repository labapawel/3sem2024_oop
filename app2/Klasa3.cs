/**
    Settery Getter
*/
using System;
using System.IO;

namespace app1 {

 // public private protected
 public class inna {
    public int inne = 10;
 }
 public class Klasa3 {
    public readonly inna Klasa = new inna(); // nie można zmienić na inną instancje ale można zmienić zawartość
    public readonly int dane = 10; // można tylko odczytać

    public Klasa3(){
        dane = 30; // wew. klasy(konstruktora) można modyfikować pola readonly
        Klasa = new inna();
    }

    private string _imie = ""; // 
    public string imie { set {
           var str = value.Substring(0,1).ToUpper();
            _imie = str + value.Substring(1).ToLower();
    }
        get => _imie;
    }
 }

}
