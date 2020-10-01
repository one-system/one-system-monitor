using System;
using System.Net.NetworkInformation;
using OneSystemMonitor.PingModule.PingAggregate;
using Xunit;

namespace OneSystemMonitor.Domain
{
    public class PingOperationTest : OneSystemMonitorDomainTestBase
    {
        #region PingResource

        [Fact]
        public void PingResource()
        {
            // Act
            PingReply result = PingOperation.PingResource("www.google.com");

            // Log
            Console.WriteLine(result.ToString());
            Console.WriteLine(result.Address.ToString());

            // Assert
            Assert.NotNull(result);
        }

        #endregion
    }
}
