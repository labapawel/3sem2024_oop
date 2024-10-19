
using System.Runtime.CompilerServices;

namespace app1 {
public enum Plec {M, K};
public class Pesel {
    private string _pesel = "";
    public string pesel {
        set => WpiszPesel(value);
        get => czytajPesel();
    }

    public string plec {
        get { 
            if(!valid) return "----";
            return (int.Parse(_pesel[9].ToString()) % 2 == 0) ? "Kobieta" : "Facet";
        }
    }

    public string generator(DateTime? data = null, Plec plec = Plec.K, int? num = null)
    {
        if(data == null){
            data = DateTime.Now;
        }
        if(num == null)
        {
            Random rnd = new Random();
            num = rnd.Next(0,9999);
            if(plec == Plec.K && ((num % 2)== 1) ) num++;
            else 
            if(plec == Plec.M && ((num % 2)== 0) ) num++; 
        }
        int r = data.Value.Year;
        int m = data.Value.Month;
        int d = data.Value.Day;
        if(r >= 2200) { m+=60; r-=2200; } else
        if(r >= 2100) { m+=40; r-=2100; } else
        if(r >= 2000) { m+=20; r-=2000; } else
        if(r >= 1900) { r -= 1900; }
        else { m+=80; r -= 1800; }

        string pesel = r.ToString("D2") + m.ToString("D2") + d.ToString("D2") + num.Value.ToString("D4");

        int[] wagi = {9,7,3,1,9,7,3,1,9,7};
        int suma =0;
        for(int i=0; i<10; i++)
            suma += int.Parse(pesel[i].ToString()) * wagi[i];

        pesel += suma % 10;


        return pesel;
    }

    public DateTime? dataur {
        get {
            if(!valid) return null;
            int rok = int.Parse(_pesel.Substring(0,2));
            int mies = int.Parse(_pesel.Substring(2,2));
            int dzien = int.Parse(_pesel.Substring(4,2));

            if(mies>80){
                rok += 1800;
                mies -= 80;
            } else
            if(mies>60){
                rok += 2200;
                mies -= 60;
            } else
            if(mies>40){
                rok += 2100;
                mies -= 40;
            } else
            if(mies>20){
                rok += 2000;
                mies -= 20;
            } else rok += 1900;


          return new DateTime(rok, mies, dzien);
        }
    }

    private int sumaKontrolna = 0;
    private bool valid = false;
    private void WpiszPesel(string val){
        // 22222222222
        if(val == "00000000000" || val.Length != 11) return;
        int[] wagi = {9,7,3,1,9,7,3,1,9,7};
        int suma =0;
        for(int i=0; i<10; i++)
            suma += int.Parse(val[i].ToString()) * wagi[i];

        sumaKontrolna = suma % 10;
      
        valid = sumaKontrolna == int.Parse(val[10].ToString());
        if(valid)
            _pesel = val;
    }
    private string czytajPesel(){ 
        return this._pesel;
    }

}
}
