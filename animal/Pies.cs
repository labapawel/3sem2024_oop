using Audio;
using Animal;

namespace Psy {
    
    public class Kundelek : AudioMP3, IAnimal {
        public void dajGlos() {
            Console.WriteLine("Piesek");
//http://xn--odgosy-5db.pl/piesek.php
            this.runMP3("piesek.mp3");
        }
    }
}