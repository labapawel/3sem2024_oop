using Audio;
using Animal;

namespace Koty {
    
    public class Dachowiec : AudioMP3, IAnimal {
        public void dajGlos() {
            Console.WriteLine("Kotek");
            //http://xn--odgosy-5db.pl/kot01.php
            this.runMP3("kot01.mp3");
        }
    }
}