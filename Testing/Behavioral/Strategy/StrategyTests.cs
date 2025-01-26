using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using FluentAssertions;
using DesignPatterns.Behavioral.Strategy;

namespace Testing.Behavioral.Strategy
{
    [TestFixture()]
    public class StrategyTests
    {
        //Let's you change the behavior of an object at runtime

        [Test()]
        [DisplayName("GIVEN an animal able to fly and one unable to fly" +
            "WHEN enabled to fly" +
            "THEN both the animal are able to fly")]
        public void CreateAnimalTest()
        {   //Can fly from the beginning
            Bird bird = new Bird(new CanFly());
            //Cannot fly from the beginning
            Lepidoptera caterpillar = new Lepidoptera(new CannotFly());
            //Cannot fly
            caterpillar.TryToFly().Should().BeFalse();
            bird.TryToFly().Should().BeTrue();
            //Enable fly
            caterpillar.FlyingType = new CanFly();
            //Now can fly
            caterpillar.TryToFly().Should().BeTrue();
        }
    }
}