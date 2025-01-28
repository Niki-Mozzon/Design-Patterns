using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Data;
using DesignPatterns.Behavioral.Command;
using FluentAssertions;
using System.ComponentModel;
using DesignPatterns.Behavioral.ChainOfResponsibility;

namespace Testing.Behavioral.ChainOfResponsibility
{
    [TestFixture()]
    public class ChainOfResponsabilityTests
    {

        [Test()]
        [DisplayName("GIVEN a request (passenger)" +
            "WHEN the request is handled by the chain" +
            "THEN return true")]
        public void HandleTest()
        {
            Passenger passenger = new Passenger()
            {
                hasAllowedGoods = true,
                hasPassport = true,
                hasTicket = true
            };
            Custom custom = new();
            Immigration immigration = new();
            Gate gate = new();
            //Componing the chain, can be set dynamically (like here)
            //or from the handler themselves, depends on the reusability
            custom.SetNext(immigration)
                .SetNext(gate);
            bool isPassengerValid = custom.Handle(passenger);
            isPassengerValid.Should().BeTrue();
        }

        [Test()]
        [DisplayName("GIVEN a request (passenger) without ticket" +
            "WHEN the request is handled by the chain" +
            "THEN return false")]
        public void HandleBreakTest()
        {
            Passenger passenger = new Passenger()
            {
                hasAllowedGoods = true,
                hasPassport = true,
                hasTicket = false
            };
            Custom custom = new();
            Immigration immigration = new();
            Gate gate = new();
            //Componing the chain, can be set dynamically (like here)
            //or from the handler themselves, depends on the reusability
            custom.SetNext(immigration)
                .SetNext(gate);
            bool isPassengerValid = custom.Handle(passenger);
            isPassengerValid.Should().BeFalse();
        }

    }
}