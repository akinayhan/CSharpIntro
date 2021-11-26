using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntro.Class
{
    class switchCase
    {
        //Switch deyimi


        //Switch deyimi genellikle kompleks if else bloklarının yerine tercih edilir.Bir switch yapısında “break case , switch , goto” anahtar sözcüklerini kullanabiliriz.


        //Switch yapısını şöyle kullanabiliriz.


        //Switch (ifade)

        //Case sabit1:

        //Deyim1;

        //        Break;

        //Case sabit2:

        //Deyim2;

        //Break;

        //…

        //Default:

        //Deyim2;

        //Break;



        //İfade sabit 1 e eşit ise deyim 1 yapılır ve break ten dolayı switch yapısından çıkılır

        //İfade sabit 1 e eşit değil ise sabit 2 ye bakılır.İfade eğer 2 ye eşit ise breakten dolayı switch yapısından çıkılır.




        //Bu şekilde tüm durumlara bakılır.İfade durumlardan herhangi birine eşit değil ise default kısmı yapılır.

        //Switch yapısında default kullanmak durumunda değiliz ayrıca default kullanıyorsak en sonda olması gerekmez.


        //Örnek:

        //            int sayi = 3;

        //            switch (sayi)

        //            {

        //                case 1:

        //                label4.Text = "sayi 1 dir";

        //                break; //eğer bu break olmaz ise bir durumdan diğer duruma geçtiğimizi düşünüp derleyici hata verecektir. Dolayısı ile case lerde break kullanmak zorundayız. Bir case yapısından diğer case yapısına geçmek istiyorsak bunu goto ile yapabiliriz.

        //                case 2:

        //                label4.Text = "sayi 2 dir";

        //                break;

        //                case 4:

        //                label4.Text = "sayi 3 dür";

        //                break;

        //                default:

        //                label4.Text = "sayi 1,2,4 değildir";

        //                break;

        //            }



        //    int sayi = 3;

        //            switch (sayi)

        //            {

        //                case 1: //

        //                case 2: //

        //                label4.Text = "sayi 1 ve ya 2 dir";

        //                break;

        //                case 4:

        //                label4.Text = "sayi 3 dür";

        //                break;

        //                default:

        //                label4.Text = "sayi 1,2,4 değildir";

        //            }
    }
}
