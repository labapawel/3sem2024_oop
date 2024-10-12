
namespace app1 {
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