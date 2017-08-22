using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AdapterPattern.Tests
{
    public class ClassAdapterTests
    {
        [Fact]
        public void Test()
        {
            ITarget target = new ClassAdapter.Adapter();
            var client = new Client(target);
            client.ProcessRequest();
        }
    }
}
