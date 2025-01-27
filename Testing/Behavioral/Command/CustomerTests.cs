using DesignPatterns.Behavioral.Command;
using System.ComponentModel;
using FluentAssertions;
using Data = DesignPatterns.Behavioral.Command.Data;

namespace Testing.Behavioral.Command
{
    [TestFixture()]
    public class CommandTests
    {
        private Customer _sut;

        [OneTimeSetUp]
        public void SetUp()
        {
            _sut = new();
        }

        [Test()]
        [DisplayName("GIVEN a inkvoker (customer) and a command" +
            "THEN perform the right action")]
        public void ExecuteCommandsTest()
        {
            //The customer doesn't know anything about how to do an action
            //The customer only knows who to call to do the action
            _sut.SetCommand(new Gardener());
            Data.EAction res = _sut.ExecuteCommand();
            res.Should().Be(Data.EAction.MowLawn);
            //Change the command on runtime
            _sut.SetCommand(new Mechanic(Data.EVehicle.Bike));
            res = _sut.ExecuteCommand();
            res.Should().Be(Data.EAction.FixBike);
            //we can also create a list of commands to have an history
            //each command can also have an undo method 
            // in this way we can implement the undo/redo functionality
        }
    }
}