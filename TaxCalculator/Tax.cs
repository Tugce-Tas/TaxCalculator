namespace TaxCalculator;

public class Tax
{
    public void Taxes() {
        double fiyat, kdv, kdvFiyat, total;
 	
        Console.Write("Fiyat giriniz: ");
        fiyat =Convert.ToInt16(Console.ReadLine());
	
        kdv = (fiyat > 1000) ? 0.08 : 0.18 ;
        kdvFiyat = fiyat*kdv;
        total = fiyat+kdvFiyat;
	
        Console.WriteLine("KDV Oranı: " + kdv);
        Console.WriteLine("KDV Fiyatı: " + kdvFiyat);
        Console.WriteLine("KDV'li Toplam Fiyat: " + total);
    }

}