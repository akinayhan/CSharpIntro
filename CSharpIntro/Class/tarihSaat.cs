using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntro.Class
{
    class tarihSaat
    {
        //        C#ta tarih ve saat işlemleri system isim alanında bulunan “DateTime” ve “TimeSpan” ile gerçekleştirilir. DateTime yapısı gün ay yıl saat dakika ve saniye gibi bilgileri tutmak için kullanılır. TimeSpan ise iki tarih arasındaki farkı temsil etmek için kullanılır. DateTime yapısının bazı özellikleri şunlardır;

        //Date: Datetime nesnesine ilişkin saat dışındaki bilgiyi verir.
        //Month: Datetime nesnesinin ay bilgisini int türde verir.
        //Day: Datetime nesnesinin gün bilgisini int türde verir.
        //Year: Datetime nesnesinin yıl bilgisini int türde verir.
        //Dayofweek:DateTime nesnesinin haftanın kaçıncı günü olduğunu verir.
        //Dayofyear:DateTime nesnesinin yılın kaçıncı günü olduğunu verir.
        //Timeofday: saat 00:00 dan itibaren ne kadar zaman geçtiğinin TimeSpan nesnesi olarak verir.
        //Hour:DateTime nesnesinin saat türünü int türünde verir.
        //Minute:DateTime nesnesinin dakika türünü int türünde verir.
        //Second:DateTime nesnesinin saniye türünü int türünde verir.




        //Örnek:Bir kullanıcının doğum tarihinden bu güne kadar geçen gün sayısını ve doğduğu günü bulan bir visual c# programı yazınız.






        //            int y, a, g;

        //        y = Convert.ToInt32(textBox1.Text);

        //            a = Convert.ToInt32(textBox2.Text);

        //            g = Convert.ToInt32(textBox3.Text);

        //            DateTime bugün = DateTime.Today;

        //        DateTime dt = new DateTime(y, a, g);

        //        TimeSpan fark = bugün - dt;

        //        label4.Text = "Doğduğunuz gün:" + dt.DayOfWeek;

        //            label5.Text = "Geçen gün sayısı:" + fark.Days;



        //Örnek: Belirtilen gün kadar sonrasının hangi güne denk geldiğini bulan bir visual c# programı yazınız.




        //            int gs;

        //        gs = Convert.ToInt32(textBox1.Text);

        //            TimeSpan fark = new TimeSpan(gs, 0, 0, 0, 0);

        //        DateTime dt = DateTime.Today + fark;

        //        label4.Text = dt.DayOfWeek.ToString();



        //Örnek: Verilen iki tarih arasında geçen hafta sonu günlerinin sayısını bulan bir visual c# programı yazınız.

        //            DateTime t1 = new DateTime(2015,5,1);

        //        DateTime t2 = new DateTime(2016, 5, 1);

        //        TimeSpan fark = t2 - t1;

        //        long hss = 0;

        //        DateTime gecici;

        //            for (int i = 1; i <= fark.Days; i++)

        //            {

        //                gecici = t1.AddDays(i);

        //                if (gecici.DayOfWeek == DayOfWeek.Sunday || gecici.DayOfWeek == DayOfWeek.Saturday)

        //                    hss++;

        //                label4.Text = "Gün sayısı:" + hss;
    }
}
