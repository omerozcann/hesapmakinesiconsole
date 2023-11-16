using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesapmakinesi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ihtiyaç
            //1-)Temel dört işlem
            //2-)Karekök
            //3-)Üs alma işlemi

            //İşleyiş
            //İşlem türlerini listele ve seçmesini iste, işlem türüne göre sayı ya da sayıları iste
            //seçilen işlemi sayılara uygula ve sonucu göster
            Double s1, s2,islem;
            Hesap hsp= new Hesap();
            Console.WriteLine("Toplama için 1 girin:");
            Console.WriteLine("Çıkarma için 2 girin:");
            Console.WriteLine("Çarpma için 3 girin:");
            Console.WriteLine("Bölme için 4 girin:");
            Console.WriteLine("Karekök için 5 girin:");
            Console.WriteLine("Üs Alma için 6 girin:");
            islem = Convert.ToDouble(Console.ReadLine());
            if(islem<5)
            {
                Console.WriteLine("1. Sayıyı Gir:");
                s1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("2. Sayıyı Gir:");
                s2 = Convert.ToDouble(Console.ReadLine());
                if(islem==1)
                {
                    Double sonuc = hsp.Topla(s1, s2);
                    Console.WriteLine(sonuc);
                }else if(islem==2)
                {
                    Double sonuc = hsp.Cikar(s1, s2);
                    Console.WriteLine(sonuc);
                }
                else if (islem == 3)
                {
                    Double sonuc = hsp.Carp(s1, s2);    
                    Console.WriteLine(sonuc);
                }
                else if (islem == 4)
                {
                    Double sonuc = hsp.Bol(s1, s2);
                    Console.WriteLine(sonuc);
                }
            }
            else if(islem ==5)
            {
                Console.WriteLine("Karekökü Alınacak Sayıyı Gir:");
                s1 = Convert.ToDouble(Console.ReadLine());
                Double sonuc = hsp.Karekok(s1);
                Console.WriteLine(sonuc);
            }
            else
            {
                Console.WriteLine("Taban Gir:");
                s1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Üs Gir:");
                s2 = Convert.ToDouble(Console.ReadLine());
                Double sonuc = hsp.UsAl(s1, s2);
                Console.WriteLine(sonuc);
            }
            
            
        }
    }
}
