using System;
using System.Collections.Generic;

namespace DependencyInjectionStarter.Library
{
    public class RockBand
    {
        private List<IInstrument> instruments;

        public RockBand(List<IInstrument> instruments)
        {
            this.instruments = instruments;
        }

        public void DoSoundCheck()
        {
            foreach (var i in instruments)
            {
                Console.WriteLine(i.Play());
            }
        }
    }
}
