using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntro.Class
{
    class veriTurleri
    {
        //Float: 4 byte lık ondalıklı değişken üründür.Ondalıklı bir sayının sonuna küçük f veya büyük f getirilirse float anlamına gelir veya float türde işleme girer.
        //Double: 8 byte lık ondalıklı veri türüdür.Bir sayının sonuna herhangi bir şey getirmezsek veya “d” veya “D” koyarsak double türde işleme girer.
        //Decimal: 16 byte lık ondalıklı veri türüdür.Ondalıklı bir sayının sonuna küçük m veya büyük m koyarsak decimal türde işleme girer.

        //float a = 3.65f; //

        //float b = 3.65; //hatalıdır. double türdeki bir sayıyı float türündeki bir değişkene bu şekilde atayamayız.

        //double c = 3.65f; //bu satırda sıkıntı yoktur. Çünkü küçük türde olan float büyük türden olan double a atanabilir.

        //     Küçük tür büyük türe atanabilir ancak büyük tür küçük türe bu şekilde atanamaz.

        //     İki byte türden değişken ile işlem yapıp bir byte türden değişkene atamaya izin verilmemiş.

        //     Byte türden bir değişkenin alabileceği değerler küçük değerler olduğundan işlem yapılıp byte türden bir değişkene atama yapılacağı zaman sınırların aşılabileceği düşünülmüştür.


        //Bool Veri Türü : Mantıksal değişken türüdür.Alabileceği değerler true veya false dir.

        //Char Veri Türü : 16 bit uzunluğunda evrensel bir karakter kod olan unicode standartlarındaki karakterleri temsil etmek için kullanılır.


        //char a = 'A';

        //char b = (char)45;

        //char c = '\u0061';

        //label1.Text=b.ToString();

        //Referans tipler


        //String veri türü : Unicode karakterlerin bir dizisi olarak düşünülebilir.String türde bir değişken şu şekilde tanımlanabilir.

        //string x = "ali;"

        //char y = 'a';


        //bir string de özel karakter kullanmadığımızı belirtmek için @ veya \\ kullanılır.

        //string d = @"c:\okul\ornek.doc";

        //string d = "c:\\nokul\\ornek.doc";



        // Object veri türü : C# ta bütün veri türlerinin gizli olarak türediği veri türüdür. Her nesne bir object olduğu için bütün değerler ve nesneler object türünden bir değişkene atanabilir. Nesnelerin object türüne dönüştürülmesine boxing denir.

        //object a;

        //a = 1;

        //a = 4.8;
    }
}
