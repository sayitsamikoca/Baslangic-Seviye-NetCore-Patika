using System;

namespace Inheritance
{
    public class Bitkiler:Canlilar
    {
        protected void FotosentezYapmak()
        {
            Console.WriteLine("Bitkiler Fotosentez Yapar...");
        }

        public override void UyaranlaraTepki()
        {
            // base.UyaranlaraTepki();
            Console.WriteLine("Bitkiler Güneşe Tepki Verir.");
        }
    }

    public class TohumluBitkiler:Bitkiler
    {
        public TohumluBitkiler()
        {
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();
        }

        public void TohumlaCogalma()
        {
            Console.WriteLine("Tohumlu Bitkiler tohum ile çoğalır...");
        }
    }

    public class TohumsuzBitkiler:Bitkiler
    {
         public TohumsuzBitkiler()
        {
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void SporlaCogalma()
        {
            Console.WriteLine("Tohumsuz Bitkiler sporla çoğalır...");
        }
    }


}