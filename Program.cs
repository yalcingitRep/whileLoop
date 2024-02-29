using System;
namespace whileLoop{
    class Program{
        public static void Main(string[] args){
            // while
            int sayi = int.Parse(Console.ReadLine()); 
            int sayac = 1;
            int toplam = 0;
            while(sayac <=sayi){
                toplam +=sayac;
                sayac++;
            }
            Console.WriteLine("Sonuc : " + toplam/sayi);
            char charecter = 'a';
            while(charecter<= 'z'){
                Console.WriteLine(charecter);
                charecter++;
            }
            // foreach
            string [] arabalar = {"BMV","Ford","Toyota","Nissan"};
            foreach(var araba in arabalar){
                Console.WriteLine(araba);
            }
        }
        
    }
}