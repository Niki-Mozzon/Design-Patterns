using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using FluentAssertions;
using DesignPatterns.Behavioral.Observer;

namespace Testing.Behavioral.Observer
{
    [TestFixture()]
    public class ObserverTests
    {

        private Subject _sut;

        [OneTimeSetUp]
        public void SetUp()
        {
            _sut = new();
        }

        [Test()]
        [DisplayName("GIVEN 1 subject and 2 observers" +
            "WHEN the observervers are registered and the subject does something" +
            "THEN the observers will increase their record")]
        public void ObserverTest()
        {
            //The subject is what the observers are subscribed to
            //I create some future observers
            SMS smsService = new SMS();
            Email emailService = new Email();
            //I subscribe the observers
            _sut.Register(smsService);
            _sut.Register(emailService);
            //I make the subject do its thing
            _sut.DoSomething();
            //I unsubscribe an observer
            _sut.Unregister(smsService);
            //I make the subject do its thing again
            _sut.DoSomething();
            //I unsubscribe the other observer
            _sut.Unregister(emailService);
            //The sms service should have only one message because it was unsubscribed before
            smsService.Messages.Should().Be(1);
            //The email service should have two messages
            emailService.Emails.Should().Be(2);
        }
    }
}