using System;

namespace Inheritance
{
    public class Bitkiler:Canlilar
    {
        protected void FotosentezYapmak()
        {
            Console.WriteLine("Bitkiler Fotosentez Yapar...");
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