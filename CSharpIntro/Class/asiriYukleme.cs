using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntro.Class
{
    class asiriYukleme
    {
        //        Metodların aşırı yüklenmesi



        //Bazen isimleri aynı birden fazla metod tanımlayabiliriz.Örneğin 2,3 ve 4 sayının toplamını bulmak için ismi topla olan tek bir metod tanımlayabiliriz.Bu tür bir metodu çağırdığımız zaman önce birebir uyuma bakılır. Eğer birebir uyum yoksa tür dönüşümlerinden faydalanılır.Çağırılan metod ile çağıran metodun parametre sayısı eşit ise sıkıntı yoktur.Eğer çağıran metodda int türde değişken var ve çağırılan metodda int türünde değişken var ise yine sıkıntı yoktur. Fakat çağırılan ve çağırılanda farklı türde değişken varsa en yakın uyuma bakılır.




        //ÖRNEK: ismi topla olan 3 metod tanımladığımızda burada topla metodu aşırı yüklenmiş bir metoddur.





        //label1.Text = topla(1, 4, 5).ToString();

        //        // burada ilk topla metodu çağırılır. (1,4)

        //        // burada birebir uyumdan dolayı ikinci topla metodu çağırılır (1,4,5)

        //        // burada birebir uyumdan dolayı üçüncü metod çağırılır. (1,4,5.0

        //        // 1) parametre sayısı

        //        // 2) parametrelerin aynı olması

        //        // 3) tür dönüşümü

        //    }

        //    double topla(int x, int y)

        //    {

        //        return x + y;

        //    }

        //    double topla(int x, int y, int z)

        //    {

        //        return x + y + z;

        //    }

        //    double topla(int x, int y, double z)

        //    {

        //        return x + y + z;


    }
}
