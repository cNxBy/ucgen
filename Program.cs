namespace üçgen_mi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üçgen açılarından birini  giriniz");
            int a, b, c,toplam ;
            Console.WriteLine("1. üçgen açısını  giriniz");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.üçgen açısını  giriniz ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. üçgen açısını giriniz.");
            c = Convert.ToInt32(Console.ReadLine());
            toplam = a+b+c;
            Console.WriteLine("Toplam"+toplam);
            if (toplam == 180) { Console.WriteLine("Üçgendir"); }
            else if (toplam > 180) { Console.WriteLine("Üçgen değildir"); }
            else if(toplam < 180) { Console.WriteLine("Üçgen değildir"); }
                
            
           


        }
    }
}
