using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Client
    {
        private readonly ITarget _target;

        public Client(ITarget target)
        {
            _target = target;
        }

        public void ProcessRequest()
        {
            _target.Request();
        }
    }
}
