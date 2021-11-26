using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntro.Class
{
    class @checked
    {
        //        Checked - unchecked


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
