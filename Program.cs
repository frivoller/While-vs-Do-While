//while example
// 1. While döngüsü, koşul sağlanmadığı sürece döngüye girmeyecek ve eğer limit değeri negatifse hiç çalışmayacaktır.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir limit değeri girin: ");
        int limit = Convert.ToInt32(Console.ReadLine());
        int sayaç = 0;

        while (sayaç <= limit)
        {
            Console.WriteLine("Ben bir Patika'lıyım");
            sayaç++;
        }
    }
}
//do-while example
// 2. Do-While döngüsü ise en az bir kez çalışır, bu yüzden limit negatif olsa bile "Ben bir Patika'lıyım" mesajı en az bir kez ekrana yazdırılır.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir limit değeri girin: ");
        int limit = Convert.ToInt32(Console.ReadLine());
        int sayaç = 0;

        do
        {
            Console.WriteLine("Ben bir Patika'lıyım");
            sayaç++;
        } while (sayaç <= limit);
    }
}
// 3. While döngüsü kullanıcıdan aldığı limit değerini kontrol etmeden çalışmaya başlamazken, do-while en az bir kez çalışacağı için kullanıcının negatif bir değer girmesi durumunda bu farkı gözlemleyebilirsiniz.
