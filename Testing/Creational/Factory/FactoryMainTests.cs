using System.ComponentModel;
using FluentAssertions;
using DesignPatterns.Creational.Factory;


namespace Testing.Creational.Factory
{
    [TestFixture()]
    public class FactoryMainTests
    {

        private DesignPatterns.Creational.Factory.Factory _sut;

        [OneTimeSetUp]
        public void SetUp()
        {
            _sut = new();
        }

        [Test()]
        [DisplayName("GIVEN a 4 legs" +
            "THEN create quadrupede")]
        public void CreateQuadrupedeTest()
        {   //Delegates the creation of an object to another class
            //If one day another "family", or a "trait" is added doesn't need to CHANGE the code, but only to ADD.
            Animal res = _sut.CreateAnimal(4);
            res.Should().BeOfType<Quadruped>();
        }
        [Test()]
        [DisplayName("GIVEN a 2 legs" +
            "THEN create biped")]
        public void CreateBipedTest()
        {
            Animal res = _sut.CreateAnimal(2);
            res.Should().BeOfType<Biped>();
        }
    }
}