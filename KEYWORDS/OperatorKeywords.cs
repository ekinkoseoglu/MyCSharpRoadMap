using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEYWORDS
{
    class OperatorKeywords
    {
        public static void Main2(string[] args)
        {
            // OPERATOR KEYWORDS
            // Operatör anahtar sözcükleri çeşitli eylemler gerçekleştirir.


            // 1) is Keyyword

            //  Is anahtar sözcüğü bir nesnenin başka bir nesne türüne dönüştürmenin uyumluluğunu kontrol eder ve boolean türünde geriye değer döner. 
            //Dönüştürme uyumlu ise true, değilse false olarak geriye döner.
            //Çalışma zamanında nesnelerin uyumluluğu kontrol edilmesine olanak sağlar ve oluşabilecek özel durumların önüne geçilmesi için faydalanılır.

            int i = 5;

            if (i is int)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            if (i is string)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Console.WriteLine("-----------");
            Console.WriteLine(i is object);
            Console.WriteLine(i is string);
            Console.WriteLine(i is object);
            Console.WriteLine(i is long);
            Console.WriteLine(i is double);
            Console.WriteLine(i is ValueType);
            Console.WriteLine(i is int);

            //Output: true false ----------- True False True False False True True

            // 2) AS Keyword

            //As anahtar sözcüğü bir türden diğer bir türe dönüşüm için kullanılır. belirli türdeki veri tipleri ile dönüştürme gerçekleştirebilir.  int, double, char, bool gibi veri türlerinin dönüşümü sağlanamaz.    Ayrıca nesne türünün başka bir nesne türü ile uyumluluğunu kontro etmek için kullanılır. Nesne türü uyumlu ise nesne türünün değer tipini geriye döner. Nesne türü uyumlu değilse dönüştürme yapılamaz ve geriye null değer döner.

            object deger = "Hello";
            string metin = deger as string;
            Console.WriteLine(metin);
            Console.WriteLine(metin.GetType());
            Console.ReadLine();

            // Output : Hello System.String


            // 3)  SizeOf Keyword

            // sizeof keyword'u, verilen türdeki bir değişken tarafından bulunan bayt sayısını returnler. İşlecin bağımsız değişkeni, yönetilmeyen bir sizeof türün veya yönetilmeyen tür olarak Kısıtlanmış bir tür parametresinin adı olmalıdır.

            //sizeof(sbyte)	1
            //sizeof(byte)    1
            //sizeof(short)   2
            //sizeof(ushort)  2
            //sizeof(int)     4
            //sizeof(uint)    4
            //sizeof(long)    8
            //sizeof(ulong)   8
            //sizeof(char)    2
            //sizeof(float)   4
            //sizeof(double)  8
            //sizeof(decimal) 16

            Console.WriteLine("sizeof(double)   : {0}", sizeof(double));
            Console.WriteLine("sizeof(int)      : {0}", sizeof(int));
            Console.WriteLine("sizeof(bool)     : {0}", sizeof(bool));
            Console.WriteLine("sizeof(short)    : {0}", sizeof(short));
            int x = sizeof(int);
            Console.WriteLine(x);
            // Output
            //sizeof(double)   : 8
            //sizeof(int)      : 4
            //sizeof(bool)     : 1
            //sizeof(short)    : 2
            //4


            // 4 TypeOf KEYWORD

            //typeof bir keyword dür. .net içindeki nesnelerin Type(Tipi verir)

            //mesela int bir value type dir(değer tipi)

            //geriye Type classını döndürür.

            //kullanımı şu şekildedir.

            Type t = typeof(int);

            //şunla aynı görevi görür:
            int q = new int();
            Type tip = q.GetType();

            //Arasındaki fark birisi bellekte bir instacne oluşturur ve içinci bir tanımlamayla tekrar bir instance oluştur. (ikinci örnek)

            //birisi direk tipini alır ve tek bir instance ile işi bitirir(birinci örnek)

            //typeof daha çok nesnenin içindeki methodları, fieldları, propertiesleri, erişim bilgilerini(access modifiers), kimden türediğini kök tipin ne olduğunu vb bilgileri verir.

            //            Çoğunlukla runtime(çalışırken) anında bir nesnenin kod ile tekrar yaratılmasını yada içindeki verilerin oynanmasını - değiştirmesini sağlar.

            //başlangıç ve orta düzey bir programlama değil ileri düzey bir programlamadır.Daha çok ileri düzey programlamada kullanırılır.

            //Mesela örnek:

            List<Type> list = new List<Type>();

            list.Add(typeof(int));
            list.Add(typeof(bool));
            list.Add(typeof(string));

            //bunları eklersin ve bu tiplerin içindeki verileri alırsın.


            // 5     New KEYWORD

            // New deyimi nesneleri oluşturmak için kullanılır. Ayrıca anonim tiplerin oluşturulmasında da kullanılır. Oluşturulan nesnelere değer atanması zorunlu değildir. İstenildiği taktirde oluşturulan nesnelere değerler atanabilir. Değer atanmadığı taktirde varsayılan nesne tipinde nesne oluşur.

            // Başka bir katmanda belirli özelliklere ya da fonksiyonlara sahip olan bir class oluşturdukduktan sonra Main cs'niz içinde o class'ı tanımlamak için "New" keyworduyle class'ın instance'sini alıyoruz

            // New deyimi, nesneleri oluşturmak yada daha önceden oluşturulmuş olan nesneleri çağırmak için kullanılır. int türünde value değişkeni oluşturduk. int türünde oluşturduğumuz değişkenin varsayılan değeri sıfır olarak atanır.

            int value = new int();
            Console.WriteLine("value: " + value); // Output: value: 0
        }


    }
}
