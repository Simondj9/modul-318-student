using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using SwissTransport.Core;
using SwissTransport.Models;
using Xunit;
namespace SwissTransport
{
    public class Testen
    {
        private readonly ITransport testee;

        public Testen()
        {
            this.testee = new Transport();
        }
        [Fact]
        public void MyTest()
        {
            Stations stations = this.testee.GetStations("Meggen,");

            stations.StationList.Should().NotBeNull();
        }
    }
}
