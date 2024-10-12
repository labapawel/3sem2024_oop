using System;

namespace app1
{
    
    public class Klasa2 {
        private string imienazwisko="";

        public string czytajimienazwisko(){
            return imienazwisko;
        }
        public void zapiszimienazwisko(string im){
            imienazwisko = im;
        }
    }
}