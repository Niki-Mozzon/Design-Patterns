using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    internal class StrategyMain
    {/*
        Caterpillars are in the lepidoptera family, they cannot fly at the larvae stage, but they can when they turn into butterflies.
        The strategy patterns allow us to change the behaviour of a class in a fancy way in runtime.
        The caterpillar cannot fly, but then, we make it able to fly.
      */
        public void Run()
        {
            //Can fly from the beginning
            Bird bird = new Bird(new CanFly());
            //Cannot fly from the beginning
            Lepidoptera caterpillar = new Lepidoptera(new CannotFly());
            //Cannot fly
            caterpillar.TryToFly();
            bird.TryToFly();
            caterpillar.FlyingType = new CanFly();
            //Now can fly
            caterpillar.TryToFly();
        }
    }
}
