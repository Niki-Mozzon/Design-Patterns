using DesignPatterns.Creational.Prototype;
using FluentAssertions;
using System.ComponentModel;
using Data = DesignPatterns.Data;

namespace Testing.Creational.Prototype
{
    [TestFixture()]
    public class Prototype
    {
        private Car _sut;

        [OneTimeSetUp]
        public void SetUp()
        {
            _sut = new(Data.ECarType.Sport);
        }

        [Test()]
        [DisplayName("GIVEN a car" +
            "WHEN cloned" +
            "THEN create copy with the same characteristics")]
        public void CloneTest()
        {
            Car clone = (Car)_sut.Clone();
            clone.Type.Should().Be(_sut.Type);
        }
    }
}