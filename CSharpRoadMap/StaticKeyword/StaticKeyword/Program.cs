using System;
using System.Runtime.CompilerServices;

namespace StaticKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Bir üyenin static olması demek; o üyeye erişimin, SınıfAdi.UyeAdi olarak yapılabilmesi anlamına gelmektedir. Bir üyenin non-static olması demek; o üyeye ancak ve ancak, tanımlandığı sınıfa ait bir nesne örneği üzerinden erişebilmemiz anlamına gelir.

            // ÖNEMLİ NOT: Static, bir erişim belirleyici değildir!

            // Eğer static anahtar sözcüğü yazılmamışsa, o Method non -static demektir. Bir Methodun non - static olması demek methoda ulaşmak için özellik barındıran class'lardan birinin üyesini kullanarak methoda ulaşabilme zorunluluğunda olmak demek. 

            // En basitce anlatacak olursak; Static methodun herkes için geçerli bir fonksiyonu varsa o fonksiyonu kullanacağımız her üye için teker teker yazarak tanımlamak yerine, bütün o üyelerin üyesi olduğu ana Class'ı o methoda bağlamak demektir.

            // %18 kdv sadece araba markaları olan marka1, marka2... için değil bütün ARABA sınıfının üyelerine uygulanan bir şey, o yüzden kdv hesaplaması yapan bir fonksiyonu static olarak tanımlamayarak her marka için teker teker "marka1.kdv(), marka1.kdv()" yazmak yerine kdv methodunu static olarak tanımlayarak direkt ARABA.kdv(); yazarız böylece bütün üyelere kdv methodu otomatik olarak uygulanmış olur.

            // Bir alan(field); o sınıfa ait her bir nesne örneği için özel bir alan ise, non-static olarak tanımlanmalıdır. Eğer her nesne örneği için ortak bir alan ise static olarak tanımlanmalıdır.
            Urun.KdvOran = 0.18;
            Urun urun1 = new Urun();
            urun1.Ad = "Kalem";
            urun1.Fiyat = 10;
            urun1.Id = 1;
            

            Urun urun2 = new Urun();
            urun2.Ad = "Defter";
            urun2.Fiyat = 20;
            urun2.Id = 2;

            Urun.KdvOran = 0.18;// KdvOran'ı static olarak tanımladığımız için sadece urun1 ya da urun2 değil bütün ürünlerin ortak KdvOran'ı haline getirdik böylece her bir üründe teker teker urun1.KdvOran, urun2.KdvOran,........   olarak tanımlamayacagız 

            

            Urun.ZamYapStatik(urun2,0.2);
            Console.WriteLine(urun2.Fiyat);// Program tarafında static metodun çağırılması da şu şekilde olur;
            urun1.ZamYapNonStatik(0.50); // Şimdi program tarafında 2. yani Non-Static metodun çağırılmasına bakalım;
            Console.WriteLine(urun1.Fiyat);

            // Metodun 2. haliyle, daha doğru bir kodlama yaptığımızı görmek mümkün.artık her Urun nesnesi için özel bir iş yapan ZamYap metodu, hangi nesne için çağırılıyorsa o nesne üzerinden çalışmaktadır.

            Urun.KdvOranDegisti(0.20);

        }

        public class Urun
        {
            public string Ad;
            public double Fiyat;
            public int Id;
            public static double KdvOran;

            // Urun sınıfımıza ZamYap adlı bir metot eklemek istiyoruz. Metot geriye değer dönmesin ve parametre olarak yapılacak zam oranını alsın. Bu noktada düşünmemiz gereken ilk nokta şu olmalı, static mi non-static mi? Aslında bu metot hem static hem de non-static olarak yazılabilir. Ancak hangisinin daha doğru olduğuna, ikisini de deneyerek karar verelim.



            // İlk olarak Urun sınıfı içine static olarak ZamYap metodunu tanımlayalım. Metodu Urun sınıfının içine yazmamızın sebebi, yapılan işin Urun nesnelerinin işleri olmasıdır. Yani bu metodu Program sınıfının içine yazmak anlamsız olacaktır. Urun sınıfının içindeki ZamYap metodunun kodları aşağıdaki gibidir;
            public static void ZamYapStatik(Urun u, double ZamOran)  //Dikkat ederseniz, metoda Urun tipinden bir parametre ilave edilmiş durumda. Bunun nedeni gayet basit; metot static olduğundan dolayı, erişim Urun.ZamYap şeklinde yapılmalıdır. Peki bu metot hangi ürün nesnesi için çalışığını nereden bilecek? İşte bu yüzden Urun tipinden bir parametre vermek zorundayız ki, hangi ürünün fiyatına zam yapacağını belirtebilelim.
            {
                u.Fiyat += u.Fiyat * ZamOran;
            }

           // Peki bu doğru bir kodlama oldu mu dersiniz? İşte bu noktada düşünmemiz gereken en önemli nokta şu olmalı; bu metot her Urun nesnesi için özel bir iş mi yapmaktadır, yoksa genel bir iş mi yapmaktadır? Cevap ortadadır, bu metot her ürün nesnesi için özel bir iş yapmaktadır.Yani hangi ürün için çağırılırsa, o ürün için özel olan “Fiyat” alanını kullanarak o ürünün fiyatına zam yapmaktadır.İşte bu yüzden yukarıdaki kodlama, istediğimiz sonucu almamıza rağmen doğru bir kodlama değildir.Bu metot her nesne için özel bir iş yaptığından dolayı non-static olarak tanımlanmalıdır.
            public void ZamYapNonStatik(double ZamOran) //Dikkat ederseniz static olarak tanımlanan metotta olan Urun parametresine artık gerek kalmadı. Çünkü metot non-static olduğundan dolayı, bir Urun sınıfı nesnesi üzerinden çağırılmak zorundadır. Bir diğer çok önemli nokta; metodun içerisinde, direkt “Fiyat” diyerek eriştiğim alan, metot hangi nesne için iş yapıyorsa o nesnenin “Fiyat” alanıdır. Metoda urun1.ZamYap diyerek erişeceğimden dolayı, metodun içerisindeki "Fiyat" alanı, urun1'in fiyat alanıdır.
            {
                Fiyat += Fiyat * ZamOran; // Fiyat = urun(kaçsa artık numarası).Fiyat


            }
            // Buradan şöyle bir sonuca varmak mümkündür; bir sınıf içerisindeki non-static metotlar, o sınıfa ait non -static veya static alanları direkt olarak kullanabilirler. Ancak bir sınıf içerisindeki static metotlar , yalnızca o sınıfa ait static alanları kullanabilirler.
            public static void KdvOranDegisti(double yeniKdvOran)
            {
                KdvOran = yeniKdvOran;
            }

            
        }
    }
}
