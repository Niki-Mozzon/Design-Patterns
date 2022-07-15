using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Strategy
{
    internal class StrategyMain
    {/*
        Caterpillars are in the lepidoptera family, they cannot fly at the larvae stage, but they can when they turn into butterflies.
        The strategy patterns allow us to change the behaviour of a class in a fancy way in runtime.
        The caterpillar cannot fly, but then, we make it able to fly.
      */
        public static void Run()
        {
            Bird bird = new Bird("Robin", "Cip", new CanFly());
            Lepidoptera caterpillar = new Lepidoptera("Caterpillar", "Gngn", new CannotFly());
            caterpillar.Play();
            bird.Play();
            //Cannot fly
            caterpillar.TryToFly();
            bird.TryToFly();
            //Now can fly
            caterpillar.FlyingType = new CanFly();
            caterpillar.TryToFly();
        }
    }
}
