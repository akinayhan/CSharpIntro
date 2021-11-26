using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntro.Class
{
    class @namespace
    {
        //        NAMESPACE(İSİM ALANI)




        //İsim alanları yazılan programlarda mantıksal organizasyonu sağlar.Büyük projeler hiçbir zaman tek kişi tarafından yazılmaz.Bu projeler kısımlara ayrılır bu kısımlar da farklı kişilere verilir.Kişiler kendilerinden istenileni bitirdikten sonra bu parçalar birleştirilerek proje tamamlanır. Bu kişiler birbirinden bağımsız çalıştığından aynı isimli değişkenler veya metodlar kullanmış olabilirler. Böyle durumlarda proje birleştirildiğinde isim çakışmalarına sebebiyet verirdi. C#’ta bu isim çakışmasını engellemek için “namespace”ler (isim alanları) geliştirilmiştir. Bir namespace’yi projeye dahil etmenin iki yolu vardır. Bunlardan birincisi “using” kullanmaktır.

        //Örnek: “using System; “  Burada “system namespace” sini projemize dahil etmiş oluyoruz.

        //Bir namespace içinde başka bir namespace de olabilir.

        //Örneğin:“System.Data;”   Burada “system namespace” içinde “Data namespace”i vardır.Dolayısıyla bir namespace içinde classlarla birlikte başka namespace ler olabilir.

        //İkinci yol: Tam isim kullanmaktır.

        //Bir namespace şu şekilde tanımlanabilir. <0B=�X� V�X� V�T�� V�(� VY� V�X� V@�X� Vt"> 

        //namespace isim_alanı_adı

        //    {

        //        burada iki küme parantezi arasına başka bir namespace veya class lar getirebiliriz.

        //}







        //        // bu namespace içinde gorsel1 isimli bir class bulunmaktadır.

        //        // ornek namespace içindeki gorsel1 classından bir g nesnesi oluşturmuş olduk.

        //        // bu ikinci yola örnektir yani tam isim yazmaktır.

        //        // Bu şekilde tam isim yazmak istemiyorsak ornek namespaces ini projenin başına "using" ile ekleriz. ("using ornek")

        //        // Bu eklemeden sonra gorsel1 sınıfına erişmek için "using ornek"

        //        // Bu iki yolun birbirine göre avantajı vardır. Birinci yolu kullanarak isimlerde kısaltma yaparız. // Yani namespace i using ile yukarıya ekledikten sonra nesne oluştururken sınıf adını yazmak yeterli olur.

        //        // ikinci yolun avantajı ise şudur. farklı namespace ler içinde aynı isimli iki sınıf düşünelim.





        //        ornek1.gorsel1 g1 = new ornek.gorsel1();

        //        ornek2.gorsel2 g2 = new ornek.gorsel2();

        //            // bu şekilde bir kullanım hatalıdır. Çünkü hangi görsel sınıfından nesne oluşturacağını bilemez. Bu gibi durumlarda birinci yol kullanılmaz

        //            // ikinci yolu kullanmalıyız. Yani tam isim yazmalıyız.





        //using ornek1;

        //using ornek1;

        //gorsel g = new gorsel();

        //        // bu şekilde bir kullanım hatalıdır. Çünkü hangi görsel sınıfından nesne oluşturacağını bilemez. Bu gibi durumlarda birinci yol kullanılmaz

        //        // ikinci yolu kullanmalıyız. Yani tam isim yazmalıyız.




    }
}
