using System;

namespace ARRAYS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrayler Tek boyutlu ve çok boyutlu olmak üzere yaratılmışlardır.
            // tek boyutlu Arrayler içerisinde tek bir satır üzerine sıralı bir şekilde değerleri atamamıza izin veren Array türüdür

            // Single Dimension Array
            int[] MyClassroom = new int[]
            {
                5,6,7,8,9
            };
            // Çok Boyutlu Arrayler ise birden fazla satır aralığına birden fazla sıralı değer atayabildiğimiz Array türüdür
            // Multi Dimension Array 
            string[,] MyClassroom2 = new string[2, 3]
            {
               /* İlk satır*/ {"Ali","Ayşe","Ahmet" }, /* İkinci satır */{"Sedat","Ece","Kayra"},

            };
            // [0, 0] returns the value of the first row and first column and[1, 1] returns the value from the second row and second column.
            Console.WriteLine(MyClassroom2[1, 2]);

            // Multi Dimensional Arrays örnekleri
            int[,] arr2d = new int[3, 2]
            {
                    {1,2 },
                    {3,4 },
                    {5,6 }
            }; // two-dimensional array
               //arr2d[0, 0]; //returns 1
               //arr2d[0, 1]; //returns 2
               //arr2d[1, 0]; //returns 3
               //arr2d[1, 1]; //returns 4
               //arr2d[2, 0]; //returns 5
               //arr2d[2, 1]; //returns 6
            Console.WriteLine(arr2d[2, 1]); // arr2d Arrayinin 3. Satırının 2. Sırasındaki değeri ekrana yazdırmamıza yarayan komut

            int[,,] arr3d; // three-dimensional array
            int[,,,] arr4d; // four-dimensional array
            int[,,,,] arr5d; // five-dimensional array

            // TANIMLAMALARI BÖYLE YAPILIYOR

            // Two-dimensional array.
            int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            // The same array with dimensions specified.
            int[,] array2Da = new int[4, 2] {/*İlk satır*/ { 1, 2 }, /*İkinci satır*/{ 3, 4 },/* Üçüncü Satır*/ { 5, 6 },/* Dördüncü satır*/ { 7, 8 } };
            // A similar array with string elements.
            string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" },
                                        { "five", "six" } };

            // Three-dimensional array.
            int[,,] array3D = new int[,,] {  { { 1, 2, 3 }, { 4, 5, 6 } },
                                 { { 7, 8, 9 }, { 10, 11, 12 } } };
            // The same array with dimensions specified.
            int[,,] array3Da = new int[2, 2, 3] {/* 2 Farklı olacak Array dizisinin ilk Array'inin ilk Satırı*/ { { 1, 2, 3 },/* ilk Array'inin ikinci Satırı*/ { 4, 5, 6 } },
                                                  /* 2. Array'in ilk satırı*/{ { 7, 8, 9 },/* '. Array'in satırı Satırı*/ { 10, 11, 12 } } };
            int[,] array5;
            array5 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };   // OK
                                                                              //array5 = {{1,2}, {3,4}, {5,6}, {7,8}};   // Error

            array5[2, 1] = 25; // Buradaki örnek belirli bir dizi ögesine değer atar.

            int elementValue = array5[2, 1]; // Benzer şekilde, yandaki örnek, belirli bir dizi öğesinin değerini alır ve bunu değişkenine atar (elementValue) .

            /*-------------------------------------------------------------JAGGED ARRAYS (Pürüzlü Diziler)----------------------------------- */

            // Jagged Arrayler, öğeleri Array olan ve muhtemelen farklı boyutlarda olan bir Array. Pürüzlü bir dizi bazen "Array'in Array'i" olarak adlandırılır. Aşağıdaki örneklerde,  pürüzlü dizileri bildirme, başlatma ve erişme işlemlerinin nasıl yapılacağı gösterilmektedir.


            //Aşağıda, her biri tek boyutlu tamsayılar dizisi olan üç öğesi olan tek boyutlu bir dizinin bildirimi verilmiştir:

            int[][] jaggedArray = new int[3][];

            // Kullanabilmeniz için jaggedArray , öğesinin öğelerinin başlatılmış olması gerekir. Aşağıdaki gibi öğeleri başlatabilirsiniz:
            jaggedArray[0] = new int[5]; // 1. Dizi 5 elemanlı
            jaggedArray[1] = new int[4]; // 2. Dizi 4 elemanlı
            jaggedArray[2] = new int[2]; // 3. Dizi ise 2 elemanlı

            // Jagged Arrays ve Multidimension Arrayleri karıştırmak mümkündür. Aşağıda, farklı boyutlarda 3 2 boyutlu dizi öğeleri içeren tek boyutlu pürüzlü bir dizinin bildirimi ve başlatılması yer almaktadır.

            int[][,] jaggedArray4 = new int[3][,]
{
                 new int[,] { /* ilk satır*/{1,3},/* 2. satır*/ {5,7} }, //1. Dizi [2,2]
                 new int[,] { {0,2}, {4,6}, {8,10} }, // 2. Dizi [3,2]
                 new int[,] { {11,22}, {99,88}, {0,9} } // 3. Dizi [3,2]
};

            // Eğer Console.WriteLine(jaggedArray4.Length); kodunu kullanırsam Jagged Array de bulunan bulunan dizilerin sayısını döndürür. Örneğin, önceki diziyi bildirdiğiniz varsayılarak
            //  Bu satır 3 Değerini döndürür çünkü Toplamda 3 farklı dizi tanımladım tek dizinin içine

            // ÖRNEK 

            // 2 Elementli henüz sınırları belirlenmemiş bir array tanımladım
            int[][] arr = new int[2][];

            // Elementlerin sınırlarını ve değerlerini belirliyorum
            arr[0] = new int[5] { 1, 3, 5, 7, 9 }; // İlk elementin 5 değeri var
            arr[1] = new int[4] { 2, 4, 6, 8 }; // ikinci elementin ise 4 değer sınırı var

            // Array Elementlerini Ekrana yazdırma döngüsü
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Element({0}): ", i);

                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("{0}{1}", arr[i][j], j == arr[i].Length - 1 ? "" : " ");
                }
                Console.WriteLine();
            }
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();



            // ------------------------------------------------- ARRAY METHODS --------------------------------------
            // Bu bölümde işinize en çok yarayacak Top 10 Array Methodunu göstereceğim


            // 1 )     IndexOf() 
            //- Eğer Array tanımlanırken Array int[] olarak tanımlanmamışsa  Array.IndexOf(.....)



            string[] meyveler = new string[]
            {
                "lemon","apple", "banana", "orange","cherry", "blackberry"
            };

            Console.WriteLine(Array.IndexOf(meyveler, "apple", 1, 3));

            // Ya da 

            var indexno = Array.IndexOf(meyveler, "apple");
            Console.WriteLine(indexno);

            Console.WriteLine("--------------------------------");


            //2)    Exist()
            // Eğer Array tanımlarken int[] olarak tanımlanmmışsa Array.Exist(.........)


            string[] cities = new string[]
            {
                "İstanbul", "İzmir",
                "Ankara", "Trabzon", "Mardin",
                "Antalya", "Tokat", "Hatay"
            };

            Console.WriteLine("Şehir: {0}", Array.Exists(cities, e => e == "İstanbul"));
            Console.WriteLine("Şehir: {0}", Array.Exists(cities, e => e.Contains("Hatay")));
            Console.WriteLine("Şehir: {0}", Array.Exists(cities, e => e.StartsWith("T")));

            // Ya da 

            var exist1 = Array.Exists(cities, e => e == "İstanbul");
            Console.WriteLine(exist1);
            var exist2 = Array.Exists(cities, e => e.Contains("r"));
            Console.WriteLine(exist2);
            var exist3 = Array.Exists(cities, e => e.StartsWith("F"));
            Console.WriteLine(exist3);
            Console.WriteLine("--------------------------------");

            //3)      Array.Find()


            string[] cities2 = new string[]
            {
                "İstanbul", "İzmir",
                "Ankara", "Trabzon", "Mardin",
                "Antalya", "Tokat", "Hatay"
            };

            string city = Array.Find(cities2, e => e.Contains("y"));
            Console.WriteLine(city);


            Console.WriteLine("--------------------------------");

            // 4)     Array.FindLast()


            string[] cities3 =
            {
                "İstanbul", "İzmir",
                "Ankara", "Trabzon", "Mardin",
                "Antalya", "Tokat", "Hatay"
            };

            string city2 = Array.FindLast(cities3, e => e.Contains("y"));
            Console.WriteLine(city2);


            Console.WriteLine("--------------------------------");
            // 5)     Array.FindIndex()


            string[] cities4 =
           {
                "İstanbul", "İzmir",
                "Ankara", "Trabzon", "Mardin",
                "Antalya", "Tokat", "Hatay"
            };

            var city3 = Array.FindIndex(cities4, e => e.Contains("y"));
            Console.WriteLine(city3);

            Console.WriteLine("--------------------------------");
            //6)       Array.Reverse()


            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (int value in numbers)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine(" ");

            Array.Reverse(numbers);

            foreach (var value2 in numbers)
            {
                Console.WriteLine(value2);
            }
            Console.WriteLine("--------------------------------");

            // 7)     Array.Copy()

            int[] numbers1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] numbers2 = new int[numbers.Length];
            Array.Copy(numbers1, numbers2, numbers1.Length/*Buraya 5 yazsaydım ilk 5 index değerine sahip değerleri yerleştirirdi ama Length yazarak tamamının kopyalanmasını sağladım*/);

            foreach (var value in numbers2)
            {
                Console.WriteLine(value);
            }


            Console.WriteLine("--------------------------------");

            // 8)     Array.Sort()

            int[] values = { 6, 3, 2, 1, 5, 4, 8, 7, 9 };

            Array.Sort(values);

            foreach (var sayi in values)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("--------------------------------");
            // 9)     Array.BinarySearch()


            int[] values2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Array.Sort(values2); // BinarySearch kullanmadan önce mutlaka Array'i Sort ile sıralaman gerekiyor.

            int index1 = Array.BinarySearch(values2, 1);
            int index2 = Array.BinarySearch(values2, 5);

            Console.WriteLine(index1);
            Console.WriteLine(index2);



        }
    }
}
