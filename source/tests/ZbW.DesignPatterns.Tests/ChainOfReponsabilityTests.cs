using System;
using FluentAssertions;
using Xunit;
using ZbW.DesignPatterns.ChainOfResponsibility;
using ZbW.DesignPatterns.Command;

namespace ZbW.DesignPatterns.Tests
{
    public class ChainOfReponsabilityTests
    {
        [Fact]
        public void TestAlarm()
        {
            var lightAlarm = new LightAlarm();
            var PoliceAlarm = new PoliceAlarm();

            lightAlarm.SetNext(PoliceAlarm);

            var alarm = Intruder.IntruderDetected(lightAlarm);

            alarm.Should().Be("Intruders detected" + Environment.NewLine + "Lights have done the swirly thing!" + Environment.NewLine + "Tü ta tü ta... Police! Open the Door!" + Environment.NewLine);

        }
    }
}
