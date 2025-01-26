using DesignPatterns.Creational.AbstractFactory;
using FluentAssertions;
using System.ComponentModel;

namespace Testing.Creational.AbstractFactory
{
    [TestFixture()]
    public class AbstractFactoryMainTests
    {
        private DesignPatterns.Creational.AbstractFactory.AbstractFactory _sut;

        [OneTimeSetUp]
        public void SetUp()
        {
            _sut = new();
        }

        [Test()]
        [DisplayName("GIVEN a male dog input" +
            "THEN get the right animal")]
        public void CreateAnimalTest()
        {   //Creates a very specific object that belongs to a "family" of objects that shares some "traits" with other different "families"
            //If one day another "family", or a "trait" is added doesn't need to CHANGE the code, but only to ADD.
            IAnimal res = _sut.CreateAnimal('M', "Dog");
            res.Should().BeOfType<MaleDog>();
            //Notice that is MaleDog only in runtime
            ((MaleDog)res).DigHole().Should().BeTrue();
        }

        [Test()]
        [DisplayName("GIVEN a female dog input" +
            "THEN get the right animal")]
        public void CreateFemaleDog()
        {
            IAnimal res = _sut.CreateAnimal('F', "Dog");
            res.Should().BeOfType<FemaleDog>();
            ((FemaleDog)res).DigHole().Should().BeFalse();
        }

        [Test()]
        [DisplayName("GIVEN a male chicken input" +
           "THEN get the right animal")]
        public void CreateMaleChicken()
        {
            IAnimal res = _sut.CreateAnimal('M', "Chicken");
            res.Should().BeOfType<MaleChicken>();
            ((MaleChicken)res).MakeEgg().Should().BeFalse();
        }
    }
}