using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntro.Class
{
    class turDonusumleri
    {
        //Tür Dönüşümü : Bazı durumlarda tanımladığımız değişkenlerin farklı bir türdenmiş gibi davranmasını isteyebiliriz0B=iU0B=iU���

        //Örneğin short türden bir değişken ile long türden bir değişken toplanmak istenebilir.Normal şartlarda farklı türlerde nesnelerin herhangi bir aritmetik işleme sokulması çok özel durumlar dışında mümkün değildir.Bu yüzden farklı türden iki değişken toplanırken veya çarpılırken geçici olarak tür dönüşümünden faydalanılır. Genelde küçük türlerin büyük türlere dönüştürülmesinde sıkıntı yoktur fakat büyük türlerin küçük türlere dönüştürülmesi her zaman mümkün değildir.




        //Tür dönüşümü bilinçli ve bilinçsiz olmak üzere ikiye ayrılır.



        //Bilinçsiz Tür dönüşümü



        //Bir türün başka bir türe bilinçsizce dönüştürülmesidir. Bu işlem bilinçsiz yapıldığından küçük türün büyük türe dönüşümüne izin verilir, fakat büyük türün küçük türe bilinçsizce dönüştürülmesine izin verilmez.Bunun sebebi veri kaybını engellemektir.




        //      int a = 5;

        //        byte c = 6;

        //        c = a;  // yanlıştır. Çünkü büyük tür küçük türe bu şekilde dönüştürülemez.

        //a = c;  // doğrudur. çünkü küçük tür büyük türe bu şekilde bilinçsizce dönüştürülebilir.



        //Bilinçli Tür Dönüşümü



        //Genellikle derleyicinin izin vermediği durumlarda kullanılır.Programın anlaşılabilirliğini arttırmak için tüm tür dönüşümlerinden bilinçli tür dönüşümü kullanılabilir.Bilinçli tür dönüşümü operatörü “ () “ ile yapılır.



        //Bilinçli tür dönüşümü


        //byte a = 45;

        //        int b = (int)a; //burada byte olan a değişkenini geçici olarak int e dönüştürüp int olan b değişkenine atanmıştır

        //        label1.Text = b.ToString();



        //// bu işlemi bilinçsiz olarakta yapabilirdik

        //Bilinçsiz tür dönüşümü

        //byte a = 45;

        //        int b = a;

        //        label1.Text = b.ToString();



        //   byte a = 34;

        //        int b = 12;

        //        a = b;

        //   //hatalı kullanım vardır.burada büyük tür küçük türe dönüştürülemez.

        //   //fakat şu şekilde bilinçli olarak yapabiliriz.

        //   byte a = 34;

        //        int b = 12;

        //        a = (byte) b; //burada int türde olan b değişkeni geçici olarak byte türe dönüştürülüp byte olan a değişkenine atanmıştır. Bu işlem bilinçli olarak yapıldığı için derleyici veri kaybı olsa bile bizi uyarmayacaktır.



        //        Bilinçli tür dönüşümünde veri kaybı olsa bile derleyici bizi uyarmadığından dikkatli olmamız gerekir.

        //        Veri kaybına bir örnek şu şekilde verebiliriz.




        //    int a = 256;

        //        byte b = (byte)a;

        //        label1.Text = b.ToString();



        //İnt türden değişkenin bellekte gösterimi



        //xxxxxxxx xxxxxxxx xxxxxxxx xxxxxxxx





        //Byte türden değişkenin bellekte gösterimi




        //xxxxxxxx



        //256



        //00000000 00000000 00000000 00000000


        //Checked - unchecked



        //Bilinçli tür dönüşümünde derleyici veri kaybı olsa bile bizi uyarmamaktadır.Bunun sebebi dönüşümü bilerek yaptığımızı düşünmesinden kaynaklanmaktadır. Bu yüzden bilinçli tür dönüşümü yaparken eğer veri kaybı olacak ise derleyicinin bizi uyarması için bu tür dönüşümü “checked” bloğu içinde yazılır.Checked bloğu içinde bazı  tür dönüşümleri için yine bizi uyarmasını istemiyorsak checked bloğu içinde unchecked bloğu kullanırız.




        //    int a = 258;

        //        byte b;

        //        byte c;

        //    checked

        //    {

        //    b=(byte) a;

        //    unchecked

        //    {

        //       c = (byte) a;

        //    }

        //}

        //label1.Text = b.ToString();


        //label1.Text = b.ToString();

        //label1.Text = Convert.ToString(b);


        //İKİ SATIR DA AYNI

        //int abc = int.Parse(textBox1.Text);

        //int ab = Convert.ToInt32(textBox1.Text);


        //İKİ SATIR DA AYNI
    }
}
