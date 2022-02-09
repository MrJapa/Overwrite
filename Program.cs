using System;

namespace Override
{
    public class Klasse1
    {
        public virtual void PrintKlasse()
        {
            Console.WriteLine("Fra klasse 1");
        }
    }
    public class Klasse2 : Klasse1
    {
        public override void PrintKlasse()
        {
            Console.WriteLine("Fra klasse 2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Klasse2 k2 = new Klasse2();
            k2.PrintKlasse();
            Klasse1 k1 = new Klasse1();
            k1.PrintKlasse();
        }
    }
}