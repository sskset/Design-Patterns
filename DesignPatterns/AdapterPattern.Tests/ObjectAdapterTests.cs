using FluentAssertions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AdapterPattern.Tests
{
    public class ObjectAdapterTests
    {
        [Fact]
        public void Test()
        {
            var adaptee = new Adaptee();

            string expectedOutputString = GetExpectedOutputString(adaptee);

            var adapter = new ObjectAdapter.Adapter(adaptee);
            var client = new Client(adapter);
            string actualOutputString = GetActualOutputString(client);

            actualOutputString.Should().Be(expectedOutputString);
        }

        private static string GetActualOutputString(Client client)
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                client.ProcessRequest();

                return sw.ToString();

            }
        }

        private static string GetExpectedOutputString(Adaptee adaptee)
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                adaptee.OtherRequest();

                return sw.ToString();
            }
        }
    }
}
