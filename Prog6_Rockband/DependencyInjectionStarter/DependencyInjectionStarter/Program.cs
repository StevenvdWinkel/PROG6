using DependencyInjectionStarter.Library;
using System;

namespace DependencyInjectionStarter
{
    class Program
    {
        /** Testing 123 */
        static void Main()
        {
            BandLocator bandLocator = new BandLocator();
            RockBand rockBand = bandLocator.Metallica;
            rockBand.DoSoundCheck();

            Console.ReadLine();
        }
    }
}
