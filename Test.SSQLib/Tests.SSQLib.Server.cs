﻿using SSQLib;
using System.Net;
using Xunit;

namespace Test.SSQLib
{
    public class ServerTests
    {
        [Fact]
        public void TestFakeServerThrowsExceptionWithIpEndpoint()
        {
            Assert.Throws(typeof(SSQLServerException), () =>
                {
                    SSQL query = new SSQL();
                    //127.0.0.2 set to stop loopback potentially resolving and failing test
                    query.Server(new IPEndPoint(IPAddress.Parse("127.0.0.2"), 27015));
                });
        }

        [Fact]
        public void TestFakeServerThrowsExceptionWithStringIp()
        {
            Assert.Throws(typeof(SSQLServerException), () =>
            {
                SSQL query = new SSQL();
                //127.0.0.2 set to stop loopback potentially resolving and failing test
                query.Server("127.0.0.2", 27015);
            });
        }
    }
}
