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
            Alarm alarm = new LightAlarm()
                .SetNext(new PoliceAlarm());

            string text = alarm.ToDo("Intruder Detected!");

            text.Should().Be("");

        }
    }
}
