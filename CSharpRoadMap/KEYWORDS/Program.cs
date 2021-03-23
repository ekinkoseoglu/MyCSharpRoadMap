using System;

namespace KEYWORDS
{
    class Program : Book
    {
        static void Main(string[] args)
        {
            // Bu bölümde işinize en çok yarayacak ve C# Programlamanın temel toaşını oturtmanız için karşımıza sürekli çıkan keywordlerin hangilerinin ne anlama geldiğini ve ne işe yaradığını sınıflandırarak anlatmaya çalışacağım

            // ilk  Bölümde Access Modifiersları ve Hangisinin ne anlama geldiğini göreceğiz 

            // INTERNAL CLASS'LAR

            // Internal Class'lar sadece tanımlandıkları katmanlardan erişim sağlanması özelliğine sahiptirler. Tanımlı oldukları katmanların dışından hiçbir şekilde erişilemezler.
            BaseClass baseClass = new BaseClass();

            baseClass.Id = 105;
            baseClass.CreatedDate = DateTime.Now;
            baseClass.UserId = 5;

            Console.WriteLine(baseClass.Id);
            Console.WriteLine(baseClass.CreatedDate);
            Console.WriteLine(baseClass.UserId);



            Console.WriteLine("--------------------------------");

            // PRIVATE

            // Özel kısıtlamalar olduğunda kullanılır. Tanımlandığı class yada metotlara özeldir.
            // /Tanımlandıkları class ve metotların dışından erişilemez ve kullanılması mümkün olamaz.


            //  PUBLIC 
            //Erişim kısıtlaması yoktur. Katmanın ve katmanın referans olduğu tüm katmanlardan erişim sağlanır.
            //Genel olarak ortak metotların her yerden erişilmesi için kullanılır.
            // Public olarak tanımlanan class'ı Main() içerisinde "new" anahtar sözcüğü ile erişim sağlanır.


            // PROTECTED (Korunumlu)
            //  Protected class yanlızca tanımlandıkları class ve türetildikleri class'lar üzerinden erişim sağlanır. Bunların dışındaki class'lar dan Protected class'lara erişim sağlanamaz.

            Program program = new Program();
            program.Id = 109;
            program.Name = "C# Tutorials";
            program.Author = "Yazar";

            Console.WriteLine(program.Id);
            Console.WriteLine(program.Name);
            Console.WriteLine(program.Author); // Book Class'ını Main Program Class'ımızın içine inherit edebildikten sonra onun içindeki verilere ulaşabiliyoruz.

        }
    }

    internal class BaseClass
    // Internal Class kullanımını görelim. BaseClass türünü Internal Class olarak tanımlayalım. Main metodu içerisinde BaseClass()' a erişim sağlandığını görüyoruz.
    {
        internal int Id { get; set; }
        internal int UserId { get; set; }
        internal DateTime CreatedDate { get; set; }
    }
    public class Book
    {
        protected int Id { get; set; }
        protected string Name { get; set; }
        protected string Author { get; set; }
    }
}
    

