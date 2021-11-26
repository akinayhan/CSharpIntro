using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntro.Class
{
    class erisimBelirleyici
    {
        //        C# ta beş erişim belirleyici vardır.

        //Bunlar : public, private, protected, internal, protected internal



        //Private ile tanımlanan bir metoda sadece tanımlı olduğu sınıf içinden erişilebilir.

        //Public ile tanımlanan bir metoda ise tanımlı olduğu sınıf dışından da erişilebilir.



        //Metod içinde metod olmaz ancak metod içinden başka bir metod çağırılabilir.




        //                class ornek

        //        {

        //            private int a;

        //            private int b;

        //            public float ornek1(float x)

        //            {

        //                return x + x;

        //                public float ornek2(float x)

        //                {

        //                    return x * x;

        //                }

        //            }

        //            burada a ve b örnek sınıfının iki özelliğidir.Örnek 1 ve örnek 2 ise örnek sınıfına ait iki metoddur.


        //            Örnek 1 ve örnek2 metodları public erişim belirleyici ile tanımlandığından bu iki metoda örnek sınıfı

        //            dışından da erişebiliriz.a ve b özellikleri ise private olduğundan bu özelliklere örnek sınıfı dışından erişemeyiz.



        //          Bir sınıf türünde nesneyi şu şekilde tanımlayabiliriz.Sınıf türünde nesne oluştururken new anahtar sözcüğü kullanılır.Sınıf nesnelerinin bir değişken gibi düşünebiliriz.

        //                    //sınıf _adı nesne_adı

        //                    ornek orn;

        //            bu bildirim ile örnek sınıf türünden bir orn nesnesi bildiriliyor.

        //            Fakat bu bildirim ile üye elemanları bellekte tutmak için yer tahsis edilmemiştir.

        //            üye elamanlarının bellekte yer tahsili için new anahtar sözcüğünü kullanılır.



        //                       //sınıf _adı nesne_adı sınıf_adı();

        //                       ornek orn = new ornek();

        //            Oluşturduğumuz bu orn nesnesi ile örnek sınıfının public erişim belirleyicisi ile tanımlanmış özellik veya metodlarına erişebiliriz.



        //            Örnek sınıfının örnek1 metoduna erişmek için örnek sınıfında bir nesne oluşturulabilir.




        //            Birden fazla sınıf nesnesi tanımayabiliriz.

        //            ornek orn1 = new ornek();

        //            ornek orn2;





        //            ornek orn1 = new ornek();

        //            ornek orn2;

        //            orn1.a = 123;

        //            label1.Text = orn1.a.ToString();

        //            orn2 = orn1;

        //            label2.Text = orn2.a.ToString();

        //            orn2.a = 13;

        //            label3.Text = orn2.a.ToString();





        //  class ornek

        //            {

        //                public float a;

        //                public float ornek1(float a)

        //                {

        //                    this.a = a;

        //                    return a + a;

        //                }

        //            }







        //            Set ve get anahtar sözcüklerini kullanarak bir sınıfın private tanımlı özellik veya metodlarına erişebiliriz.Bu sayede bir sınıfın private tanımlı üye elemanlarının get sayesinde değer atanabilir, set sayesinde de değeri değiştirilebilir.

        //           Örnek:



        //    }

        //        class dortgen

        //        {

        //            private int mEn;

        //            private int mBoy;

        //            public int En

        //            {

        //                get { return mEn; }

        //                set { mEn = value; }

        //            }

        //            public int Boy

        //            {

        //                get { return mBoy; }

        //                set { mBoy = value; }

        //            }

        //            public int alan()

        //            {

        //                int alan = En * Boy;

        //                return alan;

        //            }

        //            public void enBoyBelirle(int en, int boy)

        //            {

        //                En = en;

        //                Boy = boy;

        //            }

        //            public void yaz();

        //    {

        //        MessageBox.Show("En="+En);

        //        MessageBox.Show("Boy="+Boy);

        //        MessageBox.Show("Alan="+alan());
    }
}
