﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.ClassAdapter
{
    public class Adapter : Adaptee, ITarget
    {
        public void Request()
        {
            base.OtherRequest();
        }
    }
}
