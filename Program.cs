using System;

namespace Extension_Rekorsif_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif fonksiyonlar- Kendi kendini çağıran fonksiyonlar.

            int result=1;
            for (int i = 1; i <= 4; i++)
            {
                result = result*3;
                Console.WriteLine(result);

                Islemler instance = new();
                Console.WriteLine(instance.Ussu(3,4));
                

                //Extension Metotlar
                string ifade ="Ders çalışmaya devam.";
                Console.WriteLine(ifade.CheckSpaces());



            }
        }
    }

    public class Islemler{

        public int Ussu(int sayi, int us) 
            {
                if(us<2)
                    return sayi;
                return Ussu(sayi,us-1)*sayi;
            }
       
       
        }
 
    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
           return param.Contains(" ");
        }




    }
}
