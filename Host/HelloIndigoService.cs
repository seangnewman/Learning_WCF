﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Host
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HelloIndigoService" in both code and config file together.
    public class HelloIndigoService : IHelloIndigoService
    {
        
        public string HelloIndigo()
        {
            return "Hello Indigo!";
        }
    }
}
